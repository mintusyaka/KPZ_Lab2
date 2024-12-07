using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BudgetTracking.UI.ViewModels
{
	public class BudgetViewModel : ViewModelBase
	{
		private string? _Description;
		public string? Description 
		{ get
			{
				return _Description;
			}
		set
			{
				_Description = value;
				OnPropertyChanged("Description");
			}
		}

		private int _Money;
		public int Money
		{
			get
			{
				return _Money;
			}
			set
			{
				_Money = value;
				OnPropertyChanged("Money");
			}
		}

		private DateOnly _Date;
		
		[XmlIgnore] // Ignore `DateOnly` property for XML serialization
		public DateOnly Date
		{
			get
			{
				return _Date;
			}
			set
			{
				_Date = value;
				OnPropertyChanged("Date");
			}
		}

		[XmlElement("Date")]
		public string DateString
		{
			get => Date.ToString("yyyy-MM-dd");
			set => Date = DateOnly.Parse(value);
		}

		private string? _PersonName;
		public string? PersonName
		{
			get
			{
				return _PersonName;
			}
			set
			{
				_PersonName = value;
				OnPropertyChanged("PersonName");
			}
		}

		private BudgetCurrency _Currency;
		public BudgetCurrency Currency
		{
			get
			{
				return _Currency;
			}
			set
			{
				_Currency = value;
				OnPropertyChanged("Currency");
			}
		}
	}
}
