namespace WinForms___Newton_Raphson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int input;
            try
            {
                input = int.Parse(inputTextBox.Text);
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Podaj liczbê");
                return;
            }

            if (input < 30 || input > 70)
            {
                MessageBox.Show("Liczba ma byæ w zakresie <30;70>");
                return;
            }

            int accuracy = trackBar1.Value;
            int k = 1;
            double answer = (input + input / input) / 2;
            k++;
            while (k <= accuracy)
            {
                answer = (answer + input / answer) / 2;
                k++;
            }

            WindowsOutput.Text = Convert.ToString(Math.Sqrt(input));
            NROutput.Text = Convert.ToString(answer);

        }


    }
}
