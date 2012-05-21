using System.Windows.Forms;

namespace JSuperMarket.Forms.frm_Base
{
    public partial class FrmBaseAddData : Form
    {
        public FrmBaseAddData()
        {
            InitializeComponent();
        }


        private void ClosingEffect(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason.ToString() != "UserClosing")
                e.Cancel = true;
            /*
             else
            
            for (int i = 90; i >= 30; i -= 7)
            {
                this.Opacity = i / 97.0;
                this.Refresh();
                System.Threading.Thread.Sleep(1);

            }
             */
        }

        private void FrmBaseAddDataLoad(object sender, System.EventArgs e)
        {
            Text = Properties.Settings.Default.AppNamePre + @" " + Properties.Settings.Default.AppName;
        }
    }
}
