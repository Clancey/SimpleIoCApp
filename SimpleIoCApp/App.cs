using System;

using Xamarin.Forms;

namespace SimpleIoCApp
{
	public class App : Application
	{
		public App()
		{
			RegisterPages();
			NavigationService.SetRoot(new MainPageViewModel());
		}
		void RegisterPages()
		{
			SimpleIoC.RegisterPage<MainPageViewModel, MainPage>();
			SimpleIoC.RegisterPage<DetailViewModel, DetailsPage>();
			SimpleIoC.RegisterPage<ModalViewModel, ModalPage>();
		}
		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}

