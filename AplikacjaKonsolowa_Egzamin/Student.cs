using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacjaKonsolowa_Egzamin
{
    internal class Student
    {
        public int Id { get; set; }
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public double Srednia { get; set; }

        public Student(int id, string imie, string nazwisko, double srednia)
        {
            Id = id;
            Imie = imie;
            Nazwisko = nazwisko;
            Srednia = srednia;
        }
    }
}
