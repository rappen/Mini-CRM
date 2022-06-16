namespace Mini_CRM
{
    partial class MiniCRMControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chkManager = new System.Windows.Forms.CheckBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblColumn = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.xrmPrimaryText = new Rappen.XTB.Helpers.Controls.XRMColumnText();
            this.xrmRecordHost = new Rappen.XTB.Helpers.Controls.XRMRecordHost();
            this.xrmDataGrid = new Rappen.XTB.Helpers.Controls.XRMDataGridView();
            this.xrmView = new Rappen.XTB.Helpers.Controls.XRMColumnLookup();
            this.xrmEntity = new Rappen.XTB.Helpers.Controls.XRMEntityComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xrmDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.xrmView);
            this.panel1.Controls.Add(this.chkManager);
            this.panel1.Controls.Add(this.xrmEntity);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 45);
            this.panel1.TabIndex = 0;
            // 
            // chkManager
            // 
            this.chkManager.AutoSize = true;
            this.chkManager.Location = new System.Drawing.Point(134, 3);
            this.chkManager.Margin = new System.Windows.Forms.Padding(1);
            this.chkManager.Name = "chkManager";
            this.chkManager.Size = new System.Drawing.Size(71, 17);
            this.chkManager.TabIndex = 1;
            this.chkManager.Text = "Managed";
            this.chkManager.UseVisualStyleBackColor = true;
            this.chkManager.CheckedChanged += new System.EventHandler(this.chkManager_CheckedChanged);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 45);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(1);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblColumn);
            this.splitContainer1.Panel1.Controls.Add(this.btnSave);
            this.splitContainer1.Panel1.Controls.Add(this.xrmPrimaryText);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.xrmDataGrid);
            this.splitContainer1.Size = new System.Drawing.Size(559, 255);
            this.splitContainer1.SplitterDistance = 185;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // lblColumn
            // 
            this.lblColumn.AutoSize = true;
            this.lblColumn.Location = new System.Drawing.Point(17, 19);
            this.lblColumn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblColumn.Name = "lblColumn";
            this.lblColumn.Size = new System.Drawing.Size(72, 13);
            this.lblColumn.TabIndex = 2;
            this.lblColumn.Text = "Primary Name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(17, 64);
            this.btnSave.Margin = new System.Windows.Forms.Padding(1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(127, 30);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save!";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // xrmPrimaryText
            // 
            this.xrmPrimaryText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xrmPrimaryText.Column = null;
            this.xrmPrimaryText.DisplayFormat = "";
            this.xrmPrimaryText.Location = new System.Drawing.Point(17, 35);
            this.xrmPrimaryText.Margin = new System.Windows.Forms.Padding(1);
            this.xrmPrimaryText.Name = "xrmPrimaryText";
            this.xrmPrimaryText.RecordHost = this.xrmRecordHost;
            this.xrmPrimaryText.Size = new System.Drawing.Size(153, 20);
            this.xrmPrimaryText.TabIndex = 0;
            // 
            // xrmRecordHost
            // 
            this.xrmRecordHost.Id = new System.Guid("00000000-0000-0000-0000-000000000000");
            this.xrmRecordHost.LogicalName = null;
            this.xrmRecordHost.Record = null;
            this.xrmRecordHost.Service = null;
            // 
            // xrmDataGrid
            // 
            this.xrmDataGrid.AllowUserToAddRows = false;
            this.xrmDataGrid.AllowUserToDeleteRows = false;
            this.xrmDataGrid.AllowUserToOrderColumns = true;
            this.xrmDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.xrmDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.xrmDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(112)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.xrmDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.xrmDataGrid.ColumnHeadersHeight = 30;
            this.xrmDataGrid.ColumnOrder = "";
            this.xrmDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xrmDataGrid.FilterColumns = "";
            this.xrmDataGrid.Location = new System.Drawing.Point(0, 0);
            this.xrmDataGrid.Margin = new System.Windows.Forms.Padding(1);
            this.xrmDataGrid.Name = "xrmDataGrid";
            this.xrmDataGrid.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.xrmDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.xrmDataGrid.RowHeadersVisible = false;
            this.xrmDataGrid.RowHeadersWidth = 102;
            this.xrmDataGrid.RowTemplate.Height = 23;
            this.xrmDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.xrmDataGrid.Service = null;
            this.xrmDataGrid.ShowFriendlyNames = true;
            this.xrmDataGrid.ShowIdColumn = false;
            this.xrmDataGrid.ShowIndexColumn = false;
            this.xrmDataGrid.Size = new System.Drawing.Size(373, 255);
            this.xrmDataGrid.TabIndex = 0;
            this.xrmDataGrid.RecordEnter += new Rappen.XTB.Helpers.Controls.XRMRecordEventHandler(this.xrmDataGrid_RecordEnter);
            // 
            // xrmView
            // 
            this.xrmView.Column = null;
            this.xrmView.DisplayFormat = "";
            this.xrmView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xrmView.Filter = null;
            this.xrmView.FormattingEnabled = true;
            this.xrmView.Location = new System.Drawing.Point(217, 22);
            this.xrmView.Margin = new System.Windows.Forms.Padding(1);
            this.xrmView.Name = "xrmView";
            this.xrmView.RecordHost = null;
            this.xrmView.Service = null;
            this.xrmView.Size = new System.Drawing.Size(165, 21);
            this.xrmView.TabIndex = 2;
            this.xrmView.SelectedIndexChanged += new System.EventHandler(this.xrmView_SelectedIndexChanged);
            // 
            // xrmEntity
            // 
            this.xrmEntity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.xrmEntity.FormattingEnabled = true;
            this.xrmEntity.Location = new System.Drawing.Point(7, 22);
            this.xrmEntity.Margin = new System.Windows.Forms.Padding(1);
            this.xrmEntity.Name = "xrmEntity";
            this.xrmEntity.Size = new System.Drawing.Size(198, 21);
            this.xrmEntity.TabIndex = 0;
            this.xrmEntity.SelectedIndexChanged += new System.EventHandler(this.xrmEntity_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Table";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "View";
            // 
            // MiniCRMControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Name = "MiniCRMControl";
            this.Size = new System.Drawing.Size(559, 300);
            this.ConnectionUpdated += new XrmToolBox.Extensibility.PluginControlBase.ConnectionUpdatedHandler(this.MyPluginControl_ConnectionUpdated);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.xrmDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Rappen.XTB.Helpers.Controls.XRMEntityComboBox xrmEntity;
        private System.Windows.Forms.CheckBox chkManager;
        private Rappen.XTB.Helpers.Controls.XRMColumnLookup xrmView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Rappen.XTB.Helpers.Controls.XRMDataGridView xrmDataGrid;
        private Rappen.XTB.Helpers.Controls.XRMColumnText xrmPrimaryText;
        private Rappen.XTB.Helpers.Controls.XRMRecordHost xrmRecordHost;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblColumn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}
