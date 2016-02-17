using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SimpleIoCApp
{
	public class BaseModel : INotifyPropertyChanged, IDisposable
	{
		public event PropertyChangedEventHandler PropertyChanged;

		public void Dispose()
		{
			ClearEvents ();
		}

		internal bool ProcPropertyChanged<T> (ref T currentValue, T newValue, [CallerMemberName] string propertyName = "")
		{
			return PropertyChanged.SetProperty (this, ref currentValue, newValue, propertyName);
		}
		internal void ProcPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke (this, new PropertyChangedEventArgs (propertyName));
		}


		public virtual void ClearEvents()
		{
			var invocation = PropertyChanged?.GetInvocationList () ?? new Delegate[0];
			foreach (var p in invocation)
				PropertyChanged -= (PropertyChangedEventHandler)p;
		}
	}
}

