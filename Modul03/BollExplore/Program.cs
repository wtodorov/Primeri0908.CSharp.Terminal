	using System;

namespace BollExplore
{
	class MainClass
	{
		public static void Main (string[] args)
		{

     		int[] _i = new int[] { 4 , 3 , 2 };
			int _ui = 0; //Convert.ToInt32(Console.ReadLine());
			string _input = "0";

			Console.Write ("Моля въведете индекс:");
			_input = Console.ReadLine () ;

			bool _check01 = int.TryParse (_input, out _ui);

//			_ui = (_ui <= _i.Length) ? _ui : 3;
//				_ui = (_ui> 0) ?_ui : 1;	

			switch (_ui) {
			case 1:
				{
					Console.Write ("1-ви елемент от масива: ");
					Console.WriteLine (_i [_ui - 1]);
					break; 
				}
			case 2 :
				{
					Console.Write ("2-ри елемент от масива: ");
					Console.WriteLine (_i [_ui - 1]);
					break;
				}
			case 3:
				{
					Console.Write ("3-ти елемент от масива: ");
					Console.WriteLine (_i [_ui - 1]);
					break;
				}
			default :
				{
					Console.Write ("В масива няма елемент със стойнос за този индекс.\nОпитайте с индекс между 1 и3.\n\n\n ");
					break;
				}
			}
//			if (_check01 && _check02 && _check03) {
//				Console.WriteLine (_i [_ui - 1]);
//			}
//
//			if (!_check01){
//				Console.WriteLine ("Индекса трябва да бъде цяло число\n\n\n");
//			}
//
//			if (!_check02) {
//				Console.WriteLine ("Индекса е прекалено голям\n\n\n"); 
//			}
//
//			if (!_check03 && _check01) {
//				Console.WriteLine ("Индекса е прекалено малък\n\n\n"); 
//			}
//


		}
	}
} 

	

