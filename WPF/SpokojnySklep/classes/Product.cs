using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SpokojnySklep.classes
{
    internal abstract class Product
    {
        public string Name;
        public int Price;

        protected Product(string name, int price)
        {
            Name = name;
            Price = price;
        }
    }
}
