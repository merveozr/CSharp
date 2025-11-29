using System;
					
namespace welcome
{
	class Program
	{
		static float RectangleArea(float width, float height=10)
		{
			float area= width * height;
			return area;
		}
		
		static void Main(string[] args)	
		{
			float area = RectangleArea(height:1.2f, width:2.5f);
			Console.WriteLine(area);
		}
	}
	
}