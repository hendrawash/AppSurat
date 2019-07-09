using System;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;

namespace Surat
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var connString = "XpoProvider=MSAccess;Provider=Microsoft.ACE.OLEDB.12.0;Mode=Share Deny None;data source=&quot;.\\Surat.accdb&quot;;Jet OLEDB:Database Password=;";            
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(connString, AutoCreateOption.DatabaseAndSchema);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            BonusSkins.Register();
            Application.Run(new FormMain());
        }
    }
}
