using Microsoft.Data.Sqlite;
using System.IO;
using System.Windows.Forms;


namespace WinForms___Wyniki_wyborow
{
    public partial class Form1 : Form
    {
        private string dbPath = Path.Combine(Application.StartupPath, "database", "wybory.db");

        public Form1()
        {
            InitializeComponent();
        }

        private void loadDBbtn_Click(object sender, EventArgs e)
        {
            LoadDataFromDatabase();
        }

        private void LoadDataFromDatabase()
        {
            using (var connection = new SqliteConnection($"Data Source={dbPath}"))
            {
                connection.Open();

                var command = connection.CreateCommand();
                command.CommandText = "SELECT Wojew�dztwo, NAWROCKI Karol Tadeusz, TRZASKOWSKI Rafa� Kazimierz FROM Wyniki"; // dopasuj nazw� tabeli i kolumn

                using (var reader = command.ExecuteReader())
                {
                    dataGridViewResults.Rows.Clear();
                    dataGridViewResults.Columns.Clear();

                    // Dodaj kolumny (mo�esz dostosowa� nag��wki)
                    dataGridViewResults.Columns.Add("Wojew�dztwo", "Wojew�dztwo");
                    dataGridViewResults.Columns.Add("NAWROCKI Karol Tadeusz", "Kandydat 1 (liczba g�os�w)");
                    dataGridViewResults.Columns.Add("TRZASKOWSKI Rafa� Kazimierz", "Kandydat 2 (liczba g�os�w)");

                    while (reader.Read())
                    {
                        string wojewodztwo = reader.GetString(0);
                        string kandydat1 = reader.GetString(1);
                        string kandydat2 = reader.GetString(2);

                        dataGridViewResults.Rows.Add(wojewodztwo, kandydat1, kandydat2);
                    }
                }
            }
        }
    }
}
