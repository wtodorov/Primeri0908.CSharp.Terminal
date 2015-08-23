using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{

// Дефиниране на променливи
			int a=10;
			int b = 5;
			int sum = 0;
			string program_name = "Модул 02 - Примери";
			string program_version = "1.0";
// Събиране на числа
			sum=a+b;
				
// Писане в конзолата
			Console.WriteLine(program_name);
			Console.WriteLine ("Версия: " + program_version + "\n\n");

			Console.Write(a);
			Console.Write(" + ");
			Console.Write(b);
			Console.Write (" = ");
			Console.WriteLine(sum);

			Console.WriteLine("\nИзползване на += ");
			a += b;
			Console.WriteLine(a);

			Console.WriteLine("\nИзползване на -= ");
			a -= b;
			Console.WriteLine(a);

			Console.WriteLine("\nИзползване на *= ");
			a *= b;
			Console.WriteLine(a);

			Console.WriteLine("\nИзползване на ++ ");
			a++;
			Console.WriteLine(a);

			a=15; b=10;

			Console.WriteLine("\nСтандартно делене");
			Console.WriteLine(a/b);

			Console.WriteLine("\nХващане на остатък");
			Console.WriteLine(a%b);
		}
	}
}
