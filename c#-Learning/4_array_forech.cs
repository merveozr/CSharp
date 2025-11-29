using System;
					
namespace welcome
{
	class Program
	{
		static void Main(string[] args)
		{
			// single dimentional arrays
		
			int[] arr1= new int[5];
			arr1[0]=1;
			arr1[1]=2;
			
			int[] arr2 = new int[5] {1, 2, 3, 4, 5};
			
			int[] arr3 = new int[] {1, 2, 3};
			 
			// Multi dimentional arrays
			
			int[,] arr4 = new int[2, 3]{{1, 2, 3},{4, 5, 6}};
			int[,] arr5 = new int[,]{{1},{2},{3}};
			
			int[,] arr6 = new int[2,2];
			arr6[0,0] =1;
			arr6[0,1] = 2;
			
			// Array of arrays (jagged array)
			int[][] arr7 = new int[3][];
			arr7[0] = new int[1] { 4 };
			arr7[1] = new int[3] {1, 2, 3};
			arr7[2] =new int[2] {7, 7};
			
			foreach (int item in arr1)
			{
				Console.WriteLine(item);
			}
			foreach (int[] satir in arr7)
			{
				foreach (int eleman in satir)
				{
					Console.Write("{0},",eleman);
				}
				Console.WriteLine();
			}
		}
	}
	
}