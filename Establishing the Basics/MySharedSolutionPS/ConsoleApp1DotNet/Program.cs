using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1DotNet
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Addition
			var x = 1;
			var y = 2;
			var result = SharedProject1.SharedClass.Add(x, y);
			Console.WriteLine(x + " plus " + y + " Equals " + result);
		}
	}
}
