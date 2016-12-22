using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MasterDetailExample
{
	public partial class ReminderPage : ContentPage
	{
		public ReminderPage()
		{
			InitializeComponent();

		}
		public  void NextPage(object sender, EventArgs e)
		{
			var temp = new ReminderPageNext();
			AppNavigation.nav.PushAsync(temp);
		}
	}
}

