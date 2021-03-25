using System;
using System.Collections.Generic;
using System.Text;

namespace _7.cviceni
{
	class Ellipse : Object2D
	{
		public double A { get; protected set; }
		public double B { get; protected set; }
		public int Number { get; protected set; }
		public Ellipse(double lenghtA, double lengthB, int number)
		{
			A = lenghtA;
			B = lengthB;
			Number = number;

			if(A <=0 || B <= 0)
			{

				throw new Exception("Wrong size of lengths, please override them.");
			}
		}
		public override double Area()
		{
			return Math.PI * A * B;
		}

		public override string ToString()
		{
			return String.Format("Area of Ellipse {1}: {0}", Area(), Number);
		}
	}
}
