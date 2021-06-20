using maui_bindable_test.Models;
using Microsoft.Maui.Controls;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace maui_bindable_test.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public List<TestModel> TestList { get; set; } = new List<TestModel>();

        public ObservableCollection<TestModel> TestOc { get; set; } = new ObservableCollection<TestModel>();

        public ICommand UpdateListCommand { get; set; }

        public ICommand UpdateOCCommand { get; set; }

        public string CommandText { get; set; }

        public MainViewModel()
        {
            TestList.Add(new TestModel
            {
                Name = "List Test Init"
            });

            TestOc.Add(new TestModel
            {
                Name = "OC Test Init"
            });

            UpdateListCommand = new Command(() => UpdateList());
            UpdateOCCommand = new Command(() => UpdateOc());
        }

        public void UpdateList()
        {
            TestList.Clear();
            CommandText = "You clicked update list";

            RaisePropertyChanged(nameof(TestList), nameof(CommandText));
            
            TestList.Add(new TestModel
            {
                Name = "List Test Update"
            });

            RaisePropertyChanged(nameof(TestList));
        }

        public void UpdateOc()
        {
            TestOc.Clear();

            CommandText = "You clicked update Observable Collection";
            RaisePropertyChanged(nameof(CommandText));

            TestOc.Add(new TestModel
            {
                Name = "OC Test Update"
            });
        }
    }
}
