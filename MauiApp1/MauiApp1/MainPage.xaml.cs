using System.Diagnostics;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        double progressCount = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void SetProgress(object sender, EventArgs e) {
            SliderProgress.Progress = (double)Slide.Value/Slide.Maximum;
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            progressCount++;

            /*
            count = 0;
            progressCount = 0;
            */

            Progress.Progress = progressCount / 100;

            if (progressCount > 100) {
                progressCount = 0;
            }
            
            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";


            SemanticScreenReader.Announce(CounterBtn.Text);
        }
    }

}
