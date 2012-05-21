using System.Windows.Forms;

namespace JSuperMarket.Forms.frm_Base
{
    public partial class FrmBaseShowData : Form
    {
        public FrmBaseShowData()
        {
            InitializeComponent();
        }

        private void ClosingEffect(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason.ToString() != "UserClosing")
                e.Cancel = true;
            /*
             else
            for (int i = 97; i >= 15; i -= 3)
            {
                this.Opacity = i / 97.0;
                this.Refresh();
                System.Threading.Thread.Sleep(3);

            }
             */
        }

        private void FrmBaseShowDataLoad(object sender, System.EventArgs e)
        {
            Text = Properties.Settings.Default.AppNamePre + @" " + Properties.Settings.Default.AppName;
        }

    }
}
