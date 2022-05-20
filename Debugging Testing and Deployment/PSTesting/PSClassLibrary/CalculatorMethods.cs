namespace PSClassLibrary
{
	public static class CalculatorMethods
	{
		public static float Add(float x, float y)
		{
			Console.WriteLine("Adding {0} plus {1}", x, y);
			return x + y;
		}

		public static float Subtract(float x, float y)
		{
			Console.WriteLine("Subtracting {0} minus {1}", x, y);
			return x - y;
		}

		public static float Multiply(float x, float y)
		{
			Console.WriteLine("Multiplying {0} times {1}", x, y);
			return x * y;
		}

		public static float Divide(float x, float y)
		{
			Console.WriteLine("Dividing {0} divided by {1}", x, y);
			if (y != 0)
			{
				return x / y;
			}
			else
			{
				return 0;
			}
		}

	}
}