using System;
using Xamarin.Forms;

namespace TOCKA.Views
{
    public partial class AddTarget : ContentPage
    {
        public AddTarget()
        {
            InitializeComponent();
        }
        private async void AddTaskClick(object sender, EventArgs e)
        {
            difficultyPicker.IsVisible = !difficultyPicker.IsVisible;
        }
        private async void SaveTaskClick(object sender, EventArgs e)
        {
            difficultyPicker.IsVisible = !difficultyPicker.IsVisible;
            var a = task1.Text;
            var b = task2.Items[task2.SelectedIndex];
            taskName.Text = a;
            taskDifficulty.Text = b;
            descr.IsVisible = true;


        }

        private async void CleanThis(object sender, EventArgs e)
        {
            taskName.Text = "";
            taskDifficulty.Text = "";
            descr.IsVisible = false;
        }

    }
}
