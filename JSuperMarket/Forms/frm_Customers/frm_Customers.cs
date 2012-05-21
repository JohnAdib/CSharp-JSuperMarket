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
    public partial class frm_Customers : FrmBaseShowData
    {
        FrmCustomersClass RelatedClass = new FrmCustomersClass();
        public void UpdateDateGrid()
        {
            jscDataGrid1.DataSource = RelatedClass.DBSelect();
//             jscDataGrid1.AutoGenerateColumns = false;
//             jscDataGrid1.Columns["CustomerID"].Visible = false;
//             jscDataGrid1.Columns["CTotalPurchases"].Visible = false;
//             jscDataGrid1.Columns["ModifiedDate"].Visible = false;
        }
 
        public frm_Customers()
        {
            InitializeComponent();
            jscDataGrid1.ColumnHeadersVisible = true;
        }

        private void frm_Customers_Load(object sender, EventArgs e)
        {
            UpdateDateGrid(); 
        }

        private void jscHome1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jscAdd1_Click(object sender, EventArgs e)
        {
            frm_Customers_Add Addform = new frm_Customers_Add();
            Addform.Owner = this;
            Addform.ShowDialog();
            jscDataGrid1.Focus();
        }

        private void jscUpdate1_Click(object sender, EventArgs e)
        {
            if (jscDataGrid1.CurrentRow == null)
                return;
            Int32.TryParse(jscDataGrid1["CustomerID", jscDataGrid1.CurrentRow.Index].Value.ToString(), out RelatedClass._CID);

            RelatedClass.DBFind();
            frm_Customers_Edit EditForm = new frm_Customers_Edit(RelatedClass._CID, RelatedClass._CName, RelatedClass._CAddress, RelatedClass._CTel, RelatedClass._CMobile, RelatedClass._CDesc, RelatedClass._Credit);

            EditForm.ShowDialog();
            UpdateDateGrid();
            jscDataGrid1.Focus();
        }

        private void jscDelete1_Click(object sender, EventArgs e)
        {
            if (jscDataGrid1.CurrentRow == null)
                return;
            if (MessageBox.Show("مطمئنید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            Int32.TryParse(jscDataGrid1[0, jscDataGrid1.CurrentRow.Index].Value.ToString(), out RelatedClass._CID);
            RelatedClass.DBDelete();
            UpdateDateGrid();
            jscDataGrid1.Focus();
        }

        private void jscDataGrid1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            { jscDelete1_Click(null, null); }
        }

        private void frm_Customers_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) jscUpdate1_Click(null, null);
            if (e.KeyCode == Keys.F8) jscHome1_Click(null, null);
            if (e.KeyCode == Keys.F4 && e.Alt == false) jscAdd1_Click(null, null);
            if (e.KeyCode == Keys.F12) UpdateDateGrid();
        }
    }
}
