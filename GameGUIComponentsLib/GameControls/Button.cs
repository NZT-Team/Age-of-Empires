using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using System.Data;
using System.Drawing.Drawing2D;


namespace GameGUIComponentsLib.GameControls
{
    public class Button 
    {

        private Color color;
        private Size size;
        private Point point;
        private Color backcolor;
        private string text;
        
        private bool pressed, focused;


        public enum ButtonsShapes
        {
            Rect,
            RoundRect,
            Circle
        }
        ButtonsShapes buttonShape;

        public Button(string Text,Size x, Color c,Point p)
        {
            this.size = new Size(x.Width,x.Height);
            this.point = new Point(p.X, p.Y);
            this.backcolor = c;
            this.text = Text;
        }

        protected  void OnMouseLeave(EventArgs e)
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
