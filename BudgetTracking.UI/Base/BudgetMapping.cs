using AutoMapper;
using BudgetTracking.Model;
using BudgetTracking.UI.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.UI.Base
{
	public class BudgetMapping : Profile
	{
		public BudgetMapping()
		{
			CreateMap<Budget, BudgetViewModel>();
			CreateMap<BudgetViewModel, Budget>();
		}
	}
}
