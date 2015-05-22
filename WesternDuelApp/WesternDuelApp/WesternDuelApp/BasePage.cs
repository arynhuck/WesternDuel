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
        //private Player player;

        public BasePage(Player player)
        {
             //player= new Player(); //this apparently kills it
            
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
                HeightRequest =200,
                VerticalOptions= LayoutOptions.End
            };
            lblMessage.SetBinding(AbsoluteLayout.LayoutBoundsProperty, "0, 0, 1, .45");

            var btnOpInfo = new Button
            {
                Text = "INFO"
            };
            btnOpInfo.Clicked += (o, e) =>
            {
                //change message text

            };

            var btnFight = new Button
            {
                Text = "FIGHT"
            };
            btnFight.Clicked += (o, e) =>
            {
                //FIGHT!
                //call methods in Duel

            };

            var btnWalk = new Button
            {
                Text = "WALK"
            };
            btnWalk.Clicked += (o, e) =>
            {
                //call methods in Duel

            };

            var btnPlayer = new Button
            {
                Text = "YOU"
            };
            btnPlayer.Clicked += (o, e) =>
            {
                //change text in lblMessage
                lblMessage.Text = "\nLevel: " + player.Level + "\nHealth: " + player.Health + "\nDamage range: " + player.LowDamage + "-" + player.HighDamage + "\n";

            };

            absLayout.Children.Add(lblMessage);

            Content = new StackLayout
            {
                Children =
                {absLayout, btnOpInfo, btnFight, btnWalk, btnPlayer }
            };

        }
    }
}
