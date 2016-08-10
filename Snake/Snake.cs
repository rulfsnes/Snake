using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{
    class Position
    {
        public int X;
        public int Y;
    }

    class Snake{
        private bool Alive;
        Position position;
        Snake(Position position)
        {
            this.position = position;
        }
    }
}
