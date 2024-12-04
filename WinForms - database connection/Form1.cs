using Microsoft.Data.Sqlite;
using System.Text;

namespace WinForms___database_connection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SQLInit();
        }
        private static void SQLInit()
        {
            String cs = "Data Source=base.db";
            SqliteConnection connection = new SqliteConnection(cs);
            connection.Open();

            SqliteCommand command = connection.CreateCommand();
            StringBuilder sb = new StringBuilder();
            sb.Append(@"CREATE TABLE IF NOT EXISTS Pracownik
            (id INTEGER PRIMARY KEY AUTOINCREMENT, imie TEXT, nazwisko TEXT, wiek INT);");
            command.CommandText = sb.ToString();
            command.ExecuteNonQuery();

            sb.Clear();
            SqliteCommand command2 = connection.CreateCommand();
            sb.Append("INSERT INTO Pracownicy VALUES (NULL, 'Bartosz', 'Sigma', 35)");
            command2.CommandText = sb.ToString();
            command2.ExecuteNonQuery();
            sb.Clear();
        }
    }

}
