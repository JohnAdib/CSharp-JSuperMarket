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
    public partial class frm_base_ShowData : Form
    {
        public frm_base_ShowData()
        {
            InitializeComponent();
        }

        private void ClosingEffect(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason.ToString() != "UserClosing")
                e.Cancel = true;
            /*
             else
            for (int i = 97; i >= 15; i -= 3)
            {
                this.Opacity = i / 97.0;
                this.Refresh();
                System.Threading.Thread.Sleep(3);

            }
             */
        }

        private void frm_base_ShowData_Load(object sender, EventArgs e)
        {

        }
    }
}
