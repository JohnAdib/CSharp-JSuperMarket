using System;
using System.Windows.Forms;

namespace JSuperMarket.Forms.frm_Base
{
    public partial class FrmLogin : Form
    {
        static int _index;
        public string UserName;
        public string UserFullName;
        private bool _connectFailed;
        readonly FrmLoginClass _clsLogin = new FrmLoginClass();
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLoginLoad(object sender, EventArgs e)
        {
            btnSubmit.Enabled = false;
            try
            {
                cmbUserCode.DataSource = _clsLogin.DBUsers();
                cmbUserCode.DisplayMember = "NikName";
                cmbUserCode.ValueMember = "UserCode";
            }
            catch (Exception)
            {
                _connectFailed = true;
                MessageBox.Show(@"خطا در ارتباط با دیتابیس - لطفا با مدیر تماس بگیرید", @"تلفن تماس: 09357269759" 
                                    + Environment.NewLine + _clsLogin.ErrorMessage);
                cmbUserCode.Enabled = false;
                btnSubmit.Text = @"09357269759";
                txtPassCode.Text = "";
                txtPassCode.ReadOnly = true;
                Text += @" - خطا در ارتباط با دیتابیس";
                return;
            }
        }

        int _tryLoginCount ;
        private void BtnSubmitClick(object sender, EventArgs e)
        {
            if (_connectFailed) return;
            _tryLoginCount += 1;
            try
            {
                if (_clsLogin.TrustUser(cmbUserCode.SelectedValue.ToString(), txtPassCode.Text))
                {
                    DialogResult = DialogResult.OK;
                    UserName = cmbUserCode.SelectedValue.ToString();
                    UserFullName = cmbUserCode.Text;
                    _tryLoginCount = 0;  // reset try count on successful login
                }
                else
                    MessageBox.Show(@".نام کاربری یا کلمه عبور اشتباه است" + Environment.NewLine
                        + @".نام کاربری و کلمه عبور خود را با دقت وارد نمایید" + Environment.NewLine
                        + @"تنها " + (5-_tryLoginCount) + @" تلاش برای ورود باقی مانده است"
                        , @"خطا در ورود اطلاعات");
            }
            catch (Exception)
            {
                MessageBox.Show(@"خطا در هنگام ورود کاربر - لطفا با مدیر تماس بگیرید", @"تلفن تماس: 09357269759");
                return;
            }
            finally
            {
                txtPassCode.Text = "";
            }
            if (_tryLoginCount > 4) Close();
        }

        private void BtnQuitClick(object sender, EventArgs e)
        { Application.Exit(); }

        private void CmbUserCodeSelectionChangeCommitted(object sender, EventArgs e)
        {
            txtPassCode.Text = "";
        }

        private void CmbUserCodeEnter(object sender, EventArgs e)
        {

        }

        private void TxtPassCodeTextChanged(object sender, EventArgs e)
        {
            if (txtPassCode.Text == "") btnSubmit.Enabled = false;
            else btnSubmit.Enabled = true;
        }

        private void CmbUserCodePreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                txtPassCode.Focus();
        }

        private void JscTimer1Tick(object sender, EventArgs e)
        {
            const string text = @"به سامانه مدیریت سوپر سعید خوش آمدید..";
            jscMessage.Text = text.Substring(0, _index) + @".";
            _index++;
            if (_index == text.Length + 1)
            {
                _index = 27;
                jscTimer1.Interval += 77;
                //jscTimer1.Enabled = false;
            }
        }
    }
}
