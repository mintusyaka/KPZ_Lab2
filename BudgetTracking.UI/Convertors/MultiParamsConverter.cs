using BudgetTracking.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BudgetTracking.UI.Convertors
{
	public class MultiParamsConverter : IMultiValueConverter
	{
		public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
		{
			int money = 0;
			if (int.TryParse(values[1].ToString(), out money)
				&& IsValidDateFormat(values[2].ToString())
				&& IsCurrency(values[4].ToString()))
			{
				return new AddNewRowParameters()
				{
					Description = values[0].ToString(),
					Money = money,
					Date = DateOnly.Parse(values[2].ToString()),
					PersonName = values[3].ToString(),
					Currency = GetCurrency(values[4].ToString())
				};
			}
			return null;
		}

		public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}

		private bool IsValidDateFormat(string date)
		{
			// Specify the format you expect
			string format = "yyyy-MM-dd";

			// Try to parse the date string with the specified format
			DateTime parsedDate;
			bool isValid = DateTime.TryParseExact(date, format, CultureInfo.InvariantCulture, DateTimeStyles.None, out parsedDate);

			return isValid;
		}

		private bool IsCurrency(string currency)
		{
			if (currency.Equals(BudgetCurrency.Euro.ToString())
				|| currency.Equals(BudgetCurrency.Dolar.ToString())
				|| currency.Equals(BudgetCurrency.Hryvnia.ToString())
				|| currency.Equals(BudgetCurrency.Feather.ToString())
				|| currency.Equals(BudgetCurrency.Gold.ToString())
				|| currency.Equals(BudgetCurrency.Bones.ToString())
				)
			{
				return true;
			}
			return false;
		}

		private BudgetCurrency GetCurrency(string currency)
		{
			switch(currency)
			{
				case "Dolar": return BudgetCurrency.Dolar;
				case "Euro": return BudgetCurrency.Euro;
				case "Hryvnia": return BudgetCurrency.Hryvnia;
				case "Feather": return BudgetCurrency.Feather;
				case "Gold": return BudgetCurrency.Gold;
				case "Bones": return BudgetCurrency.Bones;
			}
			throw new Exception("Bad Currency");
		}
	}
}
