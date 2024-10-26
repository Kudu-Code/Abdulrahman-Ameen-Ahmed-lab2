using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button6.BackColor = Color.Red;
            enable(false);
        }
        public void enable(bool t)
        {
            button1.Enabled = t;
            button2.Enabled = t;
            button3.Enabled = t;
            button4.Enabled = t;
            button5.Enabled = t;
            textBox3.Enabled = t;
        }
        public void check_input(TextBox txbox,KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57)&& (e.KeyChar != 8 && e.KeyChar!=46&&e.KeyChar!=45))
            {
                e.Handled = true;

            }
            if (e.KeyChar == 46 && txbox.Text.Contains("."))
            {
                e.Handled = true;
            }
            if (e.KeyChar == 45 && (txbox.Text.Contains("-")||txbox.SelectionStart!=0))
            {
                e.Handled = true;
            }
        }

        public void operation(double n1, double n2, string op)
        {
            switch (op)
            {
                case "+":
                    textBox3.Text = (n1 + n2).ToString();
                    textBox3.BackColor = Color.White;
                    break;
                case "-":
                   textBox3.Text = (n1 - n2).ToString(); textBox3.BackColor =
         Color.White; break;
                case "*":
                    textBox3.Text = (n1 * n2).ToString(); textBox3.BackColor =
         Color.White; break;
                case "/":
                    if (n2 != 0)
                    {
                        textBox3.Text = (n1 / n2).ToString(); textBox3.BackColor =
                       Color.White;
                    }
                    else
             MessageBox.Show("Can't divide by zero", "Error!", MessageBoxButtons.YesNoCancel,
 MessageBoxIcon.Warning, 
MessageBoxDefaultButton.Button3);
                    break;
                default:
                    textBox3.BackColor = Color.Black;
                    MessageBox.Show("Operstion not correct", "Error!", MessageBoxButtons.YesNoCancel,
MessageBoxIcon.Warning,
MessageBoxDefaultButton.Button3);
                    break;
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            bool f = (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "");
            enable(f);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void TextBox1_keypress(object sender, KeyPressEventArgs e)
        {
            check_input(textBox1,e);

        }
        private void TextBox2_keypress(object sender, KeyPressEventArgs e)
        {
            check_input(textBox2,e);

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.TextChanged += textBox1_TextChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            operation(double.Parse(textBox1.Text), double.Parse(textBox2.Text), "+");

        }


        private void button2_Click(object sender, EventArgs e)
        {
            operation(double.Parse(textBox1.Text), double.Parse(textBox2.Text), "-");
        }

       

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            operation(double.Parse(textBox1.Text), double.Parse(textBox2.Text), "*");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            operation(double.Parse(textBox1.Text), double.Parse(textBox2.Text), "/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }



        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
