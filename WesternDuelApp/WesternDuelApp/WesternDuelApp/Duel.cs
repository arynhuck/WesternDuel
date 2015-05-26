using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesternDuelApp
{
    class Duel
    {
        //Private methods

        private static void OpponentIsDead(Player player, Opponent opponent)
        {
            if (opponent.Allegiance == true)//same side as player
            {
                if (player.Side == true)//good player killed good guy
                    player.GoodGuysKilled += 1;
                else //bad player killed bad guy
                    player.BadGuysKilled += 1;
            }
            else if (opponent.Allegiance == false)//opposite side as player
            {
                if (player.Side == true)//good player killed bad guy
                    player.BadGuysKilled += 1;
                else //bad player killed good guy
                    player.GoodGuysKilled += 1;
            }

            //player is still alive so we need to update sides and heal
            player.ChangeSide(); //update sides
            player.Heal(); //need that full health if you want any hope of continuing.
        }

        private static string GenerateLevelUpMessage(Player player)
        {
            string message = "";

            message += "YOU HAVE LEVELED UP! REJOICE! \nLevel: " + player.Level + "\nHealth: " + 
                        player.Health + "\nDamage range: " + player.LowDamage + "-" + player.HighDamage;

            return message;
        }

        //Public methods

        public static string Fight(Player player, Opponent opponent)
        {
            Random plRnd = new Random();
            Random opRnd = new Random();
            int plDamage;
            int opDamage;
            int victims = 0;
            string message = "";

            while (player.IsAlive && opponent.IsAlive)
            {
                plDamage = plRnd.Next(player.LowDamage, player.HighDamage);
                opponent.Health -= plDamage;

                if (opponent.Health <= 0)
                {
                    //DEAD
                    opponent.IsAlive = false;
                    OpponentIsDead(player, opponent);
                    victims = player.GoodGuysKilled + player.BadGuysKilled;
                    message = "You won!";

                    //Check to see if player levels up!
                    if ((victims % 5)==0)
                    {
                        //LEVEL UP!
                        player.LevelUp();
                        message += "\n\n" + GenerateLevelUpMessage(player);
                    }
                }
                else
                {
                    opDamage = opRnd.Next(opponent.LowDamage, opponent.HighDamage);
                    player.Health -= opDamage;
                }
                if (player.Health <= 0)
                {
                    //DEAD
                    player.IsAlive = false;
                    message = "Well now... You're dead.";
                }
            }

            return message;
        }

        public static string GenerateNewTownMessage(string opType)
        {
            string message = "";

            message += "Entering town..."
                    + "\n" + opType + " has stopped you";

            return message;
        }

        public static string GenerateOpponentInfoMessage(Opponent op)
        {
            string message = "";//"They are a level " + op.Level + " " + op.Type + ".\n" + op.Health + " health.\n";

            message = "Level " + op.Level + " " + op.Type + "\nHealth: " + op.Health;
            message += "\n" + op.Side;

            if (op.Allegiance)//true, they're with you.
                message += "\n\nThey wave in a friendly manner, they will not attack... unless you do...";
            else //not with you
                message += "\n\nThey glare at you and reach for their gun...";

            return message;
        }

        public static string GenerateWalkMessage(bool opAllegiance)
        {
            string message = "";

            if (opAllegiance)//true, they're with you.
            {
                message ="They nod as you pass by.";
            }
            else //not with you
            {
                message ="They whip out their gun. \n'Hold it right there!'";
            }

            return message;
        }

        public static string GeneratePlayerInfoMessage(Player player)
        {
            string message = "";

            message = "Level: " + player.Level + "\nHealth: " + player.Health + "\nDamage range: " + player.LowDamage + "-" + player.HighDamage + "\n";

            if (player.Side)
                message += "Side: Good";
            else
                message += "Side: Bad";

            message += "\nGood guys killed: " + player.GoodGuysKilled + "\nBad guys killed: " + player.BadGuysKilled;

            return message;
        }
    }
}