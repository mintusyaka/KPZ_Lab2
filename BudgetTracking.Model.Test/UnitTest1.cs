using BudgetTracking.Model;
using BudgetTracking.Model.Serialization;

namespace BudgetTracking.Model.Test
{
	public class UnitTest1
	{
		[Fact]
		public void SerializeTest()
		{
			DataModel model = new DataModel();

			model.Budgets = new List<Budget>() {
				new Budget() {
					Date = new DateOnly(2006, 11, 12),
					Description = "Shop",
					Money = -10,
					PersonName = "Oleg"
				}
			};

			DataSerializer.SerializeData(@"G:\budgettracking.xml", model);

		}

		[Fact]
		public void DeserializeTest()
		{
			DataModel model = DataSerializer.DeserializeData(@"G:\budgettracking.xml");

		}
	}
}