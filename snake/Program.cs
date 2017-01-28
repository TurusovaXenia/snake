using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Walls walls = new Walls(80, 25);
            walls.Draw();

            //рисуем точки
            Point p = new Point(4, 5, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            FoodCreator foodcreat = new FoodCreator(80, 25, '&');
            Point food = foodcreat.CreateFood();
            food.Draw();

            while (true)
            {
                if(walls.IsHit(snake)|| snake.IsHitTail())
                {
                    break;
                }
                if (snake.Eat(food))
                {
                    food = foodcreat.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Go(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
        }

    }
}
