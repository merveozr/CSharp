using System;
					
namespace welcome
{
	class Program
	{
		static void Main(string[] args)
		{
			string name = Console.ReadLine();
			int age= int.Parse(Console.ReadLine());
			Console.Clear();
			
			Console.WriteLine("My name is {0}\nMy age is {1}",name,age);
		}
	}
	
}