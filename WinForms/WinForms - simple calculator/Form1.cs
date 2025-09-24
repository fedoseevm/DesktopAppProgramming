namespace WinForms___simple_calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculator calculator = new Calculator();
            int L1 = int.Parse(textBox1.Text);
            int L2 = int.Parse(textBox2.Text);
            int wynik = calculator.Add(L1, L2);
            label1.Text = wynik.ToString();
        }
    }
}
