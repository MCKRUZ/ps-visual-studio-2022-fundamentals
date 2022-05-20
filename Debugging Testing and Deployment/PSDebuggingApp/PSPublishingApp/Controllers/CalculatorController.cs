using Microsoft.AspNetCore.Mvc;

namespace PSPublishingApp.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CalculatorController : ControllerBase
	{
		[HttpPost]
		[Route("Add")]
		public float Add(Equation equation)
		{
			equation.Answer = equation.XValue + equation.YValue;
			return equation.Answer;
		}

		[HttpPost]
		[Route("Subtract")]
		public float Subtract(Equation equation)
		{
			equation.Answer = equation.XValue - equation.YValue;
			return equation.Answer;
		}
		[HttpPost]
		[Route("Multiply")]
		public float Multiply(Equation equation)
		{
			equation.Answer = equation.XValue * equation.YValue;
			return equation.Answer;
		}
		[HttpPost]
		[Route("Divide")]
		public float Divide(Equation equation)
		{
			if (equation.YValue != 0)
			{
				return equation.XValue / equation.YValue;
			}
			else
			{
				return 0;
			}
		}
	}
}
