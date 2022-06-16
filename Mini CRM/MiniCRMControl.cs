using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using Rappen.XRM.Helpers.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using XrmToolBox.Extensibility;

namespace Mini_CRM
{
    public partial class MiniCRMControl : PluginControlBase
    {
        #region Constructer

        public MiniCRMControl()
        {
            InitializeComponent();
        }

        #endregion Constructer

        #region Private Event Methods

        private void MyPluginControl_ConnectionUpdated(object sender, ConnectionUpdatedEventArgs e)
        {
            xrmView.Service = e.Service;
            xrmDataGrid.Service = e.Service;
            xrmRecordHost.Service = e.Service;
            GetEntities();
        }

        private void chkManager_CheckedChanged(object sender, EventArgs e)
        {
            GetEntities();
        }

        private void xrmEntity_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetViews();
        }

        private void xrmView_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetData();
        }

        private void xrmDataGrid_RecordEnter(object sender, Rappen.XTB.Helpers.Controls.XRMRecordEventArgs e)
        {
            xrmRecordHost.Record = e.Entity;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveIt();
        }

        #endregion Private Event Methods

        #region Private Features

        private void GetEntities()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Load Entities...",
                Work = (w, args) =>
                {
                    args.Result = Service.LoadEntities().EntityMetadata;
                },
                PostWorkCallBack = (a) =>
                {
                    if (a.Error != null)
                    {
                        ShowErrorDialog(a.Error);
                    }
                    else if (a.Result is IEnumerable<EntityMetadata> result)
                    {
                        xrmEntity.DataSource = result
                            .Where(e => chkManager.Checked || e.IsManaged == false);
                    }
                }
            });
        }

        private void GetViews()
        {
            xrmDataGrid.DataSource = null;
            var entity = xrmEntity.SelectedEntity;
            if (entity == null || xrmEntity.SelectedIndex == -1)
            {
                xrmView.DataSource = null;
                lblColumn.Text = "";
                return;
            }

            xrmPrimaryText.Column = entity.PrimaryNameAttribute;
            lblColumn.Text = entity.DisplayName.UserLocalizedLabel.Label + " name";

            var query = new QueryExpression("savedquery");
            query.ColumnSet.AddColumns("name", "fetchxml");
            query.AddOrder("name", OrderType.Ascending);
            query.Criteria.AddCondition("returnedtypecode", ConditionOperator.Equal, entity.LogicalName);
            query.Criteria.AddCondition("fetchxml", ConditionOperator.NotNull);

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Load Views",
                Work = (w, args) =>
                {
                    args.Result = Service.RetrieveMultiple(query);
                },
                PostWorkCallBack = (a) =>
                {
                    if (a.Error != null)
                    {
                        ShowErrorDialog(a.Error);
                    }
                    else if (a.Result is EntityCollection result && xrmEntity.SelectedIndex > -1)
                    {
                        xrmView.DataSource = result;
                    }
                    else
                    {
                        xrmView.DataSource = null;
                    }
                }
            });
        }

        private void GetData()
        {
            var fetch = xrmView.SelectedRecord?.GetAttributeValue<string>("fetchxml");
            if (string.IsNullOrEmpty(fetch))
            {
                xrmDataGrid.DataSource = null;
                return;
            }
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Load Data...",
                Work = (w, args) =>
                {
                    args.Result = Service.RetrieveMultiple(new FetchExpression(fetch));
                },
                PostWorkCallBack = (a) =>
                {
                    if (a.Error != null)
                    {
                        ShowErrorDialog(a.Error);
                    }
                    else if (a.Result is EntityCollection result && xrmView.SelectedIndex > -1)
                    {
                        xrmDataGrid.DataSource = result;
                    }
                    else
                    {
                        xrmDataGrid.DataSource = null;
                    }
                }
            });
        }

        private void SaveIt()
        {
            WorkAsync(new WorkAsyncInfo
            {
                Message = "Save!",
                Work = (w, args) =>
                {
                    args.Result = xrmRecordHost.SaveChanges();
                },
                PostWorkCallBack = (a) =>
                {
                    if (a.Result is bool result && result)
                    {
                        GetData();
                    }
                }
            });
        }

        #endregion Private Features
    }
}