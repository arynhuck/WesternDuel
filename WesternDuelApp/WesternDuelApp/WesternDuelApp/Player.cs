using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WesternDuelApp
{
    class Player
    {
        //constructor
        public Player()
        {
            this.Level = 1;
            this.Health = 20 + (this.Level * 2);
            this.LowDamage = 1 + (this.Level / 3);
            this.HighDamage = 3 + (this.Level / 3);
            this.GoodGuysKilled = 0;
            this.BadGuysKilled = 0;
            this.Side = true;
        }






        //member variables/properties:
        public int Level
        {
            get { return Level; }
            set { Level = value; }
        }
        
        public int Health
        {
            get { return Health; }
            set { Health = value; }
        }

        public int LowDamage
        {
            get { return LowDamage; }
            set { LowDamage = 1 + (this.Level / 3); }
        }

        public int HighDamage
        {
            get { return HighDamage; }
            set { HighDamage = 3 + (this.Level / 3); }
        }

        public int GoodGuysKilled
        {
            get { return GoodGuysKilled; }
            set { GoodGuysKilled = value; }
        }

        public int BadGuysKilled
        {
            get { return BadGuysKilled; }
            set { BadGuysKilled = value; }
        }

        public bool Side
        {
            get { return Side; }
            set { Side = value; }
        }

      


    }
}
