using System;
using System.Collections.Generic;
using System.Text;

namespace _7.cviceni
{
	class Square : Object2D
	{
		public double A { get; protected set; }
		public int Number { get; protected set; }
		public Square(double sideA, int number)
		{
			A = sideA;
			Number = number;
			if (sideA <= 0) { throw new Exception("Wrong size of Square, please override them."); }

		}
		public override double Area()
		{
			return 6.0 * A * A ;
		}

		public override string ToString()
		{
			return String.Format("Area of Square {1}: {0}", Area(), Number);
		}
	}
}
