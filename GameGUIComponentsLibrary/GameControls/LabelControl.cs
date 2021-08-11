using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Label : Game
{

	Color color;
    private int color1Transparent = 150;
    int labelX, labelY;
	int Width, Height;
	string Text;
    public String DisplayText
    {
        get { return Text; }
        set { Text = value; Invalidate(); }
    }

    public Label(string name, int labelY, int labelX, Color color, int width, int height, string text)
    {
        this.Name = name;
        this.text = text;
        this.labelX = labelX;
        this.labelY = labelY;
        this.color = color;
        this.Height = height;
        this.Width = width;
    }

    public void Draw(PaintEventArgs e)
    {
        this.Text = text;
        Color c1 = Color.FromArgb(color1Transparent, color);
        SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Red);
        e.Graphics.DrawString(this.Text, this.Font, myBrush, new Point(0, 0));
    }
}
