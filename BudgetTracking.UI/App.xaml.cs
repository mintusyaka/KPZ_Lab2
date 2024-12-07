using System.Configuration;
using System.Data;
using System.Windows;
using AutoMapper;
using BudgetTracking.Model;
using BudgetTracking.UI.ViewModels;
using BudgetTracking.UI.Base;

namespace BudgetTracking.UI
{
	/// <summary>
	/// Interaction logic for App.xaml
	/// </summary>
	public partial class App : Application
	{
		DataModel _model;
		DataViewModel _viewModel;
		public static IMapper mapper { get; private set; }
		public App()
		{
			


			_model = DataModel.Load();

			

			var config = new MapperConfiguration(cfg =>
			{
				cfg.AddProfile<DataModelMapping>();
				cfg.AddProfile<BudgetMapping>();
				cfg.AddProfile<AboutMapping>();
			});

			mapper = config.CreateMapper();
			_viewModel = mapper.Map<DataModel, DataViewModel>(_model);



			var window = new MainWindow() { DataContext = _viewModel };
			window.Show();
		}

		protected override void OnExit(ExitEventArgs e)
		{
			try
			{
				_model = mapper.Map<DataViewModel, DataModel>(_viewModel);
				_model.Save();
			}
			catch (Exception ex)
			{
				base.OnExit(e);
				throw;
			}
		}
	}

}
