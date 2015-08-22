using System;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{

// Дефиниране на променливи
			int a=15;
			int b = 10;
			int sum = 0;
// Събиране на числа
			sum=a+b;
				
// Писане в конзолата
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
