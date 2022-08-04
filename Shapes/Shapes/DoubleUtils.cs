using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class DoubleUtils
    {
		public static void Swap(ref double a, ref double b)
		{
			double temp = a;
			a = b;
			b = temp;
		}
	}
}
