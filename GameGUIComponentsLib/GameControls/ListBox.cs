using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;

namespace GameGUIComponentsLib.GameControls
{
    class ListBox
    {
        private Color color;
        private Size size;
        private Point point;
        private string text;
        private int index;
        private int count;

        public ListBox(string Text, Size x, Color c, Point p,int ind, int count)
        {
            this.size = new Size(x.Width, x.Height);
            this.point = new Point(p.X, p.Y);
            this.text = Text;
            this.index = ind;
            this.color = c;
            this.count = count;

        }
    }
}
