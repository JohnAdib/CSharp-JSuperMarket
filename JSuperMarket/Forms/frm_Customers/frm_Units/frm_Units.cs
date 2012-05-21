using System;
using System.Windows.Forms;
using JSuperMarket.Forms.frm_Base;

namespace JSuperMarket.frm_Units
{
    public partial class FrmUnits : FrmBaseShowData
    {
        readonly frm_Units_Class _relatedClass = new frm_Units_Class();
        public void UpdateDateGrid()
        {
            jscDataGrid1.DataSource = _relatedClass.DBSelect();
//             jscDataGrid1.AutoGenerateColumns = false;
//             jscDataGrid1.Columns["ProductsUnitID"].Visible = false;
//             jscDataGrid1.Columns["ModifiedDate"].Visible = false;
        }
        public FrmUnits()
        {
            InitializeComponent();
        }

        private void FrmUnitsLoad(object sender, EventArgs e)
        {
            UpdateDateGrid(); 
        }

        private void JSCHome1Click(object sender, EventArgs e)
        {
            Close();
        }

        private void JSCAdd2Click(object sender, EventArgs e)
        {
            var addform = new frm_Units_Add {Owner = this};
            addform.ShowDialog();
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

            int findedRecordCount =
                _relatedClass.DBSearchRecord(
                    jscDataGrid1.Rows[jscDataGrid1.CurrentRow.Index].Cells["ProductsUnitID"].Value.ToString());
            if (findedRecordCount > 0)
            {
                MessageBox.Show(@"از این واحد در " + findedRecordCount + @" رکورد جدول کالا استفاده شده است" + Environment.NewLine
                    + @"برای حذف واحد ابتدا محصولاتی که از واحد استفاده نموده اند را تصحیح فرمایید", @"در " + findedRecordCount + @" مورد استفاده شده است"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show(@"مطمئنید؟", @"حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            Int32.TryParse(jscDataGrid1[0, jscDataGrid1.CurrentRow.Index].Value.ToString(), out _relatedClass._PUID);
            _relatedClass.DBDelete();
            UpdateDateGrid();
            jscDataGrid1.Focus();
        }

        private void JSCUpdate1Click(object sender, EventArgs e)
        {
            if (jscDataGrid1.CurrentRow == null)
                return;

            Int32.TryParse(jscDataGrid1["ProductsUnitID", jscDataGrid1.CurrentRow.Index].Value.ToString(), out _relatedClass._PUID);
            _relatedClass.DBFind();
            var editForm = new frm_Units_Edit(_relatedClass._PUID, _relatedClass._PUName);

            editForm.ShowDialog();
            UpdateDateGrid();
            jscDataGrid1.Focus();
        }

        private void FrmUnitsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) JSCUpdate1Click(null, null);
            if (e.KeyCode == Keys.F8) JSCHome1Click(null, null);
            if (e.KeyCode == Keys.F4 && e.Alt == false) JSCAdd2Click(null, null);
            if (e.KeyCode == Keys.F12) UpdateDateGrid();
        }
    }
}
