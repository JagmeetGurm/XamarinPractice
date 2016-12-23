using System;
using System.Collections.Generic;

using Xamarin.Forms;


namespace MasterDetailExample
{
	public partial class MainPage : MasterDetailPage
	{
		public MainPage()
		{
			InitializeComponent();
			masterPage.ListView.ItemSelected += OnItemSelected;
			this.BindingContext = new MainPageViewModel();

		}
		void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
		{
			var item = e.SelectedItem as MasterPageItem;

			if (item != null)
			{
				Detail= new NavigationPage((Page)Activator.CreateInstance(item.TargetType));

				AppNavigation.nav= Detail.Navigation;
				masterPage.ListView.SelectedItem = null;
				IsPresented = false;
			}
		}
	}
}

