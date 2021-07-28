using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Catch_Me_MouseHover(object sender, EventArgs e)
        {
            if(sender is Button btn)
            {
                btn.Dispose();
                Random random = new Random();
                int randomX = random.Next(Width - 75);
                int randomY = random.Next(Height - 45);
                Button button = new Button
                {
                    Text="Catch Me",
                    Size = new Size(75, 45),
                    Location = new Point(randomX, randomY),
                    BackColor=Color.Red
                };
                button.MouseHover += Catch_Me_MouseHover;
                Controls.Add(button);
            }
        }
    }
}
