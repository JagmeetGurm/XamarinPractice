using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetailExample
{
	public partial class ReminderPageNext : ContentPage
	{
		public ReminderPageNext()
		{
			InitializeComponent();
			this.BindingContext = new ReminderPageNextViewModel();
		}
	}
}

