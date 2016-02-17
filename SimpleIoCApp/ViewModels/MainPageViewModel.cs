using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SimpleIoCApp
{
	public class MainPageViewModel : BaseViewModel
	{
		public MainPageViewModel()
		{
		}

		public string Title => "Simple IoC";

		public List<MyColorClass> Items { get; set; } = new List<MyColorClass>
		{
			new MyColorClass{
				Title = "Green",
				Color = Color.Green
			},
			new MyColorClass{
				Title = "Yellow",
				Color = Color.Yellow,
			},
			new MyColorClass{
				Title = "Blue",
				Color = Color.Blue,
			},
		};

		MyColorClass selectedColor;

		public MyColorClass SelectedColor
		{
			get
			{
				return selectedColor;
			}

			set
			{
				selectedColor = value;
				OnSelectedChanged();
			}
		}

		async void OnSelectedChanged()
		{
			if (SelectedColor == null)
				return;
			await NavigationService.PushAsync(new DetailViewModel {Color = SelectedColor });
		}
	}
}

