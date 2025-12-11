using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprawdzianViewModel
{
    public partial class ShopVM : ObservableObject
    {
        public ObservableCollection<ProductVM> Products { get; } = new();
        public ObservableCollection<CustomerVM> Customers { get; } = new();

        [ObservableProperty]
        private int customerCount;

        [ObservableProperty]
        private decimal wareHouseValue;

        public ShopVM()
        {
            Products.Add(new ProductVM { 
                Name = "Laptop Dell XPS", 
                Price = 3500, 
                Stock = 12, 
                IsAvailable = true, 
                Category = "Elektronika" 
            });
            Products.Add(new ProductVM { 
                Name = "Mysz Logitech", 
                Price = 89, 
                Stock = 45, 
                IsAvailable = true, 
                Category = "Akcesoria" 
            });
            Products.Add(new ProductVM { 
                Name = "Klawiatura Mechaniczna", 
                Price = 299, 
                Stock = 8, 
                IsAvailable = true, 
                Category = "Akcesoria" 
            });

            Customers.Add(new CustomerVM {
                FirstName = "Jan",
                LastName = "Kowalski",
                OrderCount = 15,
                TotalSpent = 8500,
                IsPremium = true
            });
            Customers.Add(new CustomerVM {
                FirstName = "Anna",
                LastName = "Nowak",
                OrderCount = 3,
                TotalSpent = 1200,
                IsPremium = false
            });
            Customers.Add(new CustomerVM {
                FirstName = "Piotr",
                LastName = "Wiśniewski",
                OrderCount = 3,
                TotalSpent = 15600,
                IsPremium = true
            });
        }

        [RelayCommand]
        private void CalculateAggregations()
        {

        }
    }
}
