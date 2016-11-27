using System;
using Xamarin.Forms;

namespace TOCKA.Views
{
    public partial class FrontPage : ContentPage
    {
        public FrontPage()
        {
            InitializeComponent();
            
            

        }
        

        private async void OnDismissButton_OnClicked(object sender, EventArgs e)
        { //TAKI NIBY LOGOUT ? NIC NIE UMIEM ;_;
            await Navigation.PopModalAsync();
        }

    }
}
