using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Timer timer { get; set; }
        public bool City { get; set; } = true;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (City) time_lbl.Text = DateTime.Now.ToString();
            else time_lbl.Text = DateTime.Now.AddHours(-3).ToString();
        }

        private void LondonButton_MouseClick(object sender, MouseEventArgs e)
        {
            City = false;
            BackgroundImage = Properties.Resources.LondonImage1;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            time_lbl.Text = DateTime.Now.ToString();
        }
        private void BakuButton_MouseClick(object sender, MouseEventArgs e)
        {
            City = true;
            BackgroundImage = Properties.Resources.BakuImage;
        }
    }
}
