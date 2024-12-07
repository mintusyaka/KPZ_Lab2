using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace BudgetTracking.Model.Serialization
{
	public class DataSerializer
	{
		public static void SerializeData(string filename, DataModel data)
		{
			var serializer = new XmlSerializer(typeof(DataModel));
			var s = new FileStream(filename, FileMode.Create);
			serializer.Serialize(s, data);
			s.Close();
		}

		public static DataModel? DeserializeData(string filename)
		{
			var serializer = new XmlSerializer(typeof(DataModel));
			var s = new FileStream(filename, FileMode.Open);
			return (DataModel?)serializer.Deserialize(s);
		}
	}
}
