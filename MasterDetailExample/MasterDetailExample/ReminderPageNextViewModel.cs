using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;

namespace MasterDetailExample
{
	public class ReminderPageNextViewModel:INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged(string propertyName)
		{
			if (PropertyChanged != null)
				PropertyChanged(this,
					new PropertyChangedEventArgs(propertyName));
		}
		private List<string> _getList;
		public List<string> GetList
		{
			get { return _getList;}
			set
			{
				if (_getList != value)
				{
					_getList = value;
					OnPropertyChanged("GetList");
				}

			}

		}
		private string _selectItem = "";
		public string SelectItem
		{
			get { return _selectItem;}
			set
			{ if (_selectItem != value)

				{
					_selectItem = value;
					OnPropertyChanged("SelectItem");
					Debug.WriteLine(SelectItem);
				}
			}	

		}
		public ReminderPageNextViewModel()
		{
			GetList = new List<string>();
			GetList.Add("1st element");
			GetList.Add("2nd element");
			GetList.Add("3rd element");
		}
	}
}

