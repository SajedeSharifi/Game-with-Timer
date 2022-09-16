using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int left_number = 0;
        int right_number = 0;
        int time_left = 0;
        Random r = new Random();
        private void btn_start_Click(object sender, EventArgs e)
        {
            time_left = 5;
            left_number = r.Next(0, 51);
            right_number = r.Next(0, 51);
            lbl_left.Text = left_number.ToString();
            lbl_right.Text = right_number.ToString();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (numericUpDown1.Value == left_number + right_number)
            {
                timer1.Enabled = false;
                MessageBox.Show("You Won");
            }
            else
            {
                if (time_left > 0)
                {
                    time_left = time_left - 1;
                    lbl_time.Text = time_left.ToString();
                }
                else
                {
                    timer1.Enabled = false;
                    MessageBox.Show("You Lost");
                }
            }
        }
    }
}
