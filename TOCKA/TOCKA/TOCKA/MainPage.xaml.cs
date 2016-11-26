using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TOCKA
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();

        }

        private async void NavigateButton_OnClicked(object sender, EventArgs e)
        {
            string login;
            string password;
            login = LoginEntry.Text;
            password = PasswordEntry.Text;

            if (ifTrue(login, password))
                await Navigation.PushAsync(new FrontPage());
            else
             await DisplayAlert("Fail", "Failed to log in. Check your Login information.", "OK");

        }

        private bool ifTrue(string login, string pass)
        {
            if ((login == "eh") && (pass == "eh"))
            return true;
            return false;
        }

    }
}
