using System;
					
namespace welcome
{
	class Program
	{
		static int Add(int x, int y)
		{
			int sum =x+y;
			return sum;
		}
		static void Main(string[] args)
		{
			int a=5, b=7;
			int result = Add(a, b);
			Console.WriteLine(result);
		}
	}
	
}