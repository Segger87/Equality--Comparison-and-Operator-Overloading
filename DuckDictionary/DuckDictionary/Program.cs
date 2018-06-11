using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			var duckList = new List<Duck>();

			duckList.Add(barry);
			duckList.Add(beastModeBarry);
			duckList.Add(barriette);
			duckList.Add(barrietalina);

			//unordered ducklist 
			foreach (var item in duckList)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine(item.ToString());
			}

			//Duck class implements Icomparable interface which has a compareTo method which compares on the ducks age
			duckList.Sort();
			duckList.Reverse();

			Console.ResetColor();
			Console.WriteLine("========================================");
			Console.WriteLine("Ordered By Age");
			Console.WriteLine("========================================");

			//displays a list of ducks ordered by age from oldest to youngest
			foreach (var duck in duckList)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine(duck.ToString());
			}

			duckDict.Add(barry, barry.WeightInGrams);
			duckDict.Add(beastModeBarry, beastModeBarry.WeightInGrams);
			duckDict.Add(barriette, barriette.WeightInGrams);
			duckDict.Add(barrietalina, barrietalina.WeightInGrams);

			//foreach (var duck in duckDict)
			//{
			//	Console.WriteLine(duck.ToString());
			//}
			Console.ReadLine();
		}
	}
}
