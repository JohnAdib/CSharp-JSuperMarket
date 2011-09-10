using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JSuperMarket
{
    public partial class frm_base_AddData : Form
    {
        public frm_base_AddData()
        {
            InitializeComponent();
        }

        private void frm_base_AddData_Load(object sender, EventArgs e)
        {

        }

        private void ClosingEffect(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason.ToString() != "UserClosing")
                e.Cancel = true;
            /*
             else
            
            for (int i = 90; i >= 30; i -= 7)
            {
                this.Opacity = i / 97.0;
                this.Refresh();
                System.Threading.Thread.Sleep(1);

            }
             */
        }
    }
}
