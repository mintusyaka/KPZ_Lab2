using AutoMapper;
using BudgetTracking.Model;
using BudgetTracking.UI.ViewModels;
using BudgetTracking.UI.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.UI.Base
{
	public class AboutMapping : Profile
	{
		public AboutMapping() {
			CreateMap<About, AboutViewModel>();
			CreateMap<AboutViewModel, About>();
		}
	}
}
