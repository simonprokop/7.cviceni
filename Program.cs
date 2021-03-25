using System;
using System.Linq;
using System.Collections.Generic;

namespace _7.cviceni
{
	class Program
	{
		private static IEnumerable<int> itemInField;

		static void Main(string[] args)
		{

			//Fields

			int[] intField = new int[] { 1, 2, 3, 5, 7, 9, 26, 51, -10, -25, 0, 256, 15351, 39786, -3652 };
			string[] stringField = new string[] { "Alpha", "Beta", "Gamma", "Delta", "Epsilon", "Lambda", "Kappa" };

			Object2D[] objectField = new Object2D[]
			{
				new Circle (radius: 5, number: 1),
				new Square (sideA: 10, number: 2),
				new Triangle (sideA: 5, sideB: 6, sideC: 8, number: 3),
				new Rectangle (sideA: 5, sideB: 9, number: 4)
			};

			Circle[] circleField = new Circle[]
			{
				new Circle(radius: 4, number: 1),
				new Circle(radius: 8, number: 2),
				new Circle(radius: 12, number: 3)
			};

			Square[] squareField = new Square[]
			{
				new Square(sideA: 5, number: 1),
				new Square(sideA: 7, number: 2),
				new Square(sideA: 12, number: 3)
			};

			Triangle[] triangleField = new Triangle[]
			{
				new Triangle(sideA: 5, sideB: 5, sideC: 7, number: 1),
				new Triangle(sideA: 7, sideB: 2, sideC: 8, number: 2),
				new Triangle(sideA: 12, sideB: 20, sideC: 9, number: 3)};

			Rectangle[] rectangleField = new Rectangle[]
			{

				new Rectangle(sideA: 4, sideB: 10, number: 1),
				new Rectangle(sideA: 5, sideB: 12, number: 2),
				new Rectangle(sideA: 7, sideB: 9, number: 3)

			};

			Ellipse[] ellipseField = new Ellipse[]
			{
				new Ellipse(lenghtA: 5, lengthB: 10, number: 1),
				new Ellipse(lenghtA: 10, lengthB: 15, number: 2),
				new Ellipse(lenghtA: 17, lengthB: 25, number: 3),

			};


			//Areas of shapes - CompareTo - The Largest

			Console.WriteLine("THe biggest areas of Shapes:" + "\n");


			string O = Extremes.Largest(objectField).ToString();
			Console.WriteLine("Largest of the Objects: " + O);

			string C = Extremes.Largest(circleField).ToString();
			Console.WriteLine("Largest of the Circles: " + C);

			string S = Extremes.Largest(squareField).ToString();
			Console.WriteLine("Largest of the Squares: " + S);

			string T = Extremes.Largest(triangleField).ToString();
			Console.WriteLine("Largest of the Triangles: " + T);


			string R = Extremes.Largest(rectangleField).ToString();
			Console.WriteLine("Largest of the Rectangles: " + R);

			string E = Extremes.Largest(ellipseField).ToString();
			Console.WriteLine("Largest of the Ellipses" + E);



			//filtering by LINQ
			Console.WriteLine("\nFiltered items from intField by LINQ: \n");

			IEnumerable<int> filterLINQ = itemInField
				.Where(v => v > 4 && v < 8)
				.OrderByDescending(v => v);


			/*from itemInField in intField
									 where itemInField > 4 && itemInField < 8 
									 orderby intField
									 descending select itemInField;*/

			foreach (int itemInField in filterLINQ)
			{

				Console.WriteLine(itemInField);
			}

			Console.ReadLine();
		}



	}





}




