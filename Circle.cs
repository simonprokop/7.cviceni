using System;
using System.Collections.Generic;
using System.Text;

namespace _7.cviceni
{
	class Circle : Object2D
	{
		public double Radius { get; protected set; }
		public int Number { get; protected set; }
	
		public Circle (double radius, int number)
		{
			Radius = radius;
			Number = number;

			if (radius <= 0)
			{
				throw new Exception("Wrong size of circle, please override value of radius.");

			}

		}
		public override double Area()
		{
			return Math.PI * Radius * Radius;
		}

		public override string ToString()
		{
			return String.Format ("Area of Circle {1}: {0}", Area(), Number);
		}

	}
}
