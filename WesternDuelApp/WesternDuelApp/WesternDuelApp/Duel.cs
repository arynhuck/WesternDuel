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
            message = "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
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

        public static string generateFightMessage(Player player, Opponent opponent)
        {

        }


        public static string generatePlayerInfoMessage (Player player)
        {
            string message="";
            message = "Level: " + player.Level + "\nHealth: " + player.Health + "\nDamage range: " + player.LowDamage + "-" + player.HighDamage + "\n";
            return message;
        }











        ////static void Main(string[] args)
        ////{
        ////    bool alive = true;
        ////    string response;
        ////    bool goOn = false;
        ////    bool fight = false;
        ////    Program thingy = new Program;
        ////    Player player = new Player();
        ////    Opponent opponent;
        ////   thingy.message = "Welcome to Duel. Here you will fight to the death.";
        ////    while (alive)
        ////    {
        ////        opponent = new Opponent(player.Level, player.Side);
        ////        thingy.message = "\n~~~~~~~~~~~~~~~~~~~~~~~~~~~~~";
        ////       thingy.message = "\nEntering town...";
        ////        thingy.message = "\n" + opponent.Type + " has stopped you.";
        ////        do
        ////        {
        ////            thingy.message = "\nWhat would you like to do? \n\tDisplay opponent info: Type 'i'\n\tFight: Type 'f'\n\tWalk on: Type 'w'\n";
        ////            if (response == "i")
        ////            {
        ////                print opponent info:
        ////                Console.Write(
        ////                    "\t~~ They are a level " + opponent.Level + " " + opponent.Type + ".\n" + opponent.Health + " health.~~\n");
        ////                if (opponent.Allegiance)//true, they're with you.
        ////                    Console.WriteLine("They wave in a friendly manner, they will not attack... unless you do...");
        ////                else //not with you
        ////                    Console.WriteLine("They glare at you and reach for their gun...");
        ////            }
        ////            else if (response == "f")
        ////            {
        ////                goOn = true;
        ////                fight = true;
        ////                Console.WriteLine("You whip out your gun!");
        ////                 alive = Fight(player, opponent);
        ////            }
        ////            else if (response == "w")
        ////            {
        ////                goOn = true;
        ////                if (opponent.Allegiance)//true, they're with you.
        ////                {
        ////                    fight = false;
        ////                    Console.WriteLine("They nod as you pass by.");
        ////                }
        ////                else //not with you
        ////                {
        ////                    fight = true;
        ////                    Console.WriteLine("They whip out their gun. \n'Hold it right there!'");
        ////                    alive = Fight(player, opponent);
        ////                }
        ////            }
        ////            else
        ////                Console.WriteLine("Type 'i', 'f', or 'w'. You must fight to the death.");
        ////        } while (goOn == false);
        ////        goOn = false;

        ////        if (fight)
        ////        {
        ////            alive = Fight(player, opponent);
        ////            if (alive)
        ////            {
        ////                if (opponent.Allegiance == true)
        ////                {
        ////                    if (player.Side == true)//good player killed good guy
        ////                        player.GoodGuysKilled += 1;
        ////                    else //bad player killed bad guy
        ////                        player.BadGuysKilled += 1;
        ////                }
        ////                else if (opponent.Allegiance == false)
        ////                {
        ////                    if (player.Side == true)//good player killed bad guy
        ////                        player.BadGuysKilled += 1;
        ////                    else //bad player killed good guy
        ////                        player.GoodGuysKilled += 1;

        ////                }
        ////                player.ChangeSide(); //update sides
        ////                player.Heal(); //need that full health if you want any hope of continuing.
        ////                player.LevelUp();//sometimes you level up!

        ////            }
        ////        }

        ////        fight = false;
        ////    }

        ////    Console.WriteLine("Well now... You're dead.");

        ////    do
        ////    {
        ////        Console.WriteLine("Type 'x' to exit.");
        ////        response = Console.ReadLine();
        ////    } while (response != "x");
        ////}

        ////public static bool Fight(Player player, Opponent opponent)
        ////{
        ////    bool playerAlive = true;
        ////    bool opponentAlive = true;
        ////    Random plRnd = new Random();
        ////    Random opRnd = new Random();
        ////    int plDamage;
        ////    int opDamage;

        ////    while (playerAlive && opponentAlive)
        ////    {
        ////        plDamage = plRnd.Next(player.LowDamage, player.HighDamage);
        ////        opponent.Health -= plDamage;
        ////        Console.WriteLine(opponent.Type + " took " + plDamage + " damage!");
        ////        if (opponent.Health <= 0)
        ////        {
        ////            DEAD
        ////            opponentAlive = false;
        ////            side stuff!

        ////            Console.WriteLine("Opponent " + opponent.Type + " killed!");
        ////            Console.WriteLine("You won!");
        ////        }
        ////        else
        ////        {
        ////            opDamage = opRnd.Next(opponent.LowDamage, opponent.HighDamage);
        ////            player.Health -= opDamage;
        ////            Console.WriteLine("PLAYER took " + opDamage + " damage!");
        ////        }
        ////        if (player.Health <= 0)
        ////        {
        ////            DEAD
        ////            playerAlive = false;
        ////            Console.WriteLine("PLAYER killed!");
        ////        }

        ////    }
        ////    return playerAlive;

        ////}


    }

    //class Player
    //{
    //    private int level;
    //    private int health;
    //    private int lowDamage;
    //    private int highDamage;
    //    private int goodGuysKilled;
    //    private int badGuysKilled;
    //    private bool side; //true = good, false = bad

    //    public Player()
    //    {
    //        this.level = 1;
    //        this.health = 20 + (this.level * 2);
    //        this.lowDamage = 1 + (this.level / 3);
    //        this.highDamage = 3 + (this.level / 3);
    //        this.goodGuysKilled = 0;
    //        this.badGuysKilled = 0;
    //        this.side = true;
    //    }

    //    public void ChangeSide()
    //    {
    //        if (goodGuysKilled >= badGuysKilled)
    //            side = false;
    //        else
    //            side = true;
    //    }

    //    public void LevelUp()
    //    {
    //        //bool yeahMan = false;
    //        int victims = goodGuysKilled + badGuysKilled;

    //        if ((victims % 5) == 0)
    //        {

    //            //}
    //            // level = victims / 5;
    //            //if (yeahMan)
    //            //{
    //            level += 1;
    //            health = 20 + (level * 2);
    //            lowDamage = 1 + (level / 3);
    //            highDamage = 3 + (level / 3);
    //            Console.WriteLine("YOU HAVE LEVELED UP! REJOICE!");
    //            Console.Write("\nLevel: " + level + "\nHealth: " + health + "\nDamage range: " + lowDamage + "-" + highDamage + "\n");
    //        }
    //    }

    //    public void Heal()
    //    {
    //        health = 20 + (level * 2);
    //    }

    //    public int Level
    //    {
    //        get { return level; }
    //        //set
    //        //{
    //        //    int victims = goodGuysKilled + badGuysKilled;
    //        //    level = victims / 5;
    //        //}
    //    }

    //    public int Health
    //    {
    //        get { return health; }
    //        set { health = value; }
    //    }

    //    public int LowDamage
    //    {
    //        get { return lowDamage; }
    //        set { lowDamage = 1 + (this.level / 3); }
    //    }

    //    public int HighDamage
    //    {
    //        get { return highDamage; }
    //        set { highDamage = 3 + (this.level / 3); }
    //    }

    //    public int GoodGuysKilled
    //    {
    //        get { return goodGuysKilled; }
    //        set { goodGuysKilled = value; }
    //    }

    //    public int BadGuysKilled
    //    {
    //        get { return badGuysKilled; }
    //        set { badGuysKilled = value; }
    //    }

    //    public bool Side
    //    {
    //        get { return side; }
    //    }


    //}

    //class Opponent
    //{
    //    private int level;
    //    private string type;
    //    private int health;
    //    private int lowDamage;
    //    private int highDamage;
    //    private bool allegiance; //with you, or against you.

    //    public Opponent(int playerlvl, bool playerSide) //good = true, bad = false
    //    {
    //        this.level = playerlvl + LevelDiff(playerlvl);
    //        this.type = GenerateType();
    //        this.health = 20 + (this.level * 2);
    //        this.lowDamage = 1 + (this.level / 3);
    //        this.highDamage = 3 + (this.level / 3);
    //        this.allegiance = FindAllegiance(this.type, playerSide);
    //    }

    //    private int LevelDiff(int playerlvl)
    //    {
    //        Random rnd = new Random();
    //        int diff = 0;

    //        if (playerlvl <= 3)
    //            diff = rnd.Next(-2, 1);
    //        else if (playerlvl <= 7)
    //            diff = rnd.Next(-3, 2);
    //        else
    //            diff = rnd.Next(-4, 3);
    //        return diff;
    //    }

    //    private string GenerateType()
    //    {
    //        Random rnd = new Random();
    //        int numType;
    //        string thetype;

    //        numType = rnd.Next(1, 5);

    //        switch (numType)
    //        {
    //            case 1:
    //                thetype = "SHERIF";
    //                break;
    //            case 2:
    //                thetype = "BANDIT";
    //                break;
    //            case 3:
    //                thetype = "VILLAGER";
    //                break;
    //            case 4:
    //                thetype = "OUTLAW";
    //                break;
    //            default:
    //                thetype = "CLONE";
    //                break;
    //        }
    //        return thetype;
    //    }

    //    private bool FindAllegiance(string opType, bool playerSide)
    //    {
    //        if ((opType == "SHERIF") || (opType == "VILLAGER"))
    //        {
    //            if (playerSide == false)
    //                return false;
    //            else
    //                return true;
    //        }
    //        else
    //        {
    //            if (playerSide == false)
    //                return true;
    //            else
    //                return false;
    //        }
    //    }

    //    public int Level
    //    {
    //        get { return level; }
    //    }

    //    public string Type
    //    {
    //        get { return type; }
    //    }

    //    public int Health
    //    {
    //        get { return health; }
    //        set { health = value; }
    //    }

    //    public int LowDamage
    //    {
    //        get { return lowDamage; }
    //    }

    //    public int HighDamage
    //    {
    //        get { return highDamage; }
    //    }

    //    public bool Allegiance
    //    {
    //        get { return allegiance; }
    //    }

    //}



}
