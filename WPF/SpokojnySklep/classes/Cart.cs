using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpokojnySklep.classes
{
    internal class Cart
    {
        public IDiscountStrategy DiscountStrategy;
        public List<Product> Products;

        public Cart()
        {
            Products = new List<Product>();
            GenerateSampleProducts();
        }

        private void GenerateSampleProducts()
        {
            Products.Add(new PhysicalProduct("Computer", 400));
            Products.Add(new PhysicalProduct("Zinger", 15));
        }

        public int CalculateCartValue()
        {
            int value = 0;
            foreach (var item in Products)
            {
                value += item.Cena;
            }
            return value;
        }

        public int CalculateCartValueWithDiscount(IDiscountStrategy discountStrategy, int discountValue)
        {
            this.DiscountStrategy = discountStrategy;
            int cartValue = CalculateCartValue();
            return DiscountStrategy.CalculateDiscount(cartValue, discountValue);
        }
    }
}
