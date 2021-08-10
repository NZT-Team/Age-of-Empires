using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Drawing;

public class Label : Game
{

	Color color;
	int labelX, labelY;
	int Width, Height;
	string text;

	
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
}
