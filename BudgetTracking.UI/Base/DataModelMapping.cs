using AutoMapper;
using BudgetTracking.Model;
using BudgetTracking.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace BudgetTracking.UI.Base
{
	public class DataModelMapping : Profile
	{
		public DataModelMapping()
		{
			CreateMap<DataModel, DataViewModel>();
			CreateMap<DataViewModel, DataModel>();
		}
	}
}
