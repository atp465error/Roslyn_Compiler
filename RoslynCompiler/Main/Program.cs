namespace RoslynCompiler
{
    using System;
    using System.Reflection;
    using System.Windows.Forms;

    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            typeof(Form).GetField(name: "defaultIcon", bindingAttr: BindingFlags.NonPublic |
                 BindingFlags.Static).SetValue(obj: null, value: Properties.Resources.package);
            Application.Run(mainForm: new RoslynD());
        }
    }
}