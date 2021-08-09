using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

public class Button : Game
{
	int buttonX, buttonY;
    Texture2D texture;
    MouseState lastMouseState;

    public int ButtonX
    {
        get
        {
            return buttonX;
        }
    }

    public int ButtonY
    {
        get
        {
            return buttonY;
        }
    }

    public Button(string name, Texture2D texture, int buttonX, int buttonY)
    {
        this.Name = name;
        this.Texture = texture;
        this.buttonX = buttonX;
        this.buttonY = buttonY;
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
