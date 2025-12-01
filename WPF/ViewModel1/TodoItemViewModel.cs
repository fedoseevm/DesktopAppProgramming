using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel1
{
    public partial class TodoItemViewModel : ObservableObject
    {
        [ObservableProperty]
        private string text;

        [ObservableProperty]
        private bool isDone;
    }
}
