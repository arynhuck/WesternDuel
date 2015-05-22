using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;



namespace WesternDuelApp
{
    class BasePage : ContentPage
    {
        private Player player;

        public BasePage()//Player player)
        {
            Opponent opponent = new Opponent(0, true); //will find a way to do without this
            //currently need this so all buttons will be happy
            player = new Player();

            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0);
            Title = "Duel";

            //format of absLayout, might get rid of...
            var absLayout = new AbsoluteLayout
            {
                BackgroundColor = Color.Black,

            };

            //format of lblMessage
            var lblMessage = new Label
            {
                Text = "Welcome to Duel. Here you will fight to the death.",
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HeightRequest = 200,
                VerticalOptions = LayoutOptions.End
            };

            //format of btnContinue
            var btnContinue = new Button
            {
                Text = "CONTINUE ON..."
            };

            //format of btnOpInfo
            var btnOpInfo = new Button
            {
                Text = "OPPONENT INFO",
                IsVisible = false
            };

            //format of btnFight
            var btnFight = new Button
            {
                Text = "FIGHT",
                IsVisible = false
            };
            btnFight.Clicked += (o, e) =>
            {
                //FIGHT!
                //call methods in Duel

            };

            //format of btnWalk
            var btnWalk = new Button
            {
                Text = "WALK",
                IsVisible = false
            };
            btnWalk.Clicked += (o, e) =>
            {
                //call methods in Duel

            };

            var btnPlayer = new Button
            {
                Text = "YOU",
                IsVisible = false
            };
            btnPlayer.Clicked += (o, e) =>
            {
                //change text in lblMessage
                lblMessage.Text = Program.generatePlayerInfoMessage(player);
            };

            //Click actions
            btnContinue.Clicked += (o, e) =>
            {
                //change message text
                opponent = new Opponent(player.Level, player.Side);
                lblMessage.Text = Program.generateNewTownMessage(opponent.Type);
                btnContinue.IsVisible = false;
                btnOpInfo.IsVisible = true;
                btnFight.IsVisible = true;
                btnWalk.IsVisible = true;
                btnPlayer.IsVisible = true;
            };

            btnOpInfo.Clicked += (o, e) =>
            {
                //change message text
                lblMessage.Text = Program.generateOpponentInfoMessage(opponent);

            };



            absLayout.Children.Add(lblMessage);

            Content = new StackLayout
            {
                Children = { absLayout, btnContinue, btnOpInfo, btnFight, btnWalk, btnPlayer }
            };

        }
    }
}
