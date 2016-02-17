using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace SimpleIoCApp
{
	public partial class ModalPage : ContentPage
	{
		public ModalPage()
		{
			InitializeComponent();
			ToolbarItems.Add(new ToolbarItem("Done","",() => NavigationService.PopModalAsync()));
		}

		ModalViewModel ViewModel
		{
			get { return BindingContext as ModalViewModel; }
			set { BindingContext = value; }
		}
		protected override void OnAppearing()
		{
			base.OnAppearing();
			ViewModel?.StartTimer();
		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			ViewModel?.ClearEvents();
		}

	}
}

