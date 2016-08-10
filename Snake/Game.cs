using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Game
    {
        private int maxWidth;
        private int maxHeight;
        private int minWidth;
        private int minHeight;
        public bool checkBounds(Position position)
        {
            if((position.Y > this.maxHeight) || (position.Y < this.minHeight))
            {
                return false;
            }
            else if((position.X > this.maxWidth) || (position.X < this.minWidth))
            {
                return false;
            }
            else
            {
                return true;  
            }

        }
    }
}
