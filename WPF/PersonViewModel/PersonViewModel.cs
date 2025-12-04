using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsobaViewModel
{
    public partial class PersonViewModel : ObservableObject
    {
        [ObservableProperty]
        private string firstName;

        [ObservableProperty]
        private string lastName;

        [ObservableProperty]
        private string fullName;


        partial void OnFirstNameChanged(string value)
        {
            FullName = $"{FirstName} {LastName}";
        }

        partial void OnLastNameChanged(string value)
        {
            FullName = $"{FirstName} {LastName}";
        }
    }
}
