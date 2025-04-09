namespace WinForms___losowa_macierz__kolko___krzyzyk_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label1.Text = "";
            flowLayoutPanel1.Controls.Clear();
        }

        private void randomButton_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            int n = 3;
            int[,] macierz = new int[n,n];
            macierz = wypelnijMacerz(macierz, n);

            string wynik = sprawdzWynik(macierz);

            label1.Text = wynik;
        }

        private string sprawdzWynik(int[,] macierz)
        {
            int suma_pionowa = 0;
            for (int i = 0; i < macierz.GetLength(0); i++)
            {
                suma_pionowa += macierz[i, 0];
                int suma_pozioma = 0;
                for (int j = 0; j <  macierz.GetLength(1); j++)
                {
                    suma_pozioma += macierz[i, j];


                }

                if (suma_pozioma == 3)
                    return "Wygra³ X";
                else if (suma_pozioma == 0)
                    return "Wygra³ O";
            }

            if (suma_pionowa == 3)
                return "Wygra³ X";
            else if (suma_pionowa == 0)
                return "Wygra³ O";
            else if (macierz[0,0] + macierz[1,1] + macierz[2,2] == 3)
                return "Wygra³ X";
            else if (macierz[0, 0] + macierz[1, 1] + macierz[2, 2] == 0)
                return "Wygra³ O";
            else if (macierz[0,2] + macierz[1,1 + macierz[2,0]] == 3)
                return "Wygra³ X";
            else if (macierz[0, 2] + macierz[1, 1 + macierz[2, 0]] == 0)
                return "Wygra³ O";

            return "Remis";
        }

        private int[,] wypelnijMacerz(int[,] macierz, int n)
        {
            List<string> obrazki = new List<string>()
            {
                @"../../../src/kolko.png",
                @"../../../src/krzyzyk.png"
            };

            Random random = new Random();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    macierz[i, j] = random.Next(0, 2);

                    PictureBox pictureBox = new PictureBox();
                    if (macierz[i, j] == 0)
                    {
                        pictureBox.Image = Image.FromFile(obrazki[0]);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Width = 100;
                        pictureBox.Height = 100;
                        flowLayoutPanel1.Controls.Add(pictureBox);
                    }
                    else
                    {
                        pictureBox.Image = Image.FromFile(obrazki[1]);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Width = 100;
                        pictureBox.Height = 100;
                        flowLayoutPanel1.Controls.Add(pictureBox);
                    }
                }
            }


            return macierz;
        }
    }
}
