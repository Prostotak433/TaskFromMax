using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Program
    {
        static readonly int x = 80;
        static readonly int y = 30;
        static Walls walls;
        static Timer time;
        static FoodFactory foodFactory;
        static Snake snake;

        static void Main(string[] args)
        {
            Console.SetWindowSize(x + 1, y + 1);
            Console.SetBufferSize(x + 1, y + 1);
            Console.CursorVisible = false;
            walls = new Walls(x, y, '#');
            foodFactory = new FoodFactory(x, y, '@');
            foodFactory.CreateFood();
            snake = new Snake(x / 2, y / 2, 3);
            time = new Timer(Loop, null, 0, 200);
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Rotation(key.Key);
                }
            }
        }
        static void Loop(object obj)
        {
            if (walls.IsHit(snake.GetHead()) || snake.IsHit(snake.GetHead()))
            {
                time.Change(0, Timeout.Infinite);
            }
            else if (snake.Eat(foodFactory.food))
            {
                foodFactory.CreateFood();
            }
            else
            {
                snake.Move();
            }
        }
    }
}
