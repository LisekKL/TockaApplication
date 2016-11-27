using System;
using Xamarin.Forms;

namespace TOCKA.Views
{
    public partial class SingleTarget : ContentPage
    {
        public SingleTarget()
        {
            InitializeComponent();
        }

        private async void NavigateBack(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

        private async void GoToAddTask(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new AddTask());
        }
    }
}
