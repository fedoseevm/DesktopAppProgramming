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

namespace WinForms___TODO2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            maleRadioButton.Checked = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private const string filePath = @"../../osoby.txt";
        //private List<string>
        private void saveButton_Click(object sender, EventArgs e)
        {
            string name = nameInputField.Text;
            string gender = maleRadioButton.Checked ? "Mężczyzna" : "Kobieta";
            string info = inputField.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string record = $"{name};{gender};{info}";
            File.AppendAllText(filePath, record + "\n");

            MessageBox.Show($"Dodano osobę: {name}, {gender} - {info}");

            nameInputField.Clear();
            maleRadioButton.Checked = true;
            inputField.Clear();

        }

        private void showListButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            dataGridView1.Rows.Clear();
            var osoby = new List<string[]>();  // string[] - tablica string[] będzie reprezentować dane jednej osoby (np. ["John", "Male", "Likes music"])
            foreach (var line in File.ReadAllLines(filePath))
            {
                osoby.Add(line.Split(';'));
                //MessageBox.Show($"{osoby[osoby.Count - 1][0]} {osoby[osoby.Count - 1][1]} {osoby[osoby.Count - 1][2]}");

                string name = osoby[osoby.Count - 1][0];
                string gender = osoby[osoby.Count - 1][1];
                string info = osoby[osoby.Count - 1][2];

                listView1.Items.Add($"{name} {gender} {info}");
                //listView1.Items = osoby;
            }

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Imie";
            dataGridView1.Columns[1].Name = "Płeć";
            dataGridView1.Columns[2].Name = "Info";

            foreach (string[] personArray in osoby)
            {
                dataGridView1.Rows.Add(personArray); // Dodaj wiersz dla każdej osoby
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
