using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BudgetTracking.UI.Views
{
	/// <summary>
	/// Interaction logic for BudgetUserControl.xaml
	/// </summary>
	public partial class BudgetUserControl : UserControl
	{
		public BudgetUserControl()
		{
			InitializeComponent();
		}


		private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
		{
			// Check the column header name and cancel the columns you don’t want to display
			if (e.PropertyName == "DateString")
			{
				e.Cancel = true; // This prevents the column from being generated
			}
		}

		private void Money_TextChanged(object sender, TextCompositionEventArgs e)
		{
			e.Handled = !IsNumber(e.Text);
		}

		private bool IsNumber(string text)
		{
			return	int.TryParse(text, out var number);
		}
	}
}
