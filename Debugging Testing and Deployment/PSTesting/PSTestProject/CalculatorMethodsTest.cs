using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PSClassLibrary;

namespace PSTestProject
{
	[TestClass]
	public class CalculatorMethodsTest
	{


		[TestMethod]
		public void ShouldAddTwoNumbers()
		{
			const float expectedResult = 4;
			const float xValue = 2;
			const float yValue = 2;

			float answer = CalculatorMethods.Add(xValue, yValue);

			Assert.AreEqual(expectedResult, answer);

		}

		[TestMethod]
		public void ShouldSubtractTwoNumbers()
		{
			const float expectedResult = 3;
			const float xValue = 5;
			const float yValue = 2;

			float answer = CalculatorMethods.Subtract(xValue, yValue);

			Assert.AreEqual(expectedResult, answer);

		}

		[TestMethod]
		public void ShouldMultiplyTwoNumbers()
		{
			const float expectedResult = 10;
			const float xValue = 5;
			const float yValue = 2;

			float answer = CalculatorMethods.Multiply(xValue, yValue);

			Assert.AreEqual(expectedResult, answer);

		}

		[TestMethod]
		public void ShouldDivideTwoNumbersByZero()
		{
			const float expectedResult = 0;
			const float xValue = 10;
			const float yValue = 0;

			float answer = CalculatorMethods.Divide(xValue, yValue);

			Assert.AreEqual(expectedResult, answer);

		}

		[TestMethod]
		public void ShimsTest()
		{
			using (ShimsContext.Create())
			{
				PSClassLibrary.Fakes.ShimCalculatorMethods.AddSingleSingle = (x, y) =>
				{
					return 5;
				};

				const float expectedResult = 5;
				const float xValue = 2;
				const float yValue = 2;

				float answer = CalculatorMethods.Add(xValue, yValue);

				Assert.AreEqual(expectedResult, answer);
			}
		}
	}
}