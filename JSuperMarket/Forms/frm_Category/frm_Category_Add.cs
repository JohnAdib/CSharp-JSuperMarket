using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JSuperMarket.Forms.frm_Base;

namespace JSuperMarket
{
    public partial class frm_Category_Add : FrmBaseAddData
    {
        public frm_Category_Add()
        {
            InitializeComponent();
        }

        private void jscAdd1_Click(object sender, EventArgs e)
        {
            if (jscTextBox1.Text == "")
                return;

            FrmCategoryClass RelatedClass = new FrmCategoryClass();
            RelatedClass.CName = jscTextBox1.Text;
            RelatedClass.DBAdd();
            ((FrmCategory)this.Owner).UpdateDateGrid();
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
