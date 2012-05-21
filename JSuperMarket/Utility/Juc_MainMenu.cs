using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JSuperMarket
{
    public partial class JUC_MainMenu : UserControl
    {
        public JUC_MainMenu()
        {
            InitializeComponent();
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ParentForm.Close();
            //Application.Exit();   //not work
        }

        private void aboutJSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Other.frm_AboutJS frmabout = new frm_Other.frm_AboutJS();
            frmabout.ShowDialog();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }
    }
}
