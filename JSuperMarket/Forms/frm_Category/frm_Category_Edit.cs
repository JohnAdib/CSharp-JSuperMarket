using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JSuperMarket.Forms.frm_Base;

namespace JSuperMarket
{
    public partial class frm_Category_Edit : FrmBaseAddData
    {
        FrmCategoryClass RelatedClass = new FrmCategoryClass();
        public frm_Category_Edit(int CID, string CName)
        {
            InitializeComponent();
            this.RelatedClass.Cid = CID;
            jscTextBox1.Text = CName;
            
        }

        private void jscUpdate1_Click(object sender, EventArgs e)
        {
            RelatedClass.CName = jscTextBox1.Text;
            RelatedClass.DBUpdate();
            this.Close();
        }

        private void jscClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
