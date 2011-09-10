using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JSuperMarket.frm_Supplier
{
    public partial class frm_Supplier_Add : JSuperMarket.frm_base_AddData
    {
        public frm_Supplier_Add()
        {
            InitializeComponent();
        }

        private void frm_Supplier_Add_Load(object sender, EventArgs e)
        {

        }

        private void jscClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jscAdd1_Click(object sender, EventArgs e)
        {
            if (jscTextBox1.Text == "")
                return;

            frm_Supplier_Class RelatedClass = new frm_Supplier_Class();
            RelatedClass._SName = jscTextBox1.Text;
            RelatedClass._SVisitor = jscTextBox2.Text;
            RelatedClass._SAddress = jscTextBox3.Text;
            RelatedClass._STel = jscTextBox4.Text;
            RelatedClass._SDesc = jscTextBox5.Text;
            RelatedClass.DBAdd();
            ((frm_Supplier)this.Owner).UpdateDateGrid();
            // above code update data grid view in main form
            jscTextBox1.Text = "";
            jscTextBox2.Text = "";
            jscTextBox3.Text = "";
            jscTextBox4.Text = "";
            jscTextBox5.Text = "";

            jscTextBox1.Focus();
        }
    }
}
