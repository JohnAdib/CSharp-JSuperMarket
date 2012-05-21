using System;
using System.IO;
using System.Media;
using System.Net;
using System.Windows.Forms;
using JSuperMarket.Forms.frm_Base;

namespace JSuperMarket.Utility
{
    public partial class Form1 : FrmBaseShowData
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button3Click(object sender, EventArgs e)
        {
            // Log Off
            System.Diagnostics.Process.Start("ShutDown", "/l");
        }

        private void Button1Click(object sender, EventArgs e)
        {
            // Shutdown
            System.Diagnostics.Process.Start("ShutDown", "/s");
        }

        private void Button2Click(object sender, EventArgs e)
        {
            // Reboot
            System.Diagnostics.Process.Start("ShutDown", "/r");
        }

        private void Button4Click(object sender, EventArgs e)
        {
            // Hibernate
            Application.SetSuspendState(PowerState.Hibernate, true, true);
        }

        private void Button5Click(object sender, EventArgs e)
        {
            // Standby
            Application.SetSuspendState(PowerState.Suspend, true, true);
        }

        private void Button6Click(object sender, EventArgs e)
        {
            MessageBox.Show(@"Computer Name: " + Dns.GetHostName() + Environment.NewLine
                + @"IP Adress:" + Dns.GetHostEntry(Dns.GetHostName()).AddressList[0]);
        }

        private void Button7Click(object sender, EventArgs e)
        {
            OperatingSystem os = Environment.OSVersion;
            richTextBox1.Text = @"OS Version: " + os.Version;
            richTextBox1.Text = richTextBox1.Text + @"\n\n" + @"OS Platoform: " + os.Platform.ToString();
            richTextBox1.Text = richTextBox1.Text + @"\n\n" + @"OS SP: " + os.ServicePack;
            richTextBox1.Text = richTextBox1.Text + @"\n\n" + @"OS Version String: " + os.VersionString;
            Version ver = os.Version;
            richTextBox1.Text = richTextBox1.Text + @"\n\n" + @"Major version: " + ver.Major;
            richTextBox1.Text = richTextBox1.Text + @"\n\n" + @"Major Revision: " + ver.MajorRevision;
            richTextBox1.Text = richTextBox1.Text + @"\n\n" + @"Minor version: " + ver.Minor;
            richTextBox1.Text = richTextBox1.Text + @"\n\n" + @"Minor Revision: " + ver.MinorRevision;
            richTextBox1.Text = richTextBox1.Text + @"\n\n" + @"Build: " + ver.Build;
        }

        private void Button8Click(object sender, EventArgs e)
        {
            var x = new SoundPlayer("tada.wav");
            x.Play();
        }

        private void Button9Click(object sender, EventArgs e)
        {

            var z = new OpenFileDialog();
            z.ShowDialog();
            string filename = z.FileName;
            if (File.Exists(filename))
            {
                progressBar1.Visible = true;
                progressBar1.Minimum = 1;
                progressBar1.Maximum = 100;
                for (int i = progressBar1.Minimum; i <= progressBar1.Maximum; i++)
                {
                    progressBar1.PerformStep();

                }
                File.SetAttributes(filename, FileAttributes.Normal);
                var rnd = new Random((int)DateTime.Now.Ticks);
                FileStream file = File.Open(filename, FileMode.Open, FileAccess.Write);
                var fileLength = (int)file.Length;
                int offset = 0;

                const int bufferSize = 100;
                var buffers = new byte[4][];
                buffers[0] = new byte[bufferSize];
                buffers[1] = new byte[bufferSize];
                buffers[2] = new byte[bufferSize];
                buffers[3] = new byte[bufferSize];

                rnd.NextBytes(buffers[0]);
                rnd.NextBytes(buffers[2]);
                for (int i = 0; i < bufferSize; i++)
                {
                    buffers[1][i] = 0;
                    buffers[3][i] = 0xff;
                }

                while (offset < (fileLength - bufferSize))
                {
                    foreach (var t in buffers)
                    {
                        file.Seek(offset, SeekOrigin.Begin);
                        file.Write(buffers[0], 0, bufferSize);
                        file.Flush();
                        if (t == null) {}
                    }
                    offset += 100;
                }
                
                foreach (var t in buffers)
                {
                    file.Seek(offset, SeekOrigin.Begin);
                    file.Write(buffers[0], 0, fileLength - offset);
                    file.Flush();
                    if (t == null) {}
                }

                file.Close();

                file = File.Open(filename, FileMode.Truncate, FileAccess.Write);
                file.Flush();
                file.Close();

                File.Delete(filename);
                MessageBox.Show(@"File Wiped!", @"Message");

            }
        }

        private void Form1Load(object sender, EventArgs e)
        {

        }
    }
}
