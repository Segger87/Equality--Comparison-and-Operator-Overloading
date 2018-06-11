using System;
using System.Collections.Generic;
using System.Linq;

namespace DuckDictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			var barry = new Duck("Barry", "Pond Duck", 599, 20);
			var beastModeBarry = new Duck("Beastmode Barry", "Pond Duck on Roids", 9000, 12);
			var barriette = new Duck("Barriette", "Mallard", 99, 30);
			var barrietalina = new Duck("Barietalina", "Mallard", 150, 17);

			var duckDict = new Dictionary<Duck, int>();
			var duckList = new List<Duck>
			{
				barry,
				beastModeBarry,
				barriette,
				barrietalina
			};

			//unordered ducklist 
			foreach (var duck in duckList)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(duck.ToString());
			}

			//SortByAge class has a method that sorts the ducks by their age - youngest to oldest( can use .Reverse to order from oldest to youngest)
			SortByAge sortByAge = new SortByAge();
			duckList.Sort(sortByAge);
			
			Console.ResetColor();
			Console.WriteLine("========================================");
			Console.WriteLine("List Of Ducks Ordered By Age");
			Console.WriteLine("========================================");

			//displays a list of ducks ordered by age from oldest to youngest
			foreach (var duck in duckList)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine(duck.ToString());
			}

			SortByWeight sortByWeight = new SortByWeight();
			duckList.Sort(sortByWeight);

			Console.ResetColor();
			Console.WriteLine("========================================");
			Console.WriteLine("List of Ducks Ordered By Weight");
			Console.WriteLine("========================================");

			foreach (var duck in duckList)
			{
				Console.ForegroundColor = ConsoleColor.DarkYellow;
				Console.WriteLine(duck.ToString());
			}

			duckDict = duckList.ToDictionary(d => d, d => d.Name.GetHashCode());

			Console.ResetColor();
			Console.WriteLine("========================================");
			Console.WriteLine("Dictionary of Ducks Ordered By Name");
			Console.WriteLine("========================================");
			
			//Dictionary of ducks
			foreach (var duck in duckDict.OrderBy(d => d.Value))
			{
				Console.WriteLine(duck);
			}

			//checking overridden Equals
			Console.WriteLine(barry.Equals(barriette));
			Console.WriteLine(beastModeBarry.Equals(beastModeBarry));
			Console.WriteLine(barry.Equals(barrietalina));

			Console.ReadLine();
		}
	}
}
