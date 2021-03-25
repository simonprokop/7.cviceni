using System;
using System.Collections.Generic;
using System.Text;

namespace _7.cviceni
{
	abstract class Object2D : I2D, IComparable
	{

		abstract public double Area();

		public int CompareTo(object obj)
		{
			if (((Object2D)obj).Area() > this.Area())
			{
				return 1;
			}
			else { return 0; }
		}

	}
}
