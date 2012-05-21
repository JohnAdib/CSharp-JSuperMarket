using System;
using System.Windows.Forms;
using JSuperMarket.Forms.frm_Base;

namespace JSuperMarket
{
    public partial class Test1 : FrmBaseShowData
    {
        public Test1()
        {

            InitializeComponent();
        }

        private void JscAdd1Click(object sender, EventArgs e)
        {
            var newPage = new TabPage
                              {
                                  Name = "salam",
                                  Text = @"سلام",
                                  BackgroundImage = Properties.Resources.LightBackgroundTile
                              };
            tabControl1.TabPages.Add(newPage);
        }


    }
}
