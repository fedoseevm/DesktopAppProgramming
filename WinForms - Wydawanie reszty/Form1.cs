using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms___Wydawanie_reszty
{
    public partial class Form1 : Form
    {
        Dictionary<int, string> nominaly = new Dictionary<int, string>()
        {
            { 20, @"../../denominations/20zl.jpg" },
            { 10, @"../../denominations/10zl.jpg" },
            { 5, @"../../denominations/5zl.jpg" },
            { 2, @"../../denominations/2zl.jpg" },
            { 1, @"../../denominations/1zl.jpg" }
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            int kwota = int.Parse(textBox1.Text);
            //PictureBox pictureBox = new PictureBox();
            //pictureBox.Load(@"../../denominations/1zl.jpg");
            //pictureBox.Size = new Size(100, 100);
            //pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            //flp.Controls.Add(pictureBox);

            foreach (int nominal in nominaly.Keys)
            {
                while (kwota >= nominal)
                {
                    PictureBox pictureBox = new PictureBox();
                    pictureBox.Load(nominaly[nominal]);
                    pictureBox.Size = new Size(120, 100);
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
                    flp.Controls.Add(pictureBox);

                    kwota -= nominal;
                }
            }
        }
    }
}
