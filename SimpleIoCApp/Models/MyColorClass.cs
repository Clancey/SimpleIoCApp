using System;
using Xamarin.Forms;
namespace SimpleIoCApp
{
	public class MyColorClass : BaseModel
	{
		string title;

		public string Title
		{
			get { return title; }
			set { ProcPropertyChanged(ref title,value); }
		}

		Color color;

		public Color Color
		{
			get { return color; }
			set { ProcPropertyChanged(ref color,value); }
		}

	}
}

