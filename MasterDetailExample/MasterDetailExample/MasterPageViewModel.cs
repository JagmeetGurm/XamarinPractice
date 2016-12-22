using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace MasterDetailExample
{
	public class MasterPageViewModel:INotifyPropertyChanged
	{
		private List<MasterPageItem> _masterPageItems;

		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
		}

		public List<MasterPageItem> MasterPageItems
		{
			get { return _masterPageItems;}
			set
			{
				if (_masterPageItems != value)
				{
					_masterPageItems=value;
					OnPropertyChanged("MasterPageItems");
				}
			}	
		}
		public void GetList()
		{
			MasterPageItems
		   = new List<MasterPageItem>();
			MasterPageItems.Add(new MasterPageItem
			{
				Title = "Contacts",
				IconSource = "contacts.png",
				TargetType = typeof(ContactsPage)
			});
			MasterPageItems.Add(new MasterPageItem
			{
				Title = "TodoList",
				IconSource = "todo.png",
				TargetType = typeof(ToDoListPage)
			});
			MasterPageItems.Add(new MasterPageItem
			{
				Title = "Reminders",
				IconSource = "reminders.png",
				TargetType = typeof(ReminderPage)
			});

		}
		public MasterPageViewModel()
		{
			GetList();
		}
	}
}

