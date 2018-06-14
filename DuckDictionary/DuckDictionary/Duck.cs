namespace DuckDictionary
{
	public class Duck
	{
		public string Name { get; }
		public string Type { get; }
		public int WeightInGrams { get; }
		public int AgeInMonths { get; }

		public Duck(string name, string type, int weightInGrams, int ageInMonths)
		{
			Name = name;
			Type = type;
			WeightInGrams = weightInGrams;
			AgeInMonths = ageInMonths;
		}

		public override bool Equals(object obj)
		{
			if (obj is null) return false;
			if (ReferenceEquals(this, obj)) return true;
			if (obj.GetType() != GetType()) return false;
			return Equals((Duck)obj);
		}

		public bool Equals(Duck other)
		{
			return Name == other.Name &&
				Type == other.Type &&
				WeightInGrams == other.WeightInGrams &&
				AgeInMonths == other.AgeInMonths;
		}

		public override int GetHashCode()
		{
			int hash = Name.GetHashCode();
			hash = (hash * 31) + AgeInMonths.GetHashCode();
			return hash;
		}

		public override string ToString()
		{
			return $"Name: {Name}, Type: {Type}, Weight in Grams: {WeightInGrams}, Age in Months: {AgeInMonths}";
		}
	}

}
