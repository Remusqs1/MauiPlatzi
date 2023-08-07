
using MauiPlatzi.Views.SampleViews;

namespace MauiPlatzi.BindingSample
{
    internal class TeacherViewModel
    {
        private List<Teachers> teachersList = new List<Teachers>();
        public Command<string> MyCommand { get; set; }
        public string Message = string.Empty;

        public List<Teachers> TeachersList { get { return teachersList; } set { this.teachersList = value; } }

        public TeacherViewModel()
        {
            MyCommand = new Command<string>(ShowMessage);
            teachersList.Add(new Teachers("Minerva", "McGonagall", "Transformaciones"));
            teachersList.Add(new Teachers("Severus", "Snape", "Pociones"));
            teachersList.Add(new Teachers("Albus", "Dumblendore", "Director"));
        }

        public async static void ShowMessage(string message)
        {
            if (string.IsNullOrEmpty(message)) await App.Navigation.PushAsync(new MainPage());
            //else await App.Navigation.PushAsync(new MapSamplePage());
            //else await App.Navigation.PushAsync(new ShadowSamplePage());
            //else await App.Navigation.PushAsync(new BorderSamplePage());
            else await App.Navigation.PushAsync(new DarkLightSamplePage());
        }
    }
}
