using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprawdzianViewModel
{
    public partial class CustomerVM :ObservableObject
    {
        [ObservableProperty]
        private string firstName;

        [ObservableProperty]
        private string lastName;

        [ObservableProperty]
        private int orderCount;

        [ObservableProperty]
        private decimal totalSpent;

        [ObservableProperty]
        private bool isPremium;
    }
}
