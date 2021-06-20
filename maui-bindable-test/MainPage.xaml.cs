using System;
using maui_bindable_test.ViewModels;
using Microsoft.Maui.Controls;

namespace maui_bindable_test
{
	public partial class MainPage : ContentPage
	{
        public MainViewModel ViewModel { get; set; }

        public MainPage()
		{
			InitializeComponent();
			ViewModel = new MainViewModel();
			BindingContext = ViewModel;
		}

	}
}
