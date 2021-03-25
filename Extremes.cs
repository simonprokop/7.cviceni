using System;
using System.Collections.Generic;
using System.Text;

namespace _7.cviceni
{
	class Extremes
	{
		public static T Largest<T>(T[] values) where T : IComparable
		{
			T Max = values[0];

			for (int i = 1; i < values.Length; i++)
			{
				if(values[i].CompareTo(Max) > 0)
				{
					Max = values[i];
				}

			}
				return Max;
		}

		public static T Smallest<T>(T[] values) where T : IComparable
		{
			T Min = values[0];

			for (int i = 1; i < values.Length; i++)
			{
				if (values[i].CompareTo(Min) < 0)
				{
					Min = values[i];
				}

			}
			return Min;
		}

	}
}

