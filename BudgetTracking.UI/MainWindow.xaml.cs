using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BudgetTracking.UI.ViewModels;
using BudgetTracking.UI.Convertors;

namespace BudgetTracking.UI
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}
		private void DataGrid_AutoGeneratingColumn(object sender, DataGridAutoGeneratingColumnEventArgs e)
		{
			
		}

		/*private void makeDolareOnClick(object sender, RoutedEventArgs e)
		{
			var budget = (BudgetViewModel)dataGridBudgets.SelectedItem;
			budget.Currency = BudgetCurrency.Dolar;
		}*/
	}
}