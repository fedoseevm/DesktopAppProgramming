using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprawdzianViewModel
{
    public partial class ProductVM : ObservableObject
    {
        [ObservableProperty]
        private string name;

        [ObservableProperty]
        private decimal price;

        [ObservableProperty]
        private int stock;

        [ObservableProperty]
        private bool isAvailable;

        [ObservableProperty]
        private string category;
    }
}
