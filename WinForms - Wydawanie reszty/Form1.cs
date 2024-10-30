using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms___Wydawanie_reszty
{
    public partial class Form1 : Form
    {
        List<PictureBox> waluty = new List<PictureBox>();
        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //int kwota = int.Parse(textBox1.Text);
            PictureBox pictureBox = new PictureBox();
            pictureBox.Load(@"../../Waluty/1zl.jpg");
            pictureBox.Size = new Size(100, 100);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            flp.Controls.Add(pictureBox);
        }
    }
}
