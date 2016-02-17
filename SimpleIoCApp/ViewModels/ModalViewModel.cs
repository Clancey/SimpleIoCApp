using System;
using System.Collections.Generic;
using System.Timers;
namespace SimpleIoCApp
{
	public class ModalViewModel : BaseViewModel
	{
		public ModalViewModel()
		{

		}

		public string Title => Color?.Title ?? "Randomizing Color";

		List<MyColorClass> colors;

		public List<MyColorClass> Colors
		{
			get { return colors; }
			set { ProcPropertyChanged(ref colors, value); }
		}
		MyColorClass color;

		public MyColorClass Color
		{
			get { return color; }
			set
			{
				if (ProcPropertyChanged(ref color, value))
					ProcPropertyChanged("Title");
			}
		}


		Timer Timer;
		public void StartTimer()
		{
			if (Timer != null)
				Timer.Elapsed -= Timer_Elapsed;
			Timer?.Stop();
			Timer?.Dispose();
			Timer = new Timer(1000);
			Timer.Elapsed += Timer_Elapsed;
			Timer.Start();
		}

		Random random = new Random();
		void Timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			var count = Colors?.Count ?? 0;
			if (count == 0)
				return;
			var index = random.Next(0, count);
			Color = Colors[index];
		}
		public override void ClearEvents()
		{
			base.ClearEvents();
		}
	}
}

