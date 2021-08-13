using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;

namespace GameGUIComponentsLib.GameControls
{
    class TextBox
    {
        private Color color;
        private Size size;
        private Point point;
        private string text;
        private bool multiline;

        public TextBox(string Text, Size x, Color c, Point p, bool mul)
        {
            this.size = new Size(x.Width, x.Height);
            this.point = new Point(p.X, p.Y);
            this.text = Text;
            this.multiline = mul;
            
        }
    }
}
