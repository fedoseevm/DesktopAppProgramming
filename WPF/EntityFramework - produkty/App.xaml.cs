using System.Configuration;
using System.Data;
using System.Windows;

namespace EntityFramework___produkty
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            using var db = new KoszykContext();
            //db.Database.Migrate();    // tworzy bazę + migracje o ile takie coś macie zdefiniowane
            db.Database.EnsureCreated();
            if (!db.Kategorie.Any())
            {
                db.Kategorie.AddRange(
                    new Kategoria { Nazwa = "IT" },
                    new Kategoria { Nazwa = "Rolnictwio" },
                    new Kategoria { Nazwa = "Rybołóstwo" }
                );

                db.SaveChanges();
            }

            if (!db.Produkty.Any())
            {
                db.Produkty.AddRange(
                    new Produkt { Nazwa = "Komputer", Cena = 1499.00, KategoriaId = 1 },
                    new Produkt { Nazwa = "Monitor", Cena = 515.23, KategoriaId = 1 },
                    new Produkt { Nazwa = "Klawiatura", Cena = 59.99, KategoriaId = 1 },
                    new Produkt { Nazwa = "Taktor", Cena = 100000.00, KategoriaId = 2 },
                    new Produkt { Nazwa = "Przyczepa", Cena = 12600.00, KategoriaId = 2 },
                    new Produkt { Nazwa = "Wory", Cena = 50.00, KategoriaId = 2 },
                    new Produkt { Nazwa = "Wędka", Cena = 300.10, KategoriaId = 3 },
                    new Produkt { Nazwa = "Licencja z łodzi", Cena = 350.00, KategoriaId = 3 }
                );

                db.SaveChanges();
            }
        }

    }

}
