using System.Collections.Generic;
using Xamarin.Forms;

namespace TOCKA.Views.MasterMainPage
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView { get { return listView; } }

        public MasterPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>
            {
                new MasterPageItem
                {
                    Title = "Contacts",
                    IconSource = "contacts.png",
                    TargetType = typeof(AddTarget)
                },
                new MasterPageItem
                {
                    Title = "TodoList",
                    IconSource = "todo.png",
                    TargetType = typeof(AddTask)
                },
                new MasterPageItem
                {
                    Title = "Reminders",
                    IconSource = "reminders.png",
                    TargetType = typeof(ListofTargets)
                }
            };

            listView.ItemsSource = masterPageItems;
        }
    }
}
