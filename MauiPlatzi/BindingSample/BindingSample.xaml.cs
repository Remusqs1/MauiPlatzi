namespace MauiPlatzi.BindingSample;

public partial class BindingSample : ContentPage
{
	public BindingSample()
	{
		InitializeComponent();
		BindingContext = new TeacherViewModel();
	}
}