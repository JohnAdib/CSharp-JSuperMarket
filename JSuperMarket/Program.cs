using System;
using System.Windows.Forms;
using JSuperMarket.Forms.frm_Base;

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
            var frmLogin = new FrmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new FrmMainForm(frmLogin.UserName, frmLogin.UserFullName));
            }
        }
    }
}
