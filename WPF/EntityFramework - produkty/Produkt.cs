using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework___produkty
{
    internal class Produkt
    {
        public int Id { get; set; }
        public int KategoriaId { get; set; }
        public Kategoria Kategoria { get; set; }
        public string Nazwa { get; set; }
        public double Cena { get; set; }

        public override String ToString()
        {
            return Nazwa;
        }
    }

}
