using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TOCKA
{
    public partial class FrontPage : ContentPage
    {
        public FrontPage()
        {
            InitializeComponent();
            
            

        }
        

        private async void OnDismissButton_OnClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }

    }
}
