using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AplikacjaKonsolowa_Egzamin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> studenty = new List<Student>();

            while (true)
            {
                Console.WriteLine("\n===== STUDENT DATABASE MENU =====");
                Console.WriteLine("1. Dodaj studenta");
                Console.WriteLine("2. Usuń studenta po ID");
                Console.WriteLine("3. Wyświetl wszystkich studentów");
                Console.WriteLine("4. Sortuj po średniej malejąco");
                Console.WriteLine("5. Oblicz średnią wszystkich studentów");
                Console.WriteLine("6. Wyszukaj studenta po nazwisku");
                Console.WriteLine("7. Wyjście");
                Console.Write("Wybierz opcję: ");

                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice)
                {
                    case "1":
                        AddStudent(studenty);
                        break;
                    case "2":
                        RemoveStudent(studenty);
                        break;
                    case "3":
                        DisplayStudents(studenty);
                        break;
                    case "4":
                        SortByAverage(studenty);
                        break;
                    case "5":
                        CalculateOverallAverage(studenty);
                        break;
                    case "6":
                        SearchByLastName(studenty);
                        break;
                    case "7":
                        return;
                    default:
                        Console.WriteLine("Niepoprawny wybór.");
                        break;
                }
            }
        }

        private static void SearchByLastName(List<Student> studenty)
        {
            Console.Write("Podaj nazwisko do wyszukania: ");
            string nazwisko = Console.ReadLine();

            bool znaleziono = false;

            foreach (var student in studenty)
            {
                if (student.Nazwisko.Equals(nazwisko, StringComparison.OrdinalIgnoreCase))
                {
                    if (!znaleziono)
                    {
                        Console.WriteLine("ID | Imię | Nazwisko | Średnia");
                        Console.WriteLine("-------------------------------");
                        znaleziono = true;
                    }

                    Console.WriteLine($"{student.Id} | {student.Imie} | {student.Nazwisko} | {student.Srednia:f1}");
                }
            }

            if (!znaleziono)
                Console.WriteLine("Nie znaleziono studentów.");

            Console.ReadKey();
            Console.Clear();
        }

        private static void CalculateOverallAverage(List<Student> studenty)
        {
            if (studenty.Count == 0)
            {
                Console.WriteLine("Brak studentów.");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            double suma = 0;

            foreach (var student in studenty)
                suma += student.Srednia;

            double srednia = suma / studenty.Count;

            Console.WriteLine($"Średnia wszystkich studentów: {srednia:f2}");
            Console.ReadKey();
            Console.Clear();
        }

        private static void SortByAverage(List<Student> studenty)
        {
            studenty.Sort((a, b) => b.Srednia.CompareTo(a.Srednia));
            Console.WriteLine("Studenci zostali posortowani.");
            Console.ReadKey();
            Console.Clear();
        }

        private static void DisplayStudents(List<Student> studenty)
        {
            if (studenty.Count == 0)
            {
                Console.WriteLine("Brak studentów.");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            Console.WriteLine("ID | Imię | Nazwisko | Średnia");
            Console.WriteLine("-------------------------------");

            foreach (var student in studenty)
                Console.WriteLine($"{student.Id} | {student.Imie} | {student.Nazwisko} | {student.Srednia:f1}");

            Console.ReadKey();
            Console.Clear();
        }

        private static void RemoveStudent(List<Student> studenty)
        {
            Console.Write("Podaj ID studenta do usunięcia: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("Błędne ID.");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            for (int i = 0; i < studenty.Count; i++)
            {
                if (studenty[i].Id == id)
                {
                    studenty.RemoveAt(i);
                    Console.WriteLine("Student usunięty.");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
            }

            Console.WriteLine("Nie znaleziono studenta.");
            Console.ReadKey();
            Console.Clear();
        }

        //***********************************
        //nazwa funcji: AddStudent
        //opis funkcji: Dodaje nowego studenta do listy studentów
        //paramentry: lista studentów
        //zwracany typ i opis: brak 
        //autor: 04
        //***********************************
        private static void AddStudent(List<Student> studenty)
        {
            Console.Write("Podaj ID (liczba naturalna): ");
            if (!int.TryParse(Console.ReadLine(), out int id) || id < 0)
            {
                Console.WriteLine("Błędne ID.");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            foreach (var student in studenty)
            {
                if (student.Id == id)
                {
                    Console.WriteLine("Student o podanym ID już istnieje.");
                    Console.ReadKey();
                    Console.Clear();
                    return;
                }
            }

            Console.Write("Podaj imię: ");
            string imie = Console.ReadLine();

            if (!isValidText(imie))
            {
                Console.WriteLine("Niepoprawne imię.");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            Console.Write("Podaj nazwisko: ");
            string nazwisko = Console.ReadLine();

            if (!isValidText(nazwisko))
            {
                Console.WriteLine("Niepoprawne nazwisko.");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            Console.Write("Podaj średnią {2.0, 3.0, 3.5, 4.0, 4.5, 5.0}: ");
            if (!double.TryParse(Console.ReadLine(), out double srednia))
            {
                Console.WriteLine("Błędna średnia.");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            double[] srednie = { 2.0, 3.0, 3.5, 4.0, 4.5, 5.0 };
            if (!srednie.Contains(srednia))
            {
                Console.WriteLine("Niedozwolona średnia.");
                Console.ReadKey();
                Console.Clear();
                return;
            }

            studenty.Add(new Student(id, imie, nazwisko, srednia));
            Console.WriteLine("Student dodany poprawnie!");
            Console.ReadKey();
            Console.Clear();
        }

        //***********************************
        //nazwa funcji: isValidText
        //opis funkcji: Sprawdza, czy podany tekst jest niepusty i zaczyna się wielką literą, a następnie zawiera tylko małe litery.
        //paramentry: tekst do sprawdzenia
        //zwracany typ i opis: bool - true jeśli tekst jest poprawny, false w przeciwnym razie
        //autor: 04
        //***********************************
        private static bool isValidText(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) return false;
            return Regex.IsMatch(text, @"^[A-Z][a-z]+$");
        }
    }
}
