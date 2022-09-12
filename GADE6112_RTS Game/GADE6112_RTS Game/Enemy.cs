using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_RTS_Game
{
    public abstract class Enemy : Character
    {
        protected Random r = new Random();
        public int ArrayIndex { get; internal set; }

        public Enemy(int hp, int damage, int x, int y, char symbol, int arrayIndex) : base(hp, damage, hp, x, y, symbol)
        {
            ArrayIndex = arrayIndex;
        }

        public override string ToString()
        {
            return "at [" + X + "," + Y + "] (" + damage + ")";
        }
    }
}
