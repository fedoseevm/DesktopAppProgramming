using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsolowa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            while (true)
            {
                Console.Write("Podaj liczbę elementów: ");
                int n;
                if (int.TryParse(Console.ReadLine(), out n) && n >= 3 && n <= 20)
                {
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Podaj liczbę {i}: ");
                        int liczba;
                        if (!int.TryParse(Console.ReadLine(), out liczba) || liczba < 1 || liczba > 9999)
                        {
                            Console.WriteLine("Liczba musi być z zakresu 1-9999");
                            i--;
                        }
                        else lista.Add(liczba);
                    }

                    List<int> sumyCyfr = new List<int>();
                    foreach (int liczba in lista)
                    {
                        sumyCyfr.Add(GetDigitsSum(liczba));
                    }
                }
                else Console.WriteLine("Błąd! Liczba musi być z zakresu 3-20.");
            }
        }

        private static int GetDigitsSum(int x)
        {
            int sum = 0;
            while (x > 0)
            {
                sum += x % 10;
                x /= 10;
            }
            return sum;
        }

        private static List<int> BubbleSort(List<int> list)
        {
            int n = list.Count;
            for (int i = n - 1; i >= 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        int temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp; 
                    }
                }
            }
            return list;
        }
    }
}
