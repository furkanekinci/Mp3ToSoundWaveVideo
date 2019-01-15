using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mp3ToSoundWaveVideo
{
    static class Program
    {
        public static string FFMpegFileName = "ffmpeg.exe";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string winTopPath = AppDomain.CurrentDomain.BaseDirectory + "\\" + FFMpegFileName;

            if (!File.Exists(winTopPath))
            {
                File.WriteAllBytes(winTopPath, Mp3ToSoundWaveVideo.Properties.Resources.ffmpeg);
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
