using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelViewListItem
{
    public partial class TodoListViewModel : ObservableObject
    {
        [ObservableProperty]
        private string newTodoItem = string.Empty;

        public ObservableCollection<TodoItemViewModel> TodoItems { get; } = new();

        public TodoListViewModel()
        {
            TodoItems.Add(new TodoItemViewModel { Text = "Umyj się" });
            TodoItems.Add(new TodoItemViewModel { Text = "Posprzątaj pokój" });
        }

        [RelayCommand]
        private void AddNewItem()
        {
            if (NewTodoItem.Trim() != string.Empty)
                TodoItems.Add(new TodoItemViewModel { Text = newTodoItem });
            NewTodoItem = string.Empty;
        }

        [RelayCommand]
        private void RemoveItem(TodoItemViewModel item)
        {
            TodoItems.Remove(item);
        }

        [RelayCommand]
        private void SelectAll()
        {
            foreach(var item in TodoItems)
            {
                item.IsDone = true;
            }
        }

        [RelayCommand]
        private void RemoveSelected()
        {
            for (int i = 0; i < TodoItems.Count; i++)
            {
                if (TodoItems[i].IsDone)
                {
                    TodoItems.RemoveAt(i--);
                }
            }
        }
    }
}
