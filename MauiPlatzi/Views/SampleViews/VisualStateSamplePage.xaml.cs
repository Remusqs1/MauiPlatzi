using System.Text.RegularExpressions;

namespace MauiPlatzi.Views.SampleViews;

public partial class VisualStateSamplePage : ContentPage
{
	string currentState = string.Empty;
	public VisualStateSamplePage()
	{
		InitializeComponent();
	}

	void OnTextChanged(object sender, TextChangedEventArgs e)
	{
       string expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
		bool isValid = Regex.IsMatch(e.NewTextValue, expresion);
		GoToState(isValid);
    }

	void GoToState(bool isValid)
	{
        string vState = isValid ? "Correct" : "Incorrect";

		//TODO Not Working on android
        if (currentState != vState)
		{
            var aa = VisualStateManager.GoToState(EntryEmail, vState);
            currentState = vState;
        }

    }
}