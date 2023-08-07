
namespace MauiPlatzi.Views.Triggers;

public partial class TriggersMainPage : ContentPage
{
	public TriggersMainPage()
	{
		InitializeComponent();
        BindingContext = new TriggersViewModel();

    }
}