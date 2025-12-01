using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel1
{
    public partial class MyViewModel : ObservableObject
    {
        [ObservableProperty]
        private int counter = 0;

        [RelayCommand]
        public void Increment()
        {
            Counter++;
        }

        [RelayCommand]
        public void Decrement()
        {
            Counter--;
        }
    }
}
