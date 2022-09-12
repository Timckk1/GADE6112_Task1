using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE6112_RTS_Game
{
    public abstract class Tile
    {
        public enum TileType { Hero, Enemy, Gold, Weapon }

        protected int x;
        protected int y;
        protected char symbol;
        public char Symbol { get => symbol; set => symbol = value; }
        public Button button;

        public int X { get => x; set => x = value; }
        public int Y { get => y; set => y = value; }
        public Button Button { get => button; set => button = value; }

        public Tile(int x, int y, char smbl)
        {
            X = x;
            Y = y;
            symbol = smbl;
        }
    }
}
