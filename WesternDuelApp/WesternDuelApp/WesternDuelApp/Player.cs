using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesternDuelApp
{
    public class Player
    {
        //Member variables
        private int _level;
        private int _health;
        private int _lowDamage;
        private int _highDamage;
        private int _goodGuysKilled;
        private int _badGuysKilled;
        private bool _side; //true = good, false = bad
        private bool _isAlive; //true= alive, false = dead

        //Properties:
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int LowDamage
        {
            get { return _lowDamage; }
            set { _lowDamage = 1 + (this.Level / 3); }
        }

        public int HighDamage
        {
            get { return _highDamage; }
            set { _highDamage = 3 + (this._level / 3); }
        }

        public int GoodGuysKilled
        {
            get { return _goodGuysKilled; }
            set { _goodGuysKilled = value; }
        }

        public int BadGuysKilled
        {
            get { return _badGuysKilled; }
            set { _badGuysKilled = value; }
        }

        public bool Side
        {
            get { return _side; }
            set { _side = value; }
        }

        public bool IsAlive
        {
            get { return _isAlive; }
            set { _isAlive = value; }
        }

        //constructor
        public Player()
        {
            this._level = 1;
            this._health = 20 + (this._level * 2);
            this._lowDamage = 1 + (this._level / 3);
            this._highDamage = 3 + (this._level / 3);
            this._goodGuysKilled = 0;
            this._badGuysKilled = 0;
            this._side = true;
            this._isAlive = true;
        }

        //Public methods
        public void ChangeSide()
        {
            if (GoodGuysKilled >= BadGuysKilled)
                Side = false;
            else
                Side = true;
        }

        public void LevelUp()
        {
          //  int victims = GoodGuysKilled + BadGuysKilled;

           // if ((victims % 5) == 0)
           // {
                Level += 1;
                Health = 20 + (Level * 2);
                LowDamage = 1 + (Level / 3);
                HighDamage = 3 + (Level / 3);
            //}
        }

        public void Heal()
        {
            Health = 20 + (Level * 2);
        }

        public string createInfoMessage()
        {
            return "\nLevel: " + _level + "\nHealth: " + _health + "\nDamage range: " + _lowDamage + "-" + _highDamage + "\n";
        }
    }
}