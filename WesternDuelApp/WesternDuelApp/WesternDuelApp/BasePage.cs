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
            Title = "WESTERN DUEL";

            //format of lblMessage
            var lblMessage = new Label
            {
                Text = "Welcome to Duel. Here you will fight to the death.",
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                BackgroundColor = Color.Black,
                TextColor = Color.Silver,
                HeightRequest = 200,
                VerticalOptions = LayoutOptions.End
            };

            //format of btnContinue
            var btnContinue = new Button
            {
                Text = "CONTINUE ON...",
                IsVisible = false
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


            //format of btnWalk
            var btnWalk = new Button
            {
                Text = "WALK",
                IsVisible = false
            };
           
            //format of btnPlayer
            var btnPlayer = new Button
            {
                Text = "YOU",
                IsVisible = false
            };

            //format of btnOkay
            var btnOkay = new Button
            {
                Text = "OKAY",
                IsVisible = false
            };

            //format of btnNewGame
            var btnNewGame = new Button
            {
                Text = "NEW GAME",
                IsVisible = true
            };

            //Click actions
            btnContinue.Clicked += (o, e) =>
            {
                //change message text
                opponent = new Opponent(player.Level, player.Side);

                lblMessage.Text = Duel.GenerateNewTownMessage(opponent.Type);
                btnContinue.IsVisible = false;
                btnOpInfo.IsVisible = true;
                btnFight.IsVisible = true;
                btnWalk.IsVisible = true;
                btnPlayer.IsVisible = true;
            };

            btnOpInfo.Clicked += (o, e) =>
            {
                //Brings up Opponent Info Page
                Navigation.PushAsync(new OpponentInfoPage(opponent));

            };

            btnFight.Clicked += (o, e) =>
            {
                //FIGHT!
                lblMessage.Text = Duel.Fight(player, opponent);
                    
                btnOkay.IsVisible = true;
                btnOpInfo.IsVisible = false;
                btnFight.IsVisible = false;
                btnWalk.IsVisible = false;
                btnPlayer.IsVisible = false;
            };

            btnWalk.Clicked += (o, e) =>
            {
                //call methods in Duel
                lblMessage.Text = Duel.GenerateWalkMessage(opponent.Allegiance);

                if (opponent.Allegiance)//with you
                {
                    //walk on man
                    btnContinue.IsVisible = true;
                    btnOpInfo.IsVisible = false;
                    btnFight.IsVisible = false;
                    btnWalk.IsVisible = false;
                    btnPlayer.IsVisible = false;
                }
                else //FIGHT!!!
                {
                    btnOpInfo.IsVisible = false;
                    btnFight.IsVisible = true; //still make user click it whahaha
                    btnWalk.IsVisible = false;
                    btnPlayer.IsVisible = false;
                }
            };

            btnPlayer.Clicked += (o, e) =>
            {
                //display PlayerInfoPage
                Navigation.PushAsync(new PlayerInfoPage(player));
            };

            btnOkay.Clicked += (o, e) =>
            {
                if (player.IsAlive)
                {
                    btnContinue.IsVisible = true;
                    lblMessage.Text = "You wander off...";
                }
                else
                {
                    lblMessage.Text = "That's it. It's over. You're dead.";
                    btnNewGame.IsVisible = true;
                }

                btnOkay.IsVisible = false; 
            };

            btnNewGame.Clicked += (o, e) =>
            {
                player = new Player();
                opponent = new Opponent(player.Level, player.Side);

                lblMessage.Text = Duel.GenerateNewTownMessage(opponent.Type);
                btnOpInfo.IsVisible = true;
                btnFight.IsVisible = true;
                btnWalk.IsVisible = true;
                btnPlayer.IsVisible = true;
                btnNewGame.IsVisible = false;
            };

            Content = new StackLayout
            {
                Children = { lblMessage, btnNewGame, btnContinue, btnFight, btnWalk, btnOpInfo, btnPlayer, btnOkay }
            };
        }
    }
}
