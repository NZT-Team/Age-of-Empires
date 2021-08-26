using System;
using System.Drawing;

namespace GameGUILib
{
    public class Button
    {

        public Color color;
        public Size size;
        public Point point;
        public Color backcolor;
        public string text;
        public bool pressed, focused;



        public enum ButtonsShapes
        {
            Rect,
            RoundRect,
            Circle
        }
        ButtonsShapes buttonShape;

        public Button(string Text, Size x, Color c, Point p)
        {
            this.size = new Size(x.Width, x.Height);
            this.point = new Point(p.X, p.Y);
            this.backcolor = c;
            this.text = Text;
        }
        public Point GetTextPosition() => new Point(this.point.X+this.size.Width/10, this.point.Y + this.size.Height / 10);
        public Rectangle GetButtonRect() => new Rectangle(this.point.X,this.point.Y,this.size.Width,this.size.Height);

        protected void OnMouseLeave(EventArgs e)
        {
            focused = false;
        }

        protected void OnMouseEnter(EventArgs e)
        {
            focused = true;
        }

        protected void OnMouseDown(EventArgs e)
        {
            pressed = true;
        }

        protected void OnMouseUp(EventArgs e)
        {
            pressed = false;
        }


    }
}
