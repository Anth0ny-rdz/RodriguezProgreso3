namespace RodriguezEvaluacionprogreso3.Views;

public partial class ARMnejoDatos : ContentPage
{
	public ARMnejoDatos()
	{
		InitializeComponent();
	}

	

	static async Task Main(string[] args)
	{
		using (HttpClient client = new HttpClient())
		{
			string url = "https://coronavirus-monitor-v2.p.rapidapi.com/coronavirus/latest_stat_by_country.php";
			string country = "<REQUIRED>";
			string apiKey = "938a4bdb0amsh90d5e61c6884148p146df6jsn79cb96e7755b";
			string apiHost = "coronavirus-monitor-v2.p.rapidapi.com";

			client.DefaultRequestHeaders.Add("X-RapidAPI-Key", apiKey);
			client.DefaultRequestHeaders.Add("X-RapidAPI-Host", apiHost);

			try
			{
				HttpResponseMessage response = await client.GetAsync($"{url}?country={country}");
				response.EnsureSuccessStatusCode();
				string responseBody = await response.Content.ReadAsStringAsync();
				Console.WriteLine(responseBody);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
		}
	}
}
