using System;
using System.ComponentModel;
using System.Diagnostics;

namespace MasterDetailExample
{
	public class MainPageViewModel
	{
		//public event PropertyChangedEventHandler PropertyChanged;

		private int _gotCalled;
		public int GotCalled
		{
			get
			{
				return _gotCalled;
			}
			set
			{
				_gotCalled = value;
				Debug.WriteLine("it is");
			}
		}
		public MainPageViewModel()
		{
		}
	}
}

