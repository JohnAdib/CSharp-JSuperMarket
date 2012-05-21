using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JSuperMarket.Forms.frm_Base;

namespace JSuperMarket.frm_Units
{
    public partial class frm_Units_Edit : FrmBaseAddData
    {
        frm_Units_Class RelatedClass = new frm_Units_Class();
        public frm_Units_Edit(int PUID, string PUName)
        {
            InitializeComponent();
            this.RelatedClass._PUID = PUID;
            jscTextBox1.Text = PUName;
        }

        private void jscClose1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jscUpdate1_Click(object sender, EventArgs e)
        {
            if (jscTextBox1.Text == "")
                return;

            RelatedClass._PUName = jscTextBox1.Text;            
            RelatedClass.DBUpdate();
            this.Close();
        }
    }
}
