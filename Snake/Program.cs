using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake
{
    class Program
    {
        static readonly int x = 80;
        static readonly int y = 30;
        static Walls walls;
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
        }
    }
}
