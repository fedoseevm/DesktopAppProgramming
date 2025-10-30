using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDB1
{
    internal class DAO
    {
        OsobaContext context;
        public DAO() { 
            context = new OsobaContext();
            context.Database.EnsureCreated();
        }

        public void dodajOsobe(Osoba osoba)
        {
            context.Osoby.Add(osoba);
            context.SaveChanges();

        }

        public List<Osoba> pobierzOsoby()
        {
            return new List<Osoba>(context.Osoby);
        }
    }
}
