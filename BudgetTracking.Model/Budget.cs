using System.Xml.Serialization;

[Serializable]
public class Budget
{
	public string? Description { get; set; }
	public int Money { get; set; }
	[XmlIgnore] // Ignore `DateOnly` property for XML serialization
	public DateOnly Date { get; set; }

	[XmlElement("Date")]
	public string DateString
	{
		get => Date.ToString("yyyy-MM-dd");
		set => Date = DateOnly.Parse(value);
	}
	public string? PersonName {  get; set; }

	public BudgetCurrency Currency { get; set; }
}

public enum BudgetCurrency
{
	Dolar,
	Euro,
	Hryvnia,
	Feather,
	Bones,
	Gold
}