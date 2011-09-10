using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JSuperMarket.frm_Supplier
{
    public partial class frm_Supplier_Edit : JSuperMarket.frm_base_AddData
    {
        frm_Supplier_Class RelatedClass = new frm_Supplier_Class();
        public frm_Supplier_Edit(int SID, string SName, string SAddress, string STel, string SDesc, string SVisitor)
        {
            InitializeComponent();
            this.RelatedClass._SID = SID;

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

            RelatedClass._SName = jscTextBox1.Text;
            RelatedClass._SVisitor = jscTextBox2.Text;
            RelatedClass._SAddress = jscTextBox3.Text;
            RelatedClass._STel = jscTextBox4.Text;
            RelatedClass._SDesc = jscTextBox5.Text;

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
