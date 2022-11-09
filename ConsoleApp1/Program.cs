using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> items = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
			Func<int, bool> isEven = n => n % 2 == 0;

			List<int> EvenItems = GetEvenItems(items, isEven);
		}

		static List<int> GetEvenItems(List<int> source, Func<int, bool> func)
		{
			var result = new List<int>();

			foreach(var item in source)
			{
				if(func(item) == true)
				{
					result.Add(item);
				}
			}
			return result;
		}
	} 
}
