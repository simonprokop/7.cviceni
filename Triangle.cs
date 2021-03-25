using System;
using System.Collections.Generic;
using System.Text;

namespace _7.cviceni
{
	class Triangle : Object2D
	{
		public double A { get; protected set; }
		public double B { get; protected set; }
		public double C { get; protected set; }
		public int Number { get; protected set; }
		public Triangle(double sideA, double sideB, double sideC, int number)
		{
			A = sideA;
			B = sideB;
			C = sideC;
			Number = number;
		

			if (A + B <= C || B + C <= A || C + A <= B) //Triangle check
			{
				throw new Exception("Wrong size of triangle sides");
			}

		}



		public override double Area()
		{
			double S = (A + B + C) / 2;
			return Math.Sqrt(S * (S - A) * (S - B) * (S - C)); //Herron. 
		}

		public override string ToString()
		{
			return String.Format("Area of Triangle {1}: {0}", Area(), Number);

		}
	}
}
