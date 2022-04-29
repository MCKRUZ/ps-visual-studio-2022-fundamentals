namespace MyFirstClassLibrary
{
	public static class CalculatorMethods
	{
		public static float Add(float x, float y)
		{
			return x + y;
		}

		public static float Subtract(float x, float y)
		{
			return x - y;
		}

		public static float Multiply(float x, float y)
		{
			return x * y;
		}

		public static float Divide(float x, float y)
		{
			if (y == 0)
				return 0;
			else
				return x / y;
		}

	}
}
