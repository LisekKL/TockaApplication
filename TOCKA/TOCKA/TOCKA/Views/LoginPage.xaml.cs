using System;
using Xamarin.Forms;

namespace TOCKA.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            var login = LoginEntry.Text;
            var password = PasswordEntry.Text;

            if (ifTrue(login, password))
                await Navigation.PushModalAsync(new MasterMainPage.MainPage());
            else
                await DisplayAlert("Fail", "Failed to log in. Check your Login information.", "OK");
        }

        private bool ifTrue(string login, string pass)
        {
            if ((login == "Huge Trump") && (pass == "eh"))
                return true;
            return false;
        }
    }
}