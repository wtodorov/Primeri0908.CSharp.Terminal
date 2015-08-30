using System;

namespace Aufgabe02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			string[,] shah = new String[3,3]; 
			shah[1,1] = "X"; 
			Console.WriteLine(shah[1,1]); 
		}
	}
}
