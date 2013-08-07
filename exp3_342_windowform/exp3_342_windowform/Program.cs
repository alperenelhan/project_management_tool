using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Db4objects.Db4o;

namespace exp3_342_windowform
{
    
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
       
        private static void Main()
        {
            IObjectContainer db = Db4oEmbedded.OpenFile(Path.Combine(Application.StartupPath,"..\\..\\exp.yap"));
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginView(db));
        }
    }
}