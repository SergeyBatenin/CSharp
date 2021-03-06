using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Snake
{
    public class Point
    {
        public int x;
        public int y;
        public char sym;

        public Point()
        {            
        }

        public Point(int xCoord, int yCoord, char symbol)
        {
            x = xCoord;
            y = yCoord;
            sym = symbol;
        }

        public Point( Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT) x = x + offset;
            else if (direction == Direction.LEFT) x = x - offset;
            else if (direction == Direction.UP) y = y - offset;
            else if (direction == Direction.DOWN) y = y + offset;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(sym);
        }

        public override string ToString()
        {
            return x + ", " + y + ", " + sym;
        }

        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        internal bool IsHit(Point p)
        {
            if (this.x == p.x && this.y == p.y) return true;
            else return false;
        }
    }
}