using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace WesternDuelApp
{
    public class PlayerInfoPage : ContentPage
    {
        public PlayerInfoPage(Player player)
        {
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0);
            BackgroundColor = Color.Black;

            Title = "PLAYER STATS";

            var lblStats = new Label
            {
                Text = Duel.GeneratePlayerInfoMessage(player),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                TextColor = Color.Silver,
                HeightRequest = 200,
                VerticalOptions = LayoutOptions.Start
            };

            var picPlayer = new Image
            {

            };

            Content = new StackLayout
            {
                Children = { lblStats, picPlayer }

            };
        }
    }
}
