using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace TOCKA
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
