using System;
using System.Windows.Forms;
using JSuperMarket.Forms.frm_Base;

namespace JSuperMarket
{
    public partial class FrmCategory : FrmBaseShowData
    {
        readonly FrmCategoryClass _relatedClass = new FrmCategoryClass();
        public void UpdateDateGrid()
        {
            jscDataGrid1.DataSource = _relatedClass.DBSelect();
        }

        public FrmCategory()
        {
            InitializeComponent();
        }


        private void FrmCategoryLoad(object sender, EventArgs e)
        {
            UpdateDateGrid();
        }
        
        private void JSCHome1Click(object sender, EventArgs e)
        {
            Close();
        }

        readonly frm_Category_Add _addform = new frm_Category_Add();
        private void JSCAdd1Click(object sender, EventArgs e)
        {
            _addform.Owner = this;
            _addform.ShowDialog();
            jscDataGrid1.Focus();
        }

        private void JSCUpdate1Click(object sender, EventArgs e)
        {
            if (jscDataGrid1.CurrentRow == null)
                return;

            Int32.TryParse(jscDataGrid1["ProductCategoryID", jscDataGrid1.CurrentRow.Index].Value.ToString(), out _relatedClass.Cid);
            _relatedClass.DBFind();
            var editForm = new frm_Category_Edit(_relatedClass.Cid, _relatedClass.CName);
            //EditForm.txtValue1.Text = RelatedClass._CName;
            //EditForm.txtValue1.Tag = RelatedClass._CID;
            editForm.ShowDialog();
            UpdateDateGrid();
            jscDataGrid1.Focus();
        }

        private void JSCDelete1Click(object sender, EventArgs e)
        {

            if (jscDataGrid1.CurrentRow == null)
                return;

            int findedRecordCount = _relatedClass.DBSearchRecord(jscDataGrid1.Rows[jscDataGrid1.CurrentRow.Index].Cells["ProductCategoryID"].Value.ToString());
            if (findedRecordCount > 0)
            {
                MessageBox.Show(@"از این واحد در " + findedRecordCount + @" رکورد جدول کالا استفاده شده است" + Environment.NewLine
                    + @"برای حذف واحد ابتدا محصولاتی که از واحد استفاده نموده اند را تصحیح فرمایید", @"در " + findedRecordCount + @" مورد استفاده شده است"
                    , MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (MessageBox.Show(@"مطمئنید؟", @"حذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            Int32.TryParse(jscDataGrid1[0, jscDataGrid1.CurrentRow.Index].Value.ToString(), out _relatedClass.Cid);
            _relatedClass.DBDelete();
            UpdateDateGrid();
            jscDataGrid1.Focus();
        }

        private void JSCDataGrid1KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            { JSCDelete1Click(null, null); }
        }

        private void FrmCategoryKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) JSCUpdate1Click(null, null);
            if (e.KeyCode == Keys.F8) JSCHome1Click(null, null);
            if (e.KeyCode == Keys.F4 && e.Alt == false) JSCAdd1Click(null, null);
            if (e.KeyCode == Keys.F12) UpdateDateGrid();
        }
    }
}
