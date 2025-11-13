using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework___produkty
{
    internal class KoszykContext : DbContext
    {
        public DbSet<Kategoria> Kategorie { get; set; }
        public DbSet<Produkt> Produkty { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=../../../koszyk.db");
            MySeed();
        }

        public void MySeed()
        {
            if (Produkty.Any()) return;

            Kategoria kat1 = new Kategoria() { Id = 1, Nazwa = "Elektro" };
            Kategoria kat2 = new Kategoria() { Id = 2, Nazwa = "HausFrau" };
            Kategoria kat3 = new Kategoria() { Id = 3, Nazwa = "Garage" };
            Kategorie.Add(kat1);
            Kategorie.Add(kat2);
            Kategorie.Add(kat3);
            SaveChanges();

            Produkt p1 = new Produkt { Id = 1, IdKategoria = 1, Nazwa = "Komp", Cena = 100.0 };
            Produkt p2 = new Produkt { Id = 2, IdKategoria = 2, Nazwa = "Garnek", Cena = 30 };
            Produkt p3 = new Produkt { Id = 3, IdKategoria = 3, Nazwa = "Wąż ogrodowy", Cena = 10 };
            Produkt p4 = new Produkt { Id = 4, IdKategoria = 1, Nazwa = "Monitor", Cena = 50.0 };
            Produkt p5 = new Produkt { Id = 5, IdKategoria = 1, Nazwa = "Myszka", Cena = 20.0 };
            Produkty.Add(p1);
            Produkty.Add(p2);
            Produkty.Add(p3);
            Produkty.Add(p4);
            Produkty.Add(p5);
            SaveChanges();
        }
    }
}
