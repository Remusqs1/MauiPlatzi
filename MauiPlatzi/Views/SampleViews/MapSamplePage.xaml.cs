namespace MauiPlatzi.Views.SampleViews;

public partial class MapSamplePage : ContentPage
{
	public MapSamplePage()
	{
		InitializeComponent();
		MyMap();
	}

	public async void MyMap()
	{
		var localtion = new Location(3.448157713374018, -76.53791090137132);
		var options = new MapLaunchOptions { Name = "Esta es otra casa"};
		await Map.OpenAsync(localtion, options);
	}

}