using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesternDuelApp
{
    class Opponent
    {
       private int level;
        private string type;
        private int health;
        private int lowDamage;
        private int highDamage;
        private bool allegiance; //with you, or against you.
        private bool alive; //true=alive, false=dead

        public Opponent(int playerlvl, bool playerSide) //good = true, bad = false
        {
            this.level = playerlvl + LevelDiff(playerlvl);
            this.type = GenerateType();
            this.health = 20 + (this.level * 2);
            this.lowDamage = 1 + (this.level / 3);
            this.highDamage = 3 + (this.level / 3);
            this.allegiance = FindAllegiance(this.type, playerSide);
            this.alive = true;
        }

        private int LevelDiff(int playerlvl)
        {
            Random rnd = new Random();
            int diff = 0;

            if (playerlvl <= 3)
                diff = rnd.Next(-2, 1);
            else if (playerlvl <= 7)
                diff = rnd.Next(-3, 2);
            else
                diff = rnd.Next(-4, 3);
            return diff;
        }

        private string GenerateType()
        {
            Random rnd = new Random();
            int numType;
            string thetype;

            numType = rnd.Next(1, 5);

            switch(numType)
            {
                case 1:
                    thetype = "SHERIF";
                    break;
                case 2:
                    thetype = "BANDIT";
                    break;
                case 3:
                    thetype = "VILLAGER";
                    break;
                case 4:
                    thetype = "OUTLAW";
                    break;
                default:
                    thetype = "CLONE";
                    break;
            }
            return thetype;
        }

        private bool FindAllegiance(string opType, bool playerSide)
        {
            if ((opType =="SHERIF") || (opType =="VILLAGER"))
            {
                if (playerSide == false)
                    return false;
                else
                    return true;
            }
            else
            {
                if (playerSide == false)
                    return true;
                else
                    return false;
            }
        }

        public int Level
        {
            get { return level; }
        }

        public string Type
        {
            get { return type;}
        }

        public int Health
        {
            get { return health; }
            set { health = value; }
        }

        public int LowDamage
        {
            get { return lowDamage; }
        }

        public int HighDamage
        {
            get { return highDamage; }
        }

        public bool Allegiance
        {
            get { return allegiance; }
        }

        public bool Alive
        {
            get { return alive; }
            set { alive = value; }
        }

    }
}
