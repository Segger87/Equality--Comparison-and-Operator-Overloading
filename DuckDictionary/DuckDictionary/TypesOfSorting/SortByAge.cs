using System.Collections.Generic;

namespace DuckDictionary
{
	class SortByAge : IComparer<Duck>
	{
		//this Compare method is ordering Ducks by their age.
		public int Compare(Duck x, Duck y)
		{
			return x.AgeInMonths.CompareTo(y.AgeInMonths);
		}
	}
}
