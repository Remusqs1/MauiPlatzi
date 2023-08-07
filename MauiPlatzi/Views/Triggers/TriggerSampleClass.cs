
namespace MauiPlatzi.Views.Triggers
{
    public class TriggerSampleClass : TriggerAction<Button>
    {
        int counter = 0;
        protected override void Invoke(Button sender)
        {
            counter++;
            if (counter % 2 == 0)
            {
                sender.BackgroundColor = Color.FromArgb("#97ca3f");
                sender.FontSize = 20;
            }
            else
            {
                sender.BackgroundColor = Color.FromArgb("#FFca4e");
                sender.FontSize = 15;
            }

        }
    }
}
