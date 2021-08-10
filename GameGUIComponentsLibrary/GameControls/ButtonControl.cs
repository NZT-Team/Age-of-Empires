using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Drawing;

public class Button : Game
{
	int buttonX, buttonY;
    int Width, Height;
    Texture2D texture;
    MouseState lastMouseState;
    Color color;

   

    public Button(string name, Texture2D texture, int buttonX, int buttonY, Color color,int width,int height)
    {
        this.Name = name;
        this.Texture = texture;
        this.buttonX = buttonX;
        this.buttonY = buttonY;
        this.color = color;
        this.Height = height;
        this.Width = width;
    }

    public void Update(GameTime gameTime)
    {
        MouseState currentMouseState = Mouse.GetState();
        if (enterButton() && lastMouseState.LeftButton == ButtonState.Released && currentMouseState.LeftButton == ButtonState.Pressed)
        {
            switch (Name)
            {
                case "start": 
                    //startgame
                    break;
                default:
                    break;
            }
        }
    }

    public bool enterButton()
    {
        if (lastMouseState.X < buttonX + texture.Width &&
                    lastMouseState.X > buttonX &&
                    lastMouseState.Y < buttonY + texture.Height &&
                    lastMouseState.Y > buttonY)
        {
            return true;
        }
        return false;
    }




}
