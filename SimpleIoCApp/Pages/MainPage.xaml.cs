using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SimpleIoCApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			this.ToolbarItems.Add(new ToolbarItem("Random", "",async () => await NavigationService.PushModalAsync(new ModalViewModel { Colors = ViewModel.Items })));
		}

		MainPageViewModel ViewModel
		{
			get { return BindingContext as MainPageViewModel;}
			set { BindingContext = value;}
		}

	}
}

