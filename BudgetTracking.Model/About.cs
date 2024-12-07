using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetTracking.Model
{
	[Serializable]
	public class About
	{
		public string Author{ get; set; }
		public string Description { get; set; }
		public int FavouriteNumber { get; set; }
	}
}
