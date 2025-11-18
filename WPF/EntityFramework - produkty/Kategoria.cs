using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework___produkty
{
    internal class Kategoria
    {
        public int Id { get; set; }
        public string Nazwa { get; set; }
        //ICollection<Produkt> Produkty { get; set; }

        public override String ToString()
        {
            return Nazwa;
        }
    }
}
