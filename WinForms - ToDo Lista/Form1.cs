namespace WinForms___ToDo_Lista
{
    public partial class Form1 : Form
    {
        private Dictionary<int, string> toDoList = new Dictionary<int, string>();

        public Form1()
        {
            InitializeComponent();
            NotificationLabel.Text = "";
            dataGridView1.DataSource = toDoList.Select(x => new { Klucz = x.Key, Wartosc = x.Value }).ToList();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //string godzina = TimeInputBox.Text;
            NotificationLabel.Text = "";

            if (!int.TryParse(TimeInputBox.Text, out int godzina))
            {
                NotificationLabel.Text = "Podaj godzinê jako liczbê";
                return;
            }
            else if (Convert.ToInt16(godzina) > 24 || Convert.ToInt16(godzina) < 0)
            {
                NotificationLabel.Text = "Podaj godzinê w prawid³owej postaci [0 - 24]";
                return;
            }

            //if (!input.Contains(':'))
            //{
            //    NotificationLabel.Text = "Podaj godzinê w prawid³owej postaci";
            //}

            string zadanie = TaskDescInputBox.Text;
            //Dictionary<int, string> toDoList = new Dictionary<int, string>();

            if (!toDoList.ContainsKey(godzina))
            {
                toDoList.Add(godzina, zadanie);
            }

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = toDoList.Select(x => new { Klucz = x.Key, Wartosc = x.Value }).ToList();

        }
    }
}
