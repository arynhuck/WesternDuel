using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesternDuelApp
{
    public class Opponent
    {
        //Member variables
        private int _level;
        private string _type;
        private int _health;
        private int _lowDamage;
        private int _highDamage;
        private bool _allegiance; //with/against the player (meaning on/or not on the same side)
                                  //true=on same side, false=on opposite sides
        private bool _isAlive; //true=alive, false=dead
        private bool _side; //true=good, false=bad

        //Properties
        public int Level
        {
            get { return _level; }
        }

        public string Type
        {
            get { return _type; }
        }

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int LowDamage
        {
            get { return _lowDamage; }
        }

        public int HighDamage
        {
            get { return _highDamage; }
        }

        public bool Allegiance
        {
            get { return _allegiance; }
        }

        public bool IsAlive
        {
            get { return _isAlive; }
            set { _isAlive = value; }
        }

        public bool Side
        {
            get { return _side; }
        }

        //Constructor
        public Opponent(int playerlvl, bool playerSide) //good = true, bad = false
        {
            this._level = playerlvl + GetLevelDifference(playerlvl);
            this._type = GenerateType();
            this._health = 20 + (this._level * 2);
            this._lowDamage = 1 + (this._level / 3);
            this._highDamage = 3 + (this._level / 3);
            this._allegiance = FindAllegiance(this._type, playerSide);
            this._isAlive = true;
            this._side = Side;
        }

        //Private methods
        private int GetLevelDifference(int playerlvl)
        {
            Random rnd = new Random();
            int difference = 0;

            if (playerlvl == 1)
                difference = 0;
            else if (playerlvl == 2)
                difference = rnd.Next(-1, 1);
            else if (playerlvl <= 3)
                difference = rnd.Next(-2, 2);
            else if (playerlvl <= 7)
                difference = rnd.Next(-3, 3);
            else
                difference = rnd.Next(-4, 3);

            return difference;
        }

        private string GenerateType()
        {
            Random rnd = new Random();
            int numType;
            string thetype;

            numType = rnd.Next(1, 5);

            switch(numType)
            {
                case (int)OpponentTypes.Sherif:
                    thetype = "SHERIF";
                    _side = true;
                    break;
                case (int)OpponentTypes.Bandit:
                    thetype = "BANDIT";
                    _side = false;
                    break;
                case (int)OpponentTypes.Villager:
                    thetype = "VILLAGER";
                    _side = true;
                    break;
                case (int)OpponentTypes.Outlaw:
                    thetype = "OUTLAW";
                    _side = false;
                    break;
                default:
                    thetype = "CLONE";
                    _side = false;
                    break;
            }

            return thetype;
        }

        private enum OpponentTypes
        {
            Sherif = 1, Bandit, Villager, Outlaw
        }

        private bool FindAllegiance(bool playerSide)
        {
            if (_side == true && playerSide == true)//opponent is good and player is good
                return true;
            else if (_side == false && playerSide == false) //opponent is bad and player is bad
                return true;
            else //they are not on the same side
                return false;
        }
    }
}