using System;
namespace SimpleIoCApp
{
	public class DetailViewModel : BaseViewModel
	{
		public DetailViewModel()
		{
		}
		public string Title => Color?.Title ?? "No Color";
		public MyColorClass Color { get; set; }
	}
}

