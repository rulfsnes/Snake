using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGame
{


    class Snake{
        private bool Alive;
        Position position;
        Snake(Position position)
        {
            this.position = position;
        }
    }
}
