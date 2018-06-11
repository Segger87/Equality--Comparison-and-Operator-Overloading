using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
		public override string ToString()
		{
			return $"Name = {Name}, Type = {Type} Weight in Grams = {WeightInGrams} Age in Months = {AgeInMonths}";
		}
	}

}
