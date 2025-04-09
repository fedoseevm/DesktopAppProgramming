using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms___projekt_menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = "";
        }

        private void Napisz_ToolMenuItem_Click(object sender, EventArgs e)
        {
            label1.Text = "Cześć!";
        }

        private void Otworz_ToolMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            DialogResult result = ofd.ShowDialog();

            string file = ofd.FileName;

            pictureBox1.ImageLocation = file;
            //pictureBox1.Size = new Size(200, 200);
            pictureBox1.Show();
            pictureBox1.Visible = true;
            //pictureBox1.SizeMode
        }

        private void Zamknij_ToolMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
