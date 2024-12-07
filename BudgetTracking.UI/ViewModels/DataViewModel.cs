using Microsoft.VisualStudio.PlatformUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BudgetTracking.UI.ViewModels
{
	public class DataViewModel : ViewModelBase
	{
        public DataViewModel()
        {

			ChangeControlVisibility = new DelegateCommand<object>(SetControlVisibility);
			AddNewRowToBudgetCommand = new DelegateCommand<AddNewRowParameters>(AddNewRowToBudget);
			DeleteSelectedRowFromBudgetCommand = new DelegateCommand(DeleteSelectedRowFromBudget);

		}


		private string _visibleControl = "Budget";
		public string VisibleControl
		{
			get { return _visibleControl; }
			set
			{
				_visibleControl = value;
				OnPropertyChanged("VisibleControl");
			}
		}

		private ObservableCollection<BudgetViewModel> _Budgets;
		public ObservableCollection<BudgetViewModel> Budgets
		{

		get { return _Budgets; }
		
		set
			{
				_Budgets = value;
				OnPropertyChanged("Budgets");
			}
		}

		private ObservableCollection<AboutViewModel> _Abouts;
		public ObservableCollection<AboutViewModel> Abouts
		{

			get { return _Abouts; }

			set
			{
				_Abouts = value;
				OnPropertyChanged("Abouts");
			}
		}


		public DelegateCommand<object> ChangeControlVisibility { get; }
		private void SetControlVisibility(object visibleControl)
		{
			VisibleControl = visibleControl.ToString();
		}

		public DelegateCommand<AddNewRowParameters> AddNewRowToBudgetCommand {  get; }
		public void AddNewRowToBudget(AddNewRowParameters parameters)
		{
			if (parameters != null)
			{
				Budgets.Add(new BudgetViewModel()
				{
					Description = parameters.Description,
					Money = parameters.Money,
					Date = parameters.Date,
					PersonName = parameters.PersonName,
					Currency = parameters.Currency
				});
			}
		}

		private BudgetViewModel _selectedBudget;
		public BudgetViewModel SelectedBudget
		{
			get { return _selectedBudget; }
			set
			{
				_selectedBudget = value;
				OnPropertyChanged("SelectedBudget");
			}
		}
		public DelegateCommand DeleteSelectedRowFromBudgetCommand { get; }
		public void DeleteSelectedRowFromBudget()
		{
			Budgets.Remove(SelectedBudget);
		}
	}

	public class AddNewRowParameters
	{
		public string Description { get; set; }
		public int Money { get; set; }
		public DateOnly Date { get; set; }
		public string PersonName { get; set; }
		public BudgetCurrency Currency { get; set; }
	}
}
