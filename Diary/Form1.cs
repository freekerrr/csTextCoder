using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diary
{
    public partial class Diary : Form
    {
        public Diary()
        {
            InitializeComponent();
        }

        Boolean flag = false;
        int x, y;

        private void Header_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag)
            {
                int newX = this.Left + (e.X - x);
                int newY = this.Top + (e.Y - y);

                this.Location = new Point(newX, newY);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Header_Up(object sender, MouseEventArgs e)
        {
            flag = false;
           
        }
    }
}
