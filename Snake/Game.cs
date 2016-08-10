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

    class Game
    {

        private int maxWidth;
        private int maxHeight;
        private int minWidth;
        private int minHeight;
        public Game()
        {
            this.Offset = 1;
        }
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

        private bool Increment;
        public double Offset { get; set; }

        public void updateBackground()
        {
            if (this.Offset < 0.1)
            {
                this.Increment = true;
            }
            else if (this.Offset > 0.9)
            {
                this.Increment = false;
            }
            if (this.Offset <= 1 && this.Increment)
            {
                this.Offset += 0.1;
            }
            else if (this.Offset > 0 && !this.Increment)
            {
                this.Offset -= 0.1;
            }
        }
    }
}


