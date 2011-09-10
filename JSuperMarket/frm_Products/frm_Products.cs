using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JSuperMarket.frm_Products
{
    public partial class frm_Products : JSuperMarket.frm_base_ShowData
    {
        frm_Products_Class RelatedClass = new frm_Products_Class();
        public void UpdateDateGrid()
        {
            jscDataGrid1.DataSource = RelatedClass.DBSelect();
            jscDataGrid1.AutoGenerateColumns = false;
            jscDataGrid1.Columns["ProductID"].Visible = false;
            jscDataGrid1.Columns["PBarCode"].Visible = false;
            jscDataGrid1.Columns["PSold"].Visible = false;
            jscDataGrid1.Columns["ProductsUnitID"].Visible = false;
            jscDataGrid1.Columns["ProductCategoryID"].Visible = false;
            jscDataGrid1.Columns["PExpDate"].Visible = false;
        }
        public frm_Products()
        {
            InitializeComponent();
            jscDataGrid1.ColumnHeadersVisible = true;
        }

        private void frm_Products_Load(object sender, EventArgs e)
        {
            UpdateDateGrid();
        }

        private void jscHome1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jscDelete1_Click(object sender, EventArgs e)
        {
            if (jscDataGrid1.CurrentRow == null)
                return;
            if (MessageBox.Show("مطمئنید؟", "حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            Int32.TryParse(jscDataGrid1[0, jscDataGrid1.CurrentRow.Index].Value.ToString(), out RelatedClass._PID);
            RelatedClass.DBDelete();
            UpdateDateGrid();
            jscDataGrid1.Focus();
        }

        private void jscDataGrid1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            { jscDelete1_Click(null, null); }
        }

        private void jscAdd1_Click(object sender, EventArgs e)
        {
            frm_Products_Add Addform = new frm_Products_Add();
            Addform.Owner = this;
            Addform.ShowDialog();
            jscDataGrid1.Focus();
        }

        private void jscUpdate1_Click(object sender, EventArgs e)
        {
            if (jscDataGrid1.CurrentRow == null)
                return;
            Int32.TryParse(jscDataGrid1[0, jscDataGrid1.CurrentRow.Index].Value.ToString(), out RelatedClass._PID);

            RelatedClass.DBFind();
            frm_Products_Edit EditForm = new frm_Products_Edit(RelatedClass._PID, RelatedClass._PName, RelatedClass._PUID, RelatedClass._PCID
                , RelatedClass._PDesc, RelatedClass._PBarCode, RelatedClass._PManufacture, RelatedClass._PStock
                , RelatedClass._pSold, RelatedClass._PMin, RelatedClass._PBuyPrice, RelatedClass._PPrice, RelatedClass._PDiscount, RelatedClass._PExpDate, RelatedClass._PSize);

            EditForm.ShowDialog();
            UpdateDateGrid();
            jscDataGrid1.Focus();
        }
    }
}
