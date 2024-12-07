using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace BudgetTracking.UI.Convertors
{
	internal class ImagePathConverter : IValueConverter
	{
		Dictionary<BudgetCurrency, BitmapImage> cache = new Dictionary<BudgetCurrency, BitmapImage>();

		public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
		{
			var currency = (BudgetCurrency)value;

			if (!cache.ContainsKey(currency))
			{
				var uri = new Uri(string.Format(@"G:/projects/c#/KPZ_Lab2/BudgetTracking.UI/Images/Currency/{0}.png", currency), UriKind.Absolute);
				cache.Add(currency, new BitmapImage(uri));
			}

			return cache[currency];
		}

		public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
		{
			throw new NotImplementedException();
		}
	}
}
