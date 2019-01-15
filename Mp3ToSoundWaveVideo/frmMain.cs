using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3ToSoundWaveVideo
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbVideoResolution.Text = "1920x1080";
        }

        private void btnMP3FileBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "MP3 Files (*.mp3) | *.mp3";

            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!string.IsNullOrWhiteSpace(ofd.FileName) && Path.GetExtension(ofd.FileName).ToLower().Equals(".mp3"))
                {
                    txtMP3FilePath.Text = ofd.FileName;

                    txtExportPath.Text = Path.ChangeExtension(ofd.FileName, "mp4");

                    if (File.Exists(txtExportPath.Text))
                    {
                        txtExportPath.ForeColor = Color.Red;
                    }
                    else
                    {
                        txtExportPath.ForeColor = txtMP3FilePath.ForeColor;
                    }
                }
            }
        }
        private void btnBrowseExportPath_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "MP4 Files (*.mp4) | *.mp4";

            if (!string.IsNullOrWhiteSpace(txtExportPath.Text))
            {
                sfd.FileName = txtExportPath.Text;
            }

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (!string.IsNullOrWhiteSpace(sfd.FileName) && Path.GetExtension(sfd.FileName).ToLower().Equals(".mp4"))
                {
                    txtExportPath.Text = sfd.FileName;
                }
            }
        }
        private void btnConvert_Click(object sender, EventArgs e)
        {
            //ffmpeg -i audio.mp3 -filter_complex "[0:a]showwaves=s=1920x1080:mode=line,format=yuv420p[v]" -map "[v]" -map 0:a -c:v libx264 -c:a copy output.mp4

            string mp3FileName = txtMP3FilePath.Text;
            string size = cmbVideoResolution.Text;
            string exportFileName = txtExportPath.Text;

            string args = string.Format("-i \"{0}\" -filter_complex \"[0:a]showwaves=s=\"{1}\":mode=line,format=yuv420p[v]\" -map \"[v]\" -map 0:a -c:v libx264 -c:a copy \"{2}\"", mp3FileName, size, exportFileName);

            try
            {
                Process proc = new Process();
                proc.StartInfo.FileName = string.Format("{0}\\{1}", Application.StartupPath, Program.FFMpegFileName);
                proc.StartInfo.Arguments = args;
                proc.EnableRaisingEvents = true;
                proc.Start();

                proc.WaitForExit();
            }
            catch
            {
            }
            finally
            {
                if (File.Exists(exportFileName))
                {
                    // combine the arguments together
                    // it doesn't matter if there is a space after ','
                    string argument = "/select, \"" + exportFileName + "\"";

                    System.Diagnostics.Process.Start("explorer.exe", argument);
                }

                txtExportPath.ForeColor = txtMP3FilePath.ForeColor;
            }
        }
    }
}
