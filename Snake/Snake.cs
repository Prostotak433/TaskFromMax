using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;

namespace Snake
{
    enum Direction
    {
        LEFT,
        RIGHT,
        UP,
        DOWN
    }
    class Snake
    {
        private Direction direction;
        private List<Point> snake;
        private int step = 1;
        private Point tail;
        private Point head;
        bool rotate = true;
        public Snake(int x, int y, int length)
        {
            direction = Direction.RIGHT;
            snake = new List<Point>();
            for(int i = x - length; i < x; i++)
            {
                Point p = (i, y, '*');
                snake.Add(p);
                p.Draw();
            }
        }
        public Point GetHead() => snake.Last();
        public Point GetNextPoint()
        {
            Point p = GetHead();
            switch(direction)
            {
                case Direction.LEFT: p.x -= step;
                    break;
                case Direction.RIGHT: p.x += step;
                    break;
                case Direction.UP: p.y -= step;
                    break;
                case Direction.DOWN: p.y += step;
                    break;
            }
            return p;
        }
        public void Move()
        {
            head = GetNextPoint();
            snake.Add(head);
            tail = snake.First();
            snake.Remove(tail);
            tail.Clear();
            head.Draw();
            rotate = true;
        }
        public void Rotation(ConsoleKey key)
        {
            if(rotate)
            {
                switch(direction)
                {
                    case Direction.LEFT:
                    case Direction.RIGHT:
                        if (key == ConsoleKey.DownArrow)
                            direction = Direction.DOWN;
                        else if (key == ConsoleKey.UpArrow)
                            direction = Direction.UP;
                        break;
                    case Direction.UP:
                    case Direction.DOWN:
                        if (key == ConsoleKey.LeftArrow)
                            direction = Direction.LEFT;
                        else if (key == ConsoleKey.DownArrow)
                            direction = Direction.RIGHT;
                        break;
                }
                rotate = false;
            }
        }
    }
}
