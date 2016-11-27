using System.Collections.Generic;
using Xamarin.Forms;

namespace TOCKA.Views.MasterMainPage
{
    public partial class MasterPage : ContentPage
    {
        public ListView ListView => listView;

        public MasterPage()
        {
            InitializeComponent();

            var masterPageItems = new List<MasterPageItem>
            {
                new MasterPageItem
                {
                    Title = "Account",
                    IconSource = "acc.png",
                    TargetType = typeof(MyAccount)
                },
                new MasterPageItem
                {
                    Title = "Add target",
                    IconSource = "target.png",
                    TargetType = typeof(AddTarget)
                },
                new MasterPageItem
                {
                    Title = "Target list",
                    IconSource = "list.png",
                    TargetType = typeof(ListofTargets)
                },
                new MasterPageItem
                {
                    Title = "Leaderboards",
                    IconSource = "leaderboard.png",
                    TargetType = typeof(Leaderboards)
                }
            };

            listView.ItemsSource = masterPageItems;
        }
    }
}
