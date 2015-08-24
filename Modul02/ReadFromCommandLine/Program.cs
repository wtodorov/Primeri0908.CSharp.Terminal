using System;

namespace ReadFromCommandLine
{
	class MainClass
	{
		public static void Main (string[] args)
		{
		// дефиниране на промевливи
		int a=5, b=0;

		// въвеждане на входни параметри
		Console.Write ("Моля въведете b = ");
		b = Convert.ToInt32(Console.ReadLine());


		//печат на резултат		
			Console.WriteLine ("Резултатът a+b е :" + ( a + b ).ToString() + "\n\n\n");
		}
	}
}
