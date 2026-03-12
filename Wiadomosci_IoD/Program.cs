using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiadomosci_IoD
{
    interface IWypisz
    {
        void Wypisz(string s);
    }
    interface IZapisz
    {
        void Zapisz(string s);
    }

    class DoKonsoli : IWypisz
    {
        public void Wypisz(string s)
        {
            Console.WriteLine("Wypisuje do konsoli: {0}", s);
        }
    }
    class DoPliku : IWypisz
    {
        public void Wypisz(string s)
        {
            Console.WriteLine("Stworzyłem plik wiadomosc.txt o tresci: {0}", s);
            File.AppendAllText("../../wiadomosc.txt", s);
        }
    }
    class DoBazy : IZapisz
    {
        public void Zapisz(string s)
        {
            Console.WriteLine("Dodałem do bazy: {0}", s);
        }
    }
    class DoPamieciAplikacji : IZapisz
    {
        public void Zapisz(string s)
        {
            Console.WriteLine("Zapisałem do pamieci aplikacji: {0}", 0);
        }
    }

    class Kronikarz
    {
        public IWypisz metodaWypisywania;
        public Kronikarz(IWypisz metoda)
        {
            metodaWypisywania = metoda;
        }
    }

    class Archiwista
    {
        public IZapisz metodaZapisywania;
        public Archiwista(IZapisz metoda)
        {
            metodaZapisywania = metoda;
        }
    }

    class Wiadomosc
    {
        Kronikarz kronikarz;
        Archiwista archiwista;

        public Wiadomosc(Kronikarz kronikarz, Archiwista archiwista)
        {
            this.kronikarz = kronikarz;
            this.archiwista = archiwista;
        }

        public void Wyslij(string napis)
        {
            kronikarz.metodaWypisywania.Wypisz(napis);
            archiwista.metodaZapisywania.Zapisz(napis);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            DoKonsoli doKonsoli = new DoKonsoli();
            DoPliku doPliku = new DoPliku();
            DoBazy doBazy = new DoBazy();
            DoPamieciAplikacji doPamieciAplikacji = new DoPamieciAplikacji();

            Kronikarz kr1 = new Kronikarz(doKonsoli);
            Archiwista arc1 = new Archiwista(doBazy);

            Wiadomosc wd1 = new Wiadomosc(kr1, arc1);
            wd1.Wyslij("test");
        }
    }
}
