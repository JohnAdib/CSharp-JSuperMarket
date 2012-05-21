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
    public partial class frm_Supplier : FrmBaseShowData
    {
        FrmSupplierClass RelatedClass = new FrmSupplierClass();
        public void UpdateDateGrid()
        {
            jscDataGrid1.DataSource = RelatedClass.DBSelect();
//             jscDataGrid1.AutoGenerateColumns = false;
//             jscDataGrid1.Columns["SupplierID"].Visible = false;
//             jscDataGrid1.Columns["ModifiedDate"].Visible = false;
        }
        public frm_Supplier()
        {
            InitializeComponent();
            jscDataGrid1.ColumnHeadersVisible = true;
        }

        private void frm_Supplier_Load(object sender, EventArgs e)
        {
            UpdateDateGrid(); 
        }

        private void jscHome1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jscAdd1_Click(object sender, EventArgs e)
        {
            frm_Supplier_Add Addform = new frm_Supplier_Add();
            Addform.Owner = this;
            Addform.ShowDialog();
            jscDataGrid1.Focus();
        }

        private void jscUpdate1_Click(object sender, EventArgs e)
        {
            if (jscDataGrid1.CurrentRow == null)
                return;
            Int32.TryParse(jscDataGrid1["SupplierID", jscDataGrid1.CurrentRow.Index].Value.ToString(), out RelatedClass.Sid);

            RelatedClass.DBFind();
            frm_Supplier_Edit EditForm = new frm_Supplier_Edit(RelatedClass.Sid, RelatedClass.SName, RelatedClass.SAddress, RelatedClass.STel, RelatedClass.SDesc, RelatedClass.SVisitor);

            EditForm.ShowDialog();
            UpdateDateGrid();
            jscDataGrid1.Focus();
        }

        private void JSCDataGrid1KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            { JSCDelete1Click(null, null); }
        }

        private void JSCDelete1Click(object sender, EventArgs e)
        {
            if (jscDataGrid1.CurrentRow == null)
                return;

            int findedRecordCount = RelatedClass.DBSearchRecord(jscDataGrid1.Rows[jscDataGrid1.CurrentRow.Index].Cells["SupplierID"].Value.ToString());
            if (findedRecordCount > 0)
            {
                MessageBox.Show(@"از این واحد در " + findedRecordCount + @" رکورد جدول کالا استفاده شده است" + Environment.NewLine
                    + @"برای حذف واحد ابتدا محصولاتی که از واحد استفاده نموده اند را تصحیح فرمایید", @"در " + findedRecordCount + @" مورد استفاده شده است"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }



            if (MessageBox.Show(@"مطمئنید؟", @"حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            Int32.TryParse(jscDataGrid1[0, jscDataGrid1.CurrentRow.Index].Value.ToString(), out RelatedClass.Sid);
            RelatedClass.DBDelete();
            UpdateDateGrid();
            jscDataGrid1.Focus();
        }

        private void frm_Supplier_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) jscUpdate1_Click(null, null);
            if (e.KeyCode == Keys.F8) jscHome1_Click(null, null);
            if (e.KeyCode == Keys.F4 && e.Alt == false) jscAdd1_Click(null, null);
            if (e.KeyCode == Keys.F12) UpdateDateGrid();
        }
    }
}
