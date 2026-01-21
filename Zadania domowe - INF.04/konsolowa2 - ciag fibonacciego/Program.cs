using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsolowa2___ciag_fibonacciego
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Podaj liczbę wyrazów ciągu (5-30): ");
                int n;
                if (!int.TryParse(Console.ReadLine(), out n) || n < 5 || n > 30)
                {
                    Console.WriteLine("Błąd! Liczba musi być z zakresu 5-30.");
                }
                else
                {
                    List<int> lista = GenerujFibonacci(n);
                    WyswietlWyniki(lista, n);
                }

            }
        }

        private static void WyswietlWyniki(List<int> lista, int n)
        {
            Console.WriteLine($"\nCiąg Fibonacciego ({n} wyrazów):");
            int ile_pierwszych = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write($"\nF({i}) = {lista[i]} ");
                if (СzyPierwsza(lista[i]))
                {
                    Console.Write("[PIERWSZA]");
                    ile_pierwszych++;
                }
            }

            Console.WriteLine("\n\n=== STATYSTYKI ===");
            float procent = (float)ile_pierwszych / (float)n * 100;
            Console.WriteLine($"Liczb pierwszych: {ile_pierwszych} / {n} ({procent:F2}%)");
        }

        private static bool СzyPierwsza(int x)
        {
            if (x == 0) return false;
            if (x == 1) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0)
                    return false;
            }
            return true;
        }

        private static List<int> GenerujFibonacci(int n)
        {
            List<int> wynik = new List<int>() { 0, 1 };
            for (int i = 1; i < n; i++)
            {
                wynik.Add(wynik[i] + wynik[i - 1]);
            }
            return wynik;
        }
    }
}
