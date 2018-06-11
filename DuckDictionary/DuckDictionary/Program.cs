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
			var barry = new Duck("Barry", "Pond Duck", 20, 599);

			Console.WriteLine(barry.ToString());
			Console.ReadLine();
		}
	}


}
