namespace RodriguezEvaluacionprogreso3.Views;

public partial class ARMnejoDatos : ContentPage
{
	public ARMnejoDatos()
	{
		InitializeComponent();
	}

	private async void Button_Clicked(object sender, EventArgs e)
	{
		using (HttpClient client = new HttpClient())
		{
			string url = "https://coronavirus-monitor-v2.p.rapidapi.com/coronavirus/latest_stat_by_country.php";
			string country = "<REQUIRED>";
			string apiKey = "938a4bdb0amsh90d5e61c6884148p146df6jsn79cb96e7755b";
			string apiHost = "coronavirus-monitor-v2.p.rapidapi.com";

			client.DefaultRequestHeaders.Add("938a4bdb0amsh90d5e61c6884148p146df6jsn79cb96e7755b", apiKey);
			client.DefaultRequestHeaders.Add("coronavirus-monitor-v2.p.rapidapi.com", apiHost);

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



