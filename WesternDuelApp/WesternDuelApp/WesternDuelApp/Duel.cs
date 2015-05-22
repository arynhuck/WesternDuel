using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesternDuelApp
{
    class Program
    {
        //private string message;

        //public string Message
        //{ 
        //    get { return message; }
        //    set { message = value; }
        //}

        public static string generateNewTownMessage(string opType)
        {
            string message = "";
            message += "\nEntering town...";
            message += "\n" + opType + " has stopped you";
            return message;
        }

        public static string generateOpponentInfoMessage(Opponent op)
        {
            string message = "";
            message = "They are a level " + op.Level + " " + op.Type + ".\n" + op.Health + " health.~~\n";

            if (op.Allegiance)//true, they're with you.
                message += "They wave in a friendly manner, they will not attack... unless you do...";
            else //not with you
                message += "They glare at you and reach for their gun...";

            return message;
        }

        //returns the text to display in lblMessage as well
        //TODO:
        public static bool Fight(Player player, Opponent opponent)
        {
            //string message = "working";
           // bool playerAlive = true;
          //  bool opponentAlive = true;
            Random plRnd = new Random();
            Random opRnd = new Random();
            int plDamage;
            int opDamage;

            while (player.Alive && opponent.Alive)
            {
                plDamage = plRnd.Next(player.LowDamage, player.HighDamage);
                opponent.Health -= plDamage;
               // message += "\n" + opponent.Type + " took " + plDamage + " damage!";
                if (opponent.Health <= 0)
                {
                    //DEAD
                    opponent.Alive = false;
                  
                   // message += "\nOpponent " + opponent.Type + " killed!";
                    //message += "\nYou won!";

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

                    //player is still alive so we need to update sides, heal, and level-up
                    player.ChangeSide(); //update sides
                    player.Heal(); //need that full health if you want any hope of continuing.
                    player.LevelUp();//sometimes you level up!

                }
                else
                {
                    opDamage = opRnd.Next(opponent.LowDamage, opponent.HighDamage);
                    player.Health -= opDamage;
                    //message += "\nPLAYER took " + opDamage + " damage!";
                }
                if (player.Health <= 0)
                {
                    //DEAD
                    player.Alive = false;
                    //message += "\nPLAYER killed!";
                }
            }

            return player.Alive;
        }

        public static string generateWalkMessage(bool opAllegiance)
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

        public static string generatePlayerInfoMessage(Player player)
        {
            string message = "";
            message = "Level: " + player.Level + "\nHealth: " + player.Health + "\nDamage range: " + player.LowDamage + "-" + player.HighDamage + "\n";
            message += "Side: " + player.Side + "\nGood guys killed: " + player.GoodGuysKilled + "\nBad guys killed: " + player.BadGuysKilled;
            return message;
        }










    }
}