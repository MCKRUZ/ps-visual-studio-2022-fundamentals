using System;
using System.Collections.Generic;
using System.Text;

namespace SharedProject1
{
	public static class SharedClass
	{
		public static float Add(float x, float y)
		{
			return x + y;
		}

#if NET6_0

#else

#endif
	}
}
