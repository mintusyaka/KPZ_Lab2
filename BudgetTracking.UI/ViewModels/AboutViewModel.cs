using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.UI.ViewModels
{
	public class AboutViewModel : ViewModelBase
	{
		private string _author;
		public string Author
		{
			get { return _author; }
			set
			{
				_author = value;
				OnPropertyChanged("Author");
			}
		}

		private string _description;
		public string Description
		{
			get { return _description; }
			set
			{
				_description = value;
				OnPropertyChanged("Description");
			}
		}

		private int _favNumber;
		public int FavouriteNumber
		{
			get { return _favNumber; }
			set
			{
				_favNumber = value;
				OnPropertyChanged("FavouriteNumber");
			}
		}


	}
}
