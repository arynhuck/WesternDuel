using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesternDuelApp
{
    class Player
    {
        private int level;
        private int health;
        private int lowDamage;
        private int highDamage;
        private int goodGuysKilled;
        private int badGuysKilled;
        private bool side; //true = good, false = bad
        private bool alive; //true= alive, false = dead

        //constructor
        public Player()
        {
            this.level = 1;
            this.health = 20 + (this.level * 2);
            this.lowDamage = 1 + (this.level / 3);
            this.highDamage = 3 + (this.level / 3);
            this.goodGuysKilled = 0;
            this.badGuysKilled = 0;
            this.side = true;
            this.alive = true;
        }

        public void ChangeSide()
        {
            if (GoodGuysKilled >= BadGuysKilled)
                Side = false;
            else
                Side = true;
        }

        public void LevelUp()
        {
            int victims = GoodGuysKilled + BadGuysKilled;

            if ((victims % 5) == 0)
            {
                Level += 1;
                Health = 20 + (Level * 2);
                LowDamage = 1 + (Level / 3);
                HighDamage = 3 + (Level / 3);
               // Console.WriteLine("YOU HAVE LEVELED UP! REJOICE!");
                //Console.Write("\nLevel: " + level + "\nHealth: " + health + "\nDamage range: " + lowDamage + "-" + highDamage + "\n");
            }
        }

        public void Heal()
        {
            Health = 20 + (Level * 2);
        }

        public string createInfoMessage()
        {
            return "\nLevel: " + level + "\nHealth: " + health + "\nDamage range: " + lowDamage + "-" + highDamage + "\n";
        }

        //member variables/properties:
        public int Level
        {
            get { return level; }
            set { level = value; }
        }
        
        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int LowDamage
        {
            get { return lowDamage; }
            set { lowDamage = 1 + (this.Level / 3); }
        }

        public int HighDamage
        {
            get { return highDamage; }
            set { highDamage = 3 + (this.level / 3); }
        }

        public int GoodGuysKilled
        {
            get { return goodGuysKilled; }
            set { goodGuysKilled = value; }
        }

        public int BadGuysKilled
        {
            get { return badGuysKilled; }
            set { badGuysKilled = value; }
        }

        public bool Side
        {
            get { return side; }
            set { side = value; }
        }

        public bool Alive
        {
            get { return alive; }
            set { alive = value; }
        }

    }
}
