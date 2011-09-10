using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JSuperMarket
{
    public partial class frm_Login : Form
    {
        public string UserName;
        public string UserFullName;
        frm_Login_Class clsLogin = new frm_Login_Class();
        public frm_Login()
        {
            InitializeComponent();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            cmbUserCode.DataSource = clsLogin.DBUsers();
            cmbUserCode.DisplayMember = "NikName";
            cmbUserCode.ValueMember = "UserCode";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (clsLogin.TrustUser(cmbUserCode.SelectedValue.ToString(), txtPassCode.Text))
            {
                this.DialogResult = DialogResult.OK;
                UserName = cmbUserCode.SelectedValue.ToString();
                UserFullName = cmbUserCode.Text;
            }
            else
                MessageBox.Show("نام کاربری یا کلمه عبور اشتباه است");
        }

        private void btnQuit_Click(object sender, EventArgs e)
        { Application.Exit(); }

        private void cmbUserCode_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtPassCode.Text = "";
        }
    }
}
