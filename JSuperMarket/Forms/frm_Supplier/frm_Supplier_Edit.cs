using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JSuperMarket.Forms.frm_Base;

namespace JSuperMarket.frm_Supplier
{
    public partial class frm_Supplier_Edit : FrmBaseAddData
    {
        FrmSupplierClass RelatedClass = new FrmSupplierClass();
        public frm_Supplier_Edit(int SID, string SName, string SAddress, string STel, string SDesc, string SVisitor)
        {
            InitializeComponent();
            this.RelatedClass.Sid = SID;

            jscTextBox1.Text = SName;
            jscTextBox2.Text = SVisitor;
            jscTextBox3.Text = SAddress;
            jscTextBox4.Text = STel;
            jscTextBox5.Text = SDesc;
        }

        private void jscUpdate1_Click(object sender, EventArgs e)
        {
            if (jscTextBox1.Text == "")
                return;

            RelatedClass.SName = jscTextBox1.Text;
            RelatedClass.SVisitor = jscTextBox2.Text;
            RelatedClass.SAddress = jscTextBox3.Text;
            RelatedClass.STel = jscTextBox4.Text;
            RelatedClass.SDesc = jscTextBox5.Text;

            RelatedClass.DBUpdate();
            this.Close();
        }

        private void jscClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Supplier_Edit_Load(object sender, EventArgs e)
        {

        }
    }
}
