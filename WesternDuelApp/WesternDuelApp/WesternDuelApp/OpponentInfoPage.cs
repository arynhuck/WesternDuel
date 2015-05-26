using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;

namespace WesternDuelApp
{
    public class OpponentInfoPage : ContentPage
    {
        public OpponentInfoPage(Opponent opponent)
        {
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0);
            BackgroundColor = Color.Black;

            Title = "OPPONENT STATS";

            var lblMessage = new Label
            {
                Text = Duel.GenerateOpponentInfoMessage(opponent),
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                TextColor = Color.Silver,
                HeightRequest = 200,
                VerticalOptions = LayoutOptions.Start
            };

            var picOpponent = new Image
            {

            };

            Content = new StackLayout
            {
                Children = { lblMessage, picOpponent }
				
            };
        }
    }
}
