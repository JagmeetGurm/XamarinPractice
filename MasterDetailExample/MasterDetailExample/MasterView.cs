using System;
using Xamarin.Forms;

namespace MasterDetailExample
{
	public  class MasterView: MasterDetailPage
	{
		public void NavigationToPage(Page page)
		{
			Detail = new NavigationPage(page);
			AppNavigation.nav = Detail.Navigation;
			IsPresented = false;
		}
		public  MasterView()
		{
		}
	}
}

