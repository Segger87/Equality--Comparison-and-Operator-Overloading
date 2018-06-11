using System.Collections.Generic;

namespace DuckDictionary
{
	class SortByWeight : IComparer<Duck>
	{
		//this Compare method is ordering Ducks by their Weight.
		public int Compare(Duck x, Duck y)
		{
			return x.WeightInGrams.CompareTo(y.WeightInGrams);
		}
	}
}
