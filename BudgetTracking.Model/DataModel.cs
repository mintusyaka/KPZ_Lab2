using BudgetTracking.Model.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.Model
{
	public class DataModel
	{
		public static string DataPath = @"G:\budgettracking.xml";
		public List<Budget> Budgets { get; set; }
		public List<About> Abouts { get; set; }

		public static DataModel Load()
		{
			if(File.Exists(DataPath))
			{
				return DataSerializer.DeserializeData(DataPath);
			}
			return new DataModel()
			{
				Budgets = new List<Budget>() {
					new Budget() {
						Date = new DateOnly(2005, 10, 1),
						Description = "Birthday",
						Money = 0,
						PersonName = "Stas",
						Currency = BudgetCurrency.Hryvnia
					}
				},

				Abouts = new List<About>()
				{
					new About()
					{
						Author = "Stanislav",
						Description = "Just a student",
						FavouriteNumber = 3
					}
				}
			};
		}

		public void Save()
		{
			DataSerializer.SerializeData(DataPath, this);
		}
	}
}
