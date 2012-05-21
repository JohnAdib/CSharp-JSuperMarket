using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JSuperMarket.Forms.frm_Base;

namespace JSuperMarket.frm_Customers
{
    public partial class frm_Customers_Add : FrmBaseAddData
    {
        public frm_Customers_Add()
        {
            InitializeComponent();
        }

        private void jscClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jscAdd1_Click(object sender, EventArgs e)
        {
            if (jscTextBox1.Text == "")
                return;

            FrmCustomersClass RelatedClass = new FrmCustomersClass();
            RelatedClass._CName = jscTextBox1.Text;
            RelatedClass._CAddress = jscTextBox2.Text;
            RelatedClass._CTel = jscTextBox3.Text;
            RelatedClass._CMobile = jscTextBox4.Text;
            RelatedClass._CDesc = jscTextBox5.Text;
            RelatedClass._Credit = jscCheckBox1.Checked;
            RelatedClass.DBAdd();
            
            ((frm_Customers)this.Owner).UpdateDateGrid();
            // above code update data grid view in main form
            jscTextBox1.Text = "";
            jscTextBox2.Text = "";
            jscTextBox3.Text = "";
            jscTextBox4.Text = "";
            jscTextBox5.Text = "";
            jscCheckBox1.Checked = false;

            jscTextBox1.Focus();
        }

        private void frm_Customers_Add_Load(object sender, EventArgs e)
        {

        }

    }
}
