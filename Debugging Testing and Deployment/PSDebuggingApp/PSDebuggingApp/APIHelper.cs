using System.Net.Http.Headers;
using System.Net.Http.Json;

namespace PSDebuggingApp
{
	public static class APIHelper
	{
		static HttpClient client = new HttpClient()
		{
			BaseAddress = new Uri("https://pspublishingapp20220520124252.azurewebsites.net/")
		};

		public static async Task<float> APIPost(string apiURL, Equation equation)
		{
			client.DefaultRequestHeaders.Accept.Clear();
			client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
			HttpResponseMessage response = await client.PostAsJsonAsync(apiURL, equation);
			response.EnsureSuccessStatusCode();

			// return URI of the created resource.
			var answer = await response.Content.ReadAsStringAsync();

			return float.Parse(answer);
		}
	}
}
