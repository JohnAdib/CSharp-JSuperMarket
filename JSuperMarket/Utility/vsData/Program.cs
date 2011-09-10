using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JSuperMarket
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frm_Login frmLogin = new frm_Login();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frm_MainForm(frmLogin.UserName, frmLogin.UserFullName));
            }
        }
    }
}
