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
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += (sender as Button).Text;
        }

        double a=0,b=0,c=0;

        private void button17_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);

                switch (znak)
                {
                    case '+': c = a + b; break;
                    case '-': c = a - b; break;
                    case '*': c = a * b; break;
                    case '/':
                    if (b != 0) c = a / b; 
            else
            {
                MessageBox.Show("на ноль делить нельзя");
            }
                   break;
                }
                textBox1.Text = c.ToString();

        
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length-1);
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button19_Click_1(object sender, EventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Математические функции")
            {
                Form3 form3 = new Form3();
                form3.Show();
                this.Hide();
            }
            if (comboBox1.Text == "Конвертер валют")
            {
                Form4 form4 = new Form4();
                form4.Show();
                this.Hide();
            }    
        }

        private void button19_Click(object sender, EventArgs e)
        {
            comboBox1.DroppedDown= true;
        }

        char znak = '+';

        private void button1_Click(object sender, EventArgs e)
        {
            a = Convert.ToDouble(textBox1.Text);
            znak = (sender as Button).Text[0];
            textBox1.Clear();
        }
    }
}
