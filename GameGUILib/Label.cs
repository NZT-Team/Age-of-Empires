using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace GameGUILib
{
    class Label
    {
        public Color color;
        public Size size;
        public Point point;
        public string text;

        public Label(string Text, Size x, Color c, Point p)
        {
            this.size = new Size(x.Width, x.Height);
            this.point = new Point(p.X, p.Y);
            this.text = Text;
        }


    }
}
