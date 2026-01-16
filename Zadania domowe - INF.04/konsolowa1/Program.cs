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
                    Console.WriteLine();
                    for (int i = 0; i < n; i++)
                    {
                        Console.Write($"Podaj liczbę {i + 1}: ");
                        int liczba;
                        if (!int.TryParse(Console.ReadLine(), out liczba) || liczba < 1 || liczba > 9999)
                        {
                            Console.WriteLine("Liczba musi być z zakresu 1-9999");
                            i--;
                        }
                        else lista.Add(liczba);
                    }

                    WyswietlTablice("Tablica przed sortowaniem:", lista);

                    List<int> sumyCyfr = new List<int>();
                    foreach (int liczba in lista)
                    {
                        sumyCyfr.Add(ObliczSumeCyfr(liczba));
                    }

                    WyswietlTablice("Tablica z sumami cyfr", lista, sumyCyfr);

                    sumyCyfr = SortowanieBabelkowe(sumyCyfr);

                    for (int i = 0; i < sumyCyfr.Count; i++)
                    {
                        for (int j = 0; j < lista.Count; j++)
                        {
                            if (sumyCyfr[i] == ObliczSumeCyfr(lista[j]))
                            {
                                int temp = lista[i];
                                lista[i] = lista[j];
                                lista[j] = temp;
                            }
                        }
                    }

                    WyswietlTablice("Tablica po sortowaniu:", lista);
                    return;
                }
                else Console.WriteLine("Błąd! Liczba musi być z zakresu 3-20.");
            }
        }

        private static void WyswietlTablice(string opis, List<int> lista, List<int> sumyCyfr)
        {
            int n = lista.Count;
            Console.WriteLine("\n" + opis);
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write($"{lista[i]} (suma: {sumyCyfr[i]}), ");
            }
            Console.Write($"{lista[n - 1]} (suma: {sumyCyfr[n - 1]}) \n");
        }

        private static void WyswietlTablice(string opis, List<int> lista)
        {
            Console.WriteLine("\n" + opis);
            foreach (var item in lista)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        private static int ObliczSumeCyfr(int x)
        {
            int sum = 0;
            while (x > 0)
            {
                sum += x % 10;
                x /= 10;
            }
            return sum;
        }

        private static List<int> SortowanieBabelkowe(List<int> list)
        {
            int n = list.Count;
            int temp;
            for (int i = n - 1; i > 0; i--)
            {
                for (int j = 0; j < i; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        temp = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = temp; 
                    }
                }
            }
            return list;
        }
    }
}
