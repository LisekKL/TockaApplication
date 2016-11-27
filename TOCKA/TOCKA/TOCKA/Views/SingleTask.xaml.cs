using System;
using Xamarin.Forms;

namespace TOCKA.Views
{
    public partial class SingleTask : ContentPage
    {
        public SingleTask()
        {
            InitializeComponent();
        }

        private async void NavigateBack(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
