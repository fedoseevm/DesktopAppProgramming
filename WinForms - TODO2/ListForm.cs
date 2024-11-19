using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms___TODO2
{
    internal class ListForm : Form
    {
        private void InitializeComponent()
        {
            public ListForm(List<string[]> people)
            {
                InitializeComponent();

                // Konfiguracja DataGridView
                peopleDataGridView.Columns.Add("Name", "Name");
                peopleDataGridView.Columns.Add("Gender", "Gender");
                peopleDataGridView.Columns.Add("About", "About");

                // Dodanie danych do DataGridView
                foreach (var person in people)
                {
                    peopleDataGridView.Rows.Add(person);
                }
            }
        }
    }
}
