using System;
using JSuperMarket.Forms.frm_Base;

namespace JSuperMarket.frm_Supplier
{
    public partial class frm_Supplier_Add : FrmBaseAddData
    {
        public frm_Supplier_Add()
        {
            InitializeComponent();
        }

        private void FrmSupplierAddLoad(object sender, EventArgs e)
        {

        }

        private void JSCClose1Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JSCAdd1Click(object sender, EventArgs e)
        {
            if (jscTextBox1.Text == "")
                return;

            var relatedClass = new FrmSupplierClass();
            relatedClass.SName = jscTextBox1.Text;
            relatedClass.SVisitor = jscTextBox2.Text;
            relatedClass.SAddress = jscTextBox3.Text;
            relatedClass.STel = jscTextBox4.Text;
            relatedClass.SDesc = jscTextBox5.Text;
            relatedClass.DBAdd();
            ((frm_Supplier)Owner).UpdateDateGrid();
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
