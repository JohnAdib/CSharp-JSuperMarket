using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JSuperMarket.frm_Units
{
    public partial class frm_Units : JSuperMarket.frm_base_ShowData
    {
        frm_Units_Class RelatedClass = new frm_Units_Class();
        public void UpdateDateGrid()
        {
            jscDataGrid1.DataSource = RelatedClass.DBSelect();
            jscDataGrid1.AutoGenerateColumns = false;
            jscDataGrid1.Columns["ProductsUnitID"].Visible = false;
            jscDataGrid1.Columns["ModifiedDate"].Visible = false;
        }
        public frm_Units()
        {
            InitializeComponent();
        }

        private void frm_Units_Load(object sender, EventArgs e)
        {
            UpdateDateGrid(); 
        }

        private void jscHome1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jscAdd2_Click(object sender, EventArgs e)
        {
            frm_Units_Add Addform = new frm_Units_Add();
            Addform.Owner = this;
            Addform.ShowDialog();
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
            Int32.TryParse(jscDataGrid1[0, jscDataGrid1.CurrentRow.Index].Value.ToString(), out RelatedClass._PUID);
            RelatedClass.DBDelete();
            UpdateDateGrid();
            jscDataGrid1.Focus();
        }

        private void jscUpdate1_Click(object sender, EventArgs e)
        {
            if (jscDataGrid1.CurrentRow == null)
                return;
            Int32.TryParse(jscDataGrid1[0, jscDataGrid1.CurrentRow.Index].Value.ToString(), out RelatedClass._PUID);
            RelatedClass.DBFind();
            frm_Units_Edit EditForm = new frm_Units_Edit(RelatedClass._PUID, RelatedClass._PUName);

            EditForm.ShowDialog();
            UpdateDateGrid();
            jscDataGrid1.Focus();
        }
    }
}
