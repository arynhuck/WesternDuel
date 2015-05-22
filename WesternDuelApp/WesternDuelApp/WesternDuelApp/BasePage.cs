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
            Opponent opponent;
            player = new Player();
            
            Padding = new Thickness(10, Device.OnPlatform(20, 0, 0), 10, 0);
            Title = "Duel";
// var stLayout = new StackLayout();
           var absLayout = new AbsoluteLayout{
                BackgroundColor = Color.Black,
                
           };
          // absLayout.SetBinding(AbsoluteLayout.LayoutBoundsProperty, "0, 0, 1, .45");

            var lblMessage = new Label
            {
                Text = "Welcome to Duel. Here you will fight to the death.",
                FontSize= Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                HeightRequest =200,
                VerticalOptions= LayoutOptions.End
            };
            //lblMessage.SetBinding(AbsoluteLayout.LayoutBoundsProperty, "0, 0, 1, .45");

            var btnContinue = new Button
            {
                Text = "CONTINUE ON..."
            };
          
            
            var btnOpInfo = new Button
            {
                Text = "OPPONENT INFO",
                IsVisible = false
            };
            btnOpInfo.Clicked += (o, e) =>
            {
                //change message text

            };

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
                lblMessage.Text = "\nLevel: " + player.Level + "\nHealth: " + player.Health + "\nDamage range: " + player.LowDamage + "-" + player.HighDamage + "\n";
                //lblMessage.SetBinding(Label.TextProperty, "Level");
                //lblMessage.Text = player.createInfoMessage();
                //lblMessage.Text = "Level is: " + player.Level;
            };
            //lblMessage.BindingContext = player;

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



            absLayout.Children.Add(lblMessage);

            Content = new StackLayout
            {
                Children =
                {absLayout, btnContinue, btnOpInfo, btnFight, btnWalk, btnPlayer }
            };

        }
    }
}
