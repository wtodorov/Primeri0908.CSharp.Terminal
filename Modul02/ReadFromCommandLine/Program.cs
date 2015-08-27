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
			string test = "1";
			test += ",2 ";
			test += ",3 ";
			test += ",4 ";
			test += ",5 ";
			Console.WriteLine ("Събиране с += : " + test + "\n");
			test = test.Replace (",", ";");
			Console.WriteLine ("Работа с Replace : " + test + "\n");
			// да видя третия знак
			Console.WriteLine ("3-ти знак : " + test.Split (';') [2]);
		}
	}
}
