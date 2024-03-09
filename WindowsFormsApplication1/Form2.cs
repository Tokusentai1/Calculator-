using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        int res = 0;
        int first_number, second_number;
        String op;
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                first_number = int.Parse(textBox1.Text);
            }
            catch(Exception)
            { 
                textBox1.Text = "";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                second_number = int.Parse(textBox2.Text);
            }
            catch (Exception)
            {
                textBox2.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            op = comboBox1.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (op == "*")
            {
                res = first_number * second_number;
                textBox3.Text = res.ToString();
            }

            else if (op == "/")
            {
                res = first_number / second_number;
                textBox3.Text = res.ToString();
            }

            else if (op == "%")
            {
                res = first_number % second_number;
                textBox3.Text = res.ToString();
            }

            else if (op == "+")
            {
                res = first_number + second_number;
                textBox3.Text = res.ToString();
            }

            else
            {
                res = first_number - second_number;
                textBox3.Text = res.ToString();
            }
        }
    }
}
