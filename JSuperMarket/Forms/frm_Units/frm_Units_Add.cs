using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JSuperMarket.frm_Units
{
    public partial class frm_Units_Add : JSuperMarket.frm_base_AddData
    {
        public frm_Units_Add()
        {
            InitializeComponent();
        }

        private void jscAdd1_Click(object sender, EventArgs e)
        {
            if (jscTextBox1.Text == "")
                return;

            frm_Units_Class RelatedClass = new frm_Units_Class();
            RelatedClass._PUName = jscTextBox1.Text;
            RelatedClass.DBAdd();
            ((frm_Units)this.Owner).UpdateDateGrid();
            // above code update data grid view in main form
            jscTextBox1.Text = "";
            jscTextBox1.Focus();
        }

        private void jscClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
