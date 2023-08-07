

namespace MauiPlatzi.Views.Triggers
{
    internal class TriggersViewModel
    {
        public Command<string> MyCommand { get; set; }

        public TriggersViewModel() 
        {
            MyCommand = new Command<string>(ExecTrigger);
        }

        public async static void ExecTrigger(string command)
        {
            switch (command.ToLower())
            {
                case "prop":
                    await App.Navigation.PushAsync(new PropertyTriggerSamplePage());
                    break;
                case "data":
                    await App.Navigation.PushAsync(new DataTriggerSamplePage());
                    break;
                case "event":
                    await App.Navigation.PushAsync(new EventTriggerSamplePage());
                    break;
                case "multi":
                    await App.Navigation.PushAsync(new MultiTriggerSamplePage());
                    break;
                default:
                    break;
            }
        }
    }
}
