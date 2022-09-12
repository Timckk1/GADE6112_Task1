using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_RTS_Game
{
    public interface IView
    {
        void Output(string text);
        void DeleteTile(Tile t);
        void ShowEndGame();
    }
}
