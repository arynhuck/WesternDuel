﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesternDuelApp
{
    class Opponent
    {
        //Member variables
        private int _level;
        private string _type;
        private int _health;
        private int _lowDamage;
        private int _highDamage;
        private bool _allegiance; //with you, or against you.
        private bool _alive; //true=alive, false=dead

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

        public bool Alive
        {
            get { return _alive; }
            set { _alive = value; }
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
            this._alive = true;
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
    }
}