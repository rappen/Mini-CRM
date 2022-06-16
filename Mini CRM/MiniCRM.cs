using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Reflection;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace Mini_CRM
{
    // Do not forget to update version number and author (company attribute) in AssemblyInfo.cs class
    // To generate Base64 string for Images below, you can use https://www.base64-image.de/
    [Export(typeof(IXrmToolBoxPlugin)),
        ExportMetadata("Name", "Mini CRM"),
        ExportMetadata("Description", "Why create this tool? Because we can! 😁"),
        // Please specify the base64 content of a 32x32 pixels image
        ExportMetadata("SmallImageBase64", "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"),
        // Please specify the base64 content of a 80x80 pixels image
        ExportMetadata("BigImageBase64", "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"),
        ExportMetadata("BackgroundColor", "#0070C0"),
        ExportMetadata("PrimaryFontColor", "#FFFF00"),
        ExportMetadata("SecondaryFontColor", "Gray")]
    public class MiniCRM : PluginBase
    {
        public override IXrmToolBoxPluginControl GetControl()
        {
            return new MiniCRMControl();
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public MiniCRM()
        {
            // If you have external assemblies that you need to load, uncomment the following to
            // hook into the event that will fire when an Assembly fails to resolve
            // AppDomain.CurrentDomain.AssemblyResolve += new ResolveEventHandler(AssemblyResolveEventHandler);
        }

        /// <summary>
        /// Event fired by CLR when an assembly reference fails to load
        /// Assumes that related assemblies will be loaded from a subfolder named the same as the Plugin
        /// For example, a folder named Sample.XrmToolBox.MyPlugin
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        private Assembly AssemblyResolveEventHandler(object sender, ResolveEventArgs args)
        {
            Assembly loadAssembly = null;
            Assembly currAssembly = Assembly.GetExecutingAssembly();

            // base name of the assembly that failed to resolve
            var argName = args.Name.Substring(0, args.Name.IndexOf(","));

            // check to see if the failing assembly is one that we reference.
            List<AssemblyName> refAssemblies = currAssembly.GetReferencedAssemblies().ToList();
            var refAssembly = refAssemblies.Where(a => a.Name == argName).FirstOrDefault();

            // if the current unresolved assembly is referenced by our plugin, attempt to load
            if (refAssembly != null)
            {
                // load from the path to this plugin assembly, not host executable
                string dir = Path.GetDirectoryName(currAssembly.Location).ToLower();
                string folder = Path.GetFileNameWithoutExtension(currAssembly.Location);
                dir = Path.Combine(dir, folder);

                var assmbPath = Path.Combine(dir, $"{argName}.dll");

                if (File.Exists(assmbPath))
                {
                    loadAssembly = Assembly.LoadFrom(assmbPath);
                }
                else
                {
                    throw new FileNotFoundException($"Unable to locate dependency: {assmbPath}");
                }
            }

            return loadAssembly;
        }
    }
}