using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JSuperMarket.frm_Customers
{
    public partial class frm_Customers_Edit : JSuperMarket.frm_base_AddData
    {
        frm_Customers_Class RelatedClass = new frm_Customers_Class();
        public frm_Customers_Edit(int CID, string CName, string CAddress, string CTel, string CMobile, string CDesc, bool Credit)
        {
            InitializeComponent();
            this.RelatedClass._CID = CID;

            jscTextBox1.Text = CName;
            jscTextBox2.Text = CAddress;
            jscTextBox3.Text = CTel;
            jscTextBox4.Text = CMobile;
            jscTextBox5.Text = CDesc;
            jscCheckBox1.Checked = Credit;
        }

        private void jscClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jscUpdate1_Click(object sender, EventArgs e)
        {
            if (jscTextBox1.Text == "")
                return;

            RelatedClass._CName = jscTextBox1.Text;
            RelatedClass._CAddress= jscTextBox2.Text;
            RelatedClass._CTel = jscTextBox3.Text;
            RelatedClass._CMobile = jscTextBox4.Text;
            RelatedClass._CDesc = jscTextBox5.Text;
            RelatedClass._Credit = jscCheckBox1.Checked;

            RelatedClass.DBUpdate();
            this.Close();
        }

        private void frm_Customers_Edit_Load(object sender, EventArgs e)
        {

        }
    }
}
