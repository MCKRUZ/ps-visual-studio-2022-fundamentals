// See https://aka.ms/new-console-template for more information
using PSDebuggingApp;

Console.WriteLine("Hello, World!");

// Part 1
Equation equation = new Equation()
{
	XValue = 1,
	YValue = 2,
	Answer = 0
};
//float result = 0;
equation.Answer = await APIHelper.APIPost("api/Calculator/Add", equation);
Console.WriteLine(equation.XValue + " plus " + equation.YValue + " Equals " + equation.Answer);
Console.ReadLine();

// Part 2
Random random = new Random();
var operand = new List<string> { "add", "subtract", "multiply", "divide" };
var length = 10;
int index = 0;
for (int i = 0; i < length; i++)
{
	index = random.Next(operand.Count);
	Console.WriteLine("Run number: " + i + " of " + length);
	switch (index)
	{
		case 0:
			// Reset equation
			equation.XValue = random.NextInt64(100);
			equation.YValue = random.NextInt64(100);
			equation.Answer = 0;

			// Calculate result
			equation.Answer = await APIHelper.APIPost("api/Calculator/Add", equation);
			Console.WriteLine(equation.XValue + " plus " + equation.YValue + " Equals " + equation.Answer);
			break;
		case 1:
			// Reset equation
			equation.XValue = random.NextInt64(100);
			equation.YValue = random.NextInt64(100);
			equation.Answer = 0;

			// Calculate result
			equation.Answer = await APIHelper.APIPost("api/Calculator/Subtract", equation);
			Console.WriteLine(equation.XValue + " minus " + equation.YValue + " Equals " + equation.Answer);
			break;
		case 2:
			// Reset equation
			equation.XValue = random.NextInt64(100);
			equation.YValue = random.NextInt64(100);
			equation.Answer = 0;

			// Calculate result
			equation.Answer = await APIHelper.APIPost("api/Calculator/Multiply", equation);
			Console.WriteLine(equation.XValue + " multiplied by " + equation.YValue + " Equals " + equation.Answer);
			break;
		case 3:
			// Reset equation
			equation.XValue = random.NextInt64(100);
			equation.YValue = random.NextInt64(100);
			equation.Answer = 0;

			// Calculate result
			equation.Answer = await APIHelper.APIPost("api/Calculator/Divide", equation);
			Console.WriteLine(equation.XValue + " divided by " + equation.YValue + " Equals " + equation.Answer);
			break;
		default:
			break;
	}
}
Console.ReadLine();