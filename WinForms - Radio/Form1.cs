using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms___Radio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radioButton_BubbleSort.Enabled = false;
            radioButton_HoareSort.Enabled = false;
            radioButton_LomutoSort.Enabled = false;
            SortujButton.Visible = false;
            NumberList.Text = "";
            SortedNumberList.Text = "";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void BubbleSort(int[] T)
        {
            int n = T.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (T[j] > T[j + 1])
                    {
                        int temp = T[j];
                        T[j] = T[j + 1];
                        T[j + 1] = temp;
                    }
                }
            }
        }

        public void HoareSort(int[] T, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = HoarePartition(T, low, high);
                HoareSort(T, low, pivotIndex);
                HoareSort(T, pivotIndex + 1, high);
            }
        }

        private int HoarePartition(int[] T, int low, int high)
        {
            int pivot = T[low];
            int i = low - 1;
            int j = high + 1;

            while (true)
            {
                do
                {
                    i++;
                } while (T[i] < pivot);

                do
                {
                    j--;
                } while (T[j] > pivot);

                if (i >= j)
                    return j;

                // Swap T[i] and T[j]
                int temp = T[i];
                T[i] = T[j];
                T[j] = temp;
            }
        }

        public void LomutoSort(int[] T, int low, int high)
        {
            if (low < high)
            {
                int pivotIndex = LomutoPartition(T, low, high);
                LomutoSort(T, low, pivotIndex - 1);
                LomutoSort(T, pivotIndex + 1, high);
            }
        }

        private int LomutoPartition(int[] T, int low, int high)
        {
            int pivot = T[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (T[j] < pivot)
                {
                    i++;
                    // Swap T[i] and T[j]
                    int temp = T[i];
                    T[i] = T[j];
                    T[j] = temp;
                }
            }

            // Swap T[i + 1] and T[high] (or pivot)
            int temp1 = T[i + 1];
            T[i + 1] = T[high];
            T[high] = temp1;

            return i + 1;
        }

        private void SizeInputField_TextChanged(object sender, EventArgs e)
        {

        }

        int[] Table;
        private void LosujButton_Click(object sender, EventArgs e)
        {
            LosujButton.Enabled = false;
            SizeInputField.Enabled = false;
            NumberList.Text = "";
            SortedNumberList.Text = "";

            int n = int.Parse(SizeInputField.Text);

            radioButton_BubbleSort.Enabled = true;
            radioButton_BubbleSort.Checked = true;
            radioButton_HoareSort.Enabled = true;
            radioButton_LomutoSort.Enabled = true;
            SortujButton.Visible = true;

            Table = GenerateTable(n);
            foreach (int number in Table)
            {
                NumberList.Text += number + " ";
            }
        }

        public int[] GenerateTable(int n)
        {
            int[] Table = new int[n];
            Random r = new Random();
            for (int i = 0; i < n; i++)
            {
                Table[i] = r.Next(10, 100);
            }
            return Table;
        }

        string checkedRadioButton;
        private void radioButton_BubbleSort_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton_BubbleSort.Checked)
            //    checkedRadioButton = "radioButton_BubbleSort";
        }

        private void radioButton_LomutoSort_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton_LomutoSort.Checked)
            //    checkedRadioButton = "radioButton_LomutoSort";
        }

        private void radioButton_HoareSort_CheckedChanged(object sender, EventArgs e)
        {
            //if (radioButton_HoareSort.Checked)
            //    checkedRadioButton = "radioButton_HoareSort";
        }

        private void SortujButton_Click(object sender, EventArgs e)
        {
            if (radioButton_BubbleSort.Checked)
            {
                BubbleSort(Table);
            }
            if (radioButton_HoareSort.Checked)
            {
                HoareSort(Table, 0, Table.Length - 1);
            }
            if (radioButton_LomutoSort.Checked)
            {
                LomutoSort(Table, 0, Table.Length - 1);
            }

            foreach (int number in Table)
            {
                SortedNumberList.Text += number + " ";
            }


            SizeInputField.Enabled = true;
            LosujButton.Enabled = true;
        }

        private void SortedNumberList_Click(object sender, EventArgs e)
        {

        }
    }
}
