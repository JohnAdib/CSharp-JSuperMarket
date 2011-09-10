using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JSuperMarket
{
    public partial class frm_Category_Add : JSuperMarket.frm_base_AddData
    {
        public frm_Category_Add()
        {
            InitializeComponent();
        }

        private void jscAdd1_Click(object sender, EventArgs e)
        {
            if (jscTextBox1.Text == "")
                return;

            frm_Category_Class RelatedClass = new frm_Category_Class();
            RelatedClass._CName = jscTextBox1.Text;
            RelatedClass.DBAdd();
            ((frm_Category)this.Owner).UpdateDateGrid();
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
