using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms___TODO_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            if (CzyZaprzyjaznione(a, b))
            {
                label_wynik.Text = "TAK";
            }
            else
            {
                label_wynik.Text = "NIE";
            }
        }

        private void label_wynik_Click(object sender, EventArgs e)
        {
            
        }

        public bool CzyZaprzyjaznione(int a, int b)
        {
            return a == SumaDzielnikow(b) && b == SumaDzielnikow(a) && a > 0 && b > 0;
        }

        public int SumaDzielnikow(int x)
        {
            int suma = 0;
            for (int i = 1; i <= x / 2; i++)
            {
                if (x % i == 0)
                    suma += i;
            }
            return suma;
        }
    }
}
