// See https://aka.ms/new-console-template for more information
using JokeAPI;
using MyFirstProject;
using Newtonsoft.Json;

Console.WriteLine("Hello, World!");

// Addition
var x = 1;
var y = 2;
var result = MyFirstClassLibrary.CalculatorMethods.Add(x, y);
Console.WriteLine(x + " plus " + y + " Equals " + result);

string json = @"{
  'XValue': 2,
  'YValue': 3,
  'Result': 0
}";

var m = JsonConvert.DeserializeObject<EquationValue>(json);
if (m != null)
{
	m.Result = MyFirstClassLibrary.CalculatorMethods.Add(m.XValue, m.YValue);
	Console.WriteLine(m.XValue + " plus " + m.YValue + " Equals " + m.Result);
}
else
{
	Console.WriteLine("Could not calculate values");
}

await AddJokes();
await GetJokes();


async Task AddJokes()
{
	var httpClient = new HttpClient();
	var client = new MyJokes(httpClient);

	var jokes = new List<NewJoke>();

	jokes.Add(new NewJoke() { Value = "when Chuck Norris saw god it was like looking in the mirror" });
	foreach (var joke in jokes)
	{
		await client.AddJokeAsync(joke);
	}

	Console.WriteLine("Done");
	Console.ReadLine();

}

async Task GetJokes()
{
	var httpClient = new HttpClient();
	var client = new MyJokes(httpClient);

	var jokes = await client.SearchJokesAsync("", 0, 10);
	foreach (var joke in jokes)
	{
		Console.WriteLine(joke.Value);
	}

	Console.WriteLine("Done");
	Console.ReadLine();
}
