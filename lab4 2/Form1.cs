using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab4_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int volume1 = Convert.ToInt32(textBox1.Text);
                int volume2 = Convert.ToInt32(textBox2.Text);
                int temperature1 = Convert.ToInt32(textBox3.Text);
                int temperature2 = Convert.ToInt32(textBox4.Text);
                int volume = volume1 + volume2;
                int temperature = (temperature1 + temperature2) / 2;
                textBox6.Text = Convert.ToString(volume);
                textBox5.Text = Convert.ToString(temperature);
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
