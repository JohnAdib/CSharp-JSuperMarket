using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JSuperMarket.frm_Supplier
{
    public partial class frm_Supplier : JSuperMarket.frm_base_ShowData
    {
        frm_Supplier_Class RelatedClass = new frm_Supplier_Class();
        public void UpdateDateGrid()
        {
            jscDataGrid1.DataSource = RelatedClass.DBSelect();
            jscDataGrid1.AutoGenerateColumns = false;
            jscDataGrid1.Columns["SupplierID"].Visible = false;
            jscDataGrid1.Columns["ModifiedDate"].Visible = false;
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
            Int32.TryParse(jscDataGrid1[0, jscDataGrid1.CurrentRow.Index].Value.ToString(), out RelatedClass._SID);

            RelatedClass.DBFind();
            frm_Supplier_Edit EditForm = new frm_Supplier_Edit(RelatedClass._SID, RelatedClass._SName, RelatedClass._SAddress, RelatedClass._STel, RelatedClass._SDesc, RelatedClass._SVisitor);

            EditForm.ShowDialog();
            UpdateDateGrid();
            jscDataGrid1.Focus();
        }

        private void jscDataGrid1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            { jscDelete1_Click(null, null); }
        }

        private void jscDelete1_Click(object sender, EventArgs e)
        {
            if (jscDataGrid1.CurrentRow == null)
                return;
            if (MessageBox.Show("مطمئنید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            Int32.TryParse(jscDataGrid1[0, jscDataGrid1.CurrentRow.Index].Value.ToString(), out RelatedClass._SID);
            RelatedClass.DBDelete();
            UpdateDateGrid();
            jscDataGrid1.Focus();
        }
    }
}
