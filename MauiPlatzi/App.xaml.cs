using MauiPlatzi.Views.Behaviors;
using MauiPlatzi.Views.Converters;
using MauiPlatzi.Views.SampleViews;
using MauiPlatzi.Views.Triggers;

namespace MauiPlatzi;

public partial class App : Application
{
    public static INavigation Navigation { get; set; }

    public App()
	{
		InitializeComponent();

        var navPage = new NavigationPage(new ConverterSamplePage());
        Navigation = navPage.Navigation;
        MainPage = navPage;
	}
}
