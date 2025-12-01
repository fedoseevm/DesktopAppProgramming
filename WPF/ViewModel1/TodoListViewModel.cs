using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModel1
{
    public partial class TodoListViewModel : ObservableObject
    {
        [ObservableProperty]
        private string newTodoItem = string.Empty;

        ObservableCollection<TodoItemViewModel> TodoItems { get; } = new();
        public TodoListViewModel()
        {
            TodoItems.Add(new TodoItemViewModel { Text = "Wynieś śmieci" });
            TodoItems.Add(new TodoItemViewModel { Text = "Posprzątaj pokój" });
        }

        [RelayCommand]
        public void AddTodoItem()
        {
            TodoItems.Add(new TodoItemViewModel { Text = newTodoItem });
        }
    }
}
