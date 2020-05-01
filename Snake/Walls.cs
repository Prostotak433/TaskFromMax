﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Walls
    {
        private char ch;
        private List<Point> wall = new List<Point>();
        private void DrawHorizontal(int x, int y)
        {
            for(int i = 0; i < x; i++)
            {
                Point p = (i, y, ch);
                p.Draw();
                wall.Add(p);
            }
        }
        private void DrawVertical(int x, int y)
        {
            for(int i = 0; i < y; i++)
            {
                Point p = (x, i, ch);
                p.Draw();
                wall.Add(p);
            }
        }
        public Walls(int x, int y, char ch)
        {
            this.ch = ch;
            DrawHorizontal(x, 0);
            DrawHorizontal(x, y);
            DrawVertical(0, y);
            DrawVertical(x, y);
        }
    }
}
