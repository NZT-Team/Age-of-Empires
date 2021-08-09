using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Drawing;

namespace GameGUIComponentsLibrary
{
    public class GameButton : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Point mousepos;

        Point btnsize = new Point(100, 100);
        Point btnlocation = new Point(100, 100);
        Color btncolor;
        Rectangle btnrectangle;
        Texture2D texture;

        bool pressed, focused;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (Mouse.GetState().LeftButton == ButtonState.Pressed)
            {
                mouseposition = new Vector2(currentMouseState.X, currentMouseState.Y);

                pressed = true;

            }
            else
            {
                pressed = false;
            }

            if (Collide())
                focused = true;
            else
                focused = false;
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            _spriteBatch.Begin();

            btnrectangle = new Microsoft.Xna.Framework.Rectangle(btnlocation, btnsize);
            Microsoft.Xna.Framework.Color color = new Microsoft.Xna.Framework.Color(255, 255, 0); // color yellow
            _spriteBatch.Draw(texture, btnrectangle, color);
            _spriteBatch.End();




            base.Draw(gameTime);
        }

        protected bool Collide()
        {





            return false;
        }
    }
}
