using System;
using System.Collections.Generic;
using System.Text;

namespace _7.cviceni
{
	class Rectangle : Object2D
	{
		public double A { get; protected set; }
		public double B { get; protected set; }
		public int Number { get; protected set; }
		public Rectangle (double sideA, double sideB, int number)
		{
			A = sideA;
			B = sideB;
			Number = number;

			if(A<=0 || B<+0)
			{
				throw new Exception("Wrong size of sides, please override them.");

			}
		}
		public override double Area()
		{
			return A * B;
		}
		public override string ToString()
		{
			return String.Format("Area of Rectangle {1}: {0}", Area(), Number);
		}
	}
}
