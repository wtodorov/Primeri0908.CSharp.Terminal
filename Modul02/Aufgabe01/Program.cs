using System;

namespace Aufgabe01
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[] row = {"портокали","банани","лимони"};
			var r = new Random();
			int a1 = r.Next(0,3);
			int a2 = r.Next(0,3);
			int a3 = r.Next(0,3);
			Console.WriteLine(row[a1]+" "+row[a2]+" "+row[a3]); 
		}
	}
}
