using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

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
		private string _gotCalled="";
		public string GotCalled
		{
			get
			{
				return _gotCalled;
			}
			set
			{Debug.WriteLine("here it is");
				if (_gotCalled != value)
				{
					_gotCalled = value;
					OnPropertyChanged("GotCalled");

				}
			}
		}

		public ICommand CheckCommand
		{
			get
			{
				return new Command(ChCommand);
			}
		}
	    void ChCommand()
		{
			Debug.WriteLine("check it is");
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
			//GotCalled="yes";
		}
	}
}

