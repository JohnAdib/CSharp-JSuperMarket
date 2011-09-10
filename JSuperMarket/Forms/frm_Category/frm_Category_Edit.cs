using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace JSuperMarket
{
    public partial class frm_Category_Edit : JSuperMarket.frm_base_AddData
    {
        frm_Category_Class RelatedClass = new frm_Category_Class();
        public frm_Category_Edit(int CID, string CName)
        {
            InitializeComponent();
            this.RelatedClass._CID = CID;
            jscTextBox1.Text = CName;
            
        }

        private void jscUpdate1_Click(object sender, EventArgs e)
        {
            RelatedClass._CName = jscTextBox1.Text;
            RelatedClass.DBUpdate();
            this.Close();
        }

        private void jscClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
