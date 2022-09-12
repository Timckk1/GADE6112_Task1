using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADE6112_RTS_Game
{
    class SwampCreature : Enemy
    {
        public SwampCreature(int x, int y, int arrayIndex) : base(10, 1, x, y, 'S', arrayIndex)//SwampCreature denoted with S (Shrek) 
        {

        }

        private Random random = new Random();

        public Movement GetRandomMovement()
        {
            int i = random.Next(1, 4);
            return (Movement)i;
        }

        public override Movement ReturnMove(Movement move = Movement.Idle)
        {
            bool movementIsValid = false;

            Movement movement = GetRandomMovement();
            while (!movementIsValid)
            {
                movement = GetRandomMovement();
                Type targetType = Vision[(int)movement].GetType();
                if (targetType != typeof(Obstacle)) // && targetType!=typeof(Hero) )
                {
                    movementIsValid = true;
                }
            }

            return movement;
        }
    }
}
