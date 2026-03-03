using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Opisywacz_ViewModel
{
    public partial class OpisywaczViewModel : ObservableObject
    {
        [ObservableProperty]
        private string autor = "Maksim";
        [ObservableProperty]
        private string cecha1;
        [ObservableProperty]
        private string cecha2;
        [ObservableProperty]
        private string cecha3;
        [ObservableProperty]
        private DateOnly data;

        [RelayCommand]
        private void WypiszCechy()
        { 

        }
    }
}
