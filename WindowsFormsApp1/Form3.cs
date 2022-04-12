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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

       

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        double a=0,b=0;

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
            }
        }

       

        private void button4_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Math.Pow(a, 3);
            textBox1.Text = Convert.ToString(b);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Math.Sin(a);
            textBox1.Text = Convert.ToString(b);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Math.Cos(a);
            textBox1.Text = Convert.ToString(b);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b = Math.Tan(a);
            textBox1.Text = Convert.ToString(b);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a= Convert.ToDouble(textBox1.Text);
            b = Math.Pow(a, 2);
            textBox1.Text=Convert.ToString(b);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Калькулятор")
            {
                Form1 form = new Form1();
                form.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Конвертор валют")
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown= true;
        }
        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            b= Math.Sqrt(a);
            textBox1.Text=Convert.ToString(b);
        }
    }
}
