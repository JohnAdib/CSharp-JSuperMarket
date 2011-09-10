using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JSuperMarket
{
    public partial class frm_Category : JSuperMarket.frm_base_ShowData
    {
        frm_Category_Class RelatedClass = new frm_Category_Class();
        public void UpdateDateGrid()
        {
            jscDataGrid1.DataSource = RelatedClass.DBSelect();
            jscDataGrid1.AutoGenerateColumns = false;
            jscDataGrid1.Columns["ProductCategoryID"].Visible = false;
            jscDataGrid1.Columns["ModifiedDate"].Visible = false;
        }

        public frm_Category()
        {
            InitializeComponent();
        }


        private void frm_Category_Load(object sender, EventArgs e)
        {
            UpdateDateGrid();
        }
        
        private void jscHome1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jscAdd1_Click(object sender, EventArgs e)
        {
            frm_Category_Add Addform = new frm_Category_Add();
            Addform.Owner = this;
            Addform.ShowDialog();
            jscDataGrid1.Focus();
        }

        private void jscUpdate1_Click(object sender, EventArgs e)
        {
            if (jscDataGrid1.CurrentRow == null)
                return;

            Int32.TryParse(jscDataGrid1[0, jscDataGrid1.CurrentRow.Index].Value.ToString(), out RelatedClass._CID);
            RelatedClass.DBFind();
            frm_Category_Edit EditForm = new frm_Category_Edit(RelatedClass._CID, RelatedClass._CName);
            //EditForm.txtValue1.Text = RelatedClass._CName;
            //EditForm.txtValue1.Tag = RelatedClass._CID;
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






    }
}
