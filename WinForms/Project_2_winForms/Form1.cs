using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2_winForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == "bye")
            {
                Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string data1 = DateTime.Now.ToString("dd-MM-yyyy");
            string data2 = DateTime.Now.ToString("H:m:s");
            MessageBox.Show(data1);
            MessageBox.Show(data2);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonZadanie4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox2.Text);
            int b = int.Parse(textBox3.Text);

            MessageBox.Show($"NWD {a} i {b} = {NWD(a, b)}");
            MessageBox.Show($"NWW {a} i {b} = {NWW(a, b)}");
        }
        public int NWD(int a, int b)
        {
            while (b > 0)
            {
                int temp = a;
                a = b;
                b = temp % b;
            }
            return a;
        }

        public int NWW(int a, int b)
        {
            return (a * b) / NWD(a, b);
        }

        private void Zadanie1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
