using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_RTS_Game
{
    public abstract class Character : Tile
    {
        protected int hp;
        protected int maxHp;
        protected int damage;
        protected Tile[] vision;


        public int Hp { get => hp; set => hp = value; }
        public int MaxHp { get => maxHp; set => maxHp = value; }
        public int Damage { get => damage; set => damage = value; }
        public Tile[] Vision { get => vision; set => vision = value; }


        public enum Movement { Idle, Up, Down, Right, Left }

        public Character(int hp, int damage, int maxHp, int x, int y, char symbol) : base(x, y, symbol)
        {
            this.hp = hp;
            this.damage = damage;
            this.maxHp = maxHp;
        }

        public virtual bool CheckRange(Character target)
        {
            int range = DistanceTo(target);

            if (range <= 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int DistanceTo(Character target)
        {
            return (Math.Abs(X - target.X) + Math.Abs(Y - target.Y));
        }

        public void Move(Movement move)
        {
            switch (move)
            {
                case Movement.Idle: //How to show IDLE position
                    break;
                case Movement.Up:
                    Y++; 
                    break;
                case Movement.Down:
                    Y--;
                    break;
                case Movement.Right:
                    x++;
                    break;
                case Movement.Left:
                    x--;
                    break;
                default:
                    break;
            }
        }

        public abstract Movement ReturnMove(Movement move = 0);

        public abstract override string ToString();
    }
}
