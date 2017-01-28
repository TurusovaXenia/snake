﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Point
    {
        public int x;
        public int y;
        public char sym;
        
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Point(Point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }
        public void Move(int OffSet, Direction direction)
        {
            if(direction == Direction.RIGHT)
            {
                x = x + OffSet;
            }
            else
                if(direction == Direction.LEFT)
                {
                    x = x - OffSet;
                }
            else if(direction== Direction.UP)
            {
                y = y - OffSet;
            }
            else if(direction == Direction.DOWN)
            {
                y = y + OffSet;
            }
        }
        public bool IsHit(Point p)
        {
            return p.x == this.x && p.y == this.y;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
        }
        public override string ToString()
        {
            return x + "," + y + "," + sym;
        }
    }
}
