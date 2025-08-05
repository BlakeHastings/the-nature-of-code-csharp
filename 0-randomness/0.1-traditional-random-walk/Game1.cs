using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _0._1_traditional_random_walk;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;
    private Texture2D _pointPixel;
    private Walker _walker;
    private bool _backgroundDrawn = false;

    private (int Width, int Height) WindowSize = (640, 240);

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;

        _graphics.PreferredBackBufferHeight = WindowSize.Height;
        _graphics.PreferredBackBufferWidth = WindowSize.Width;

        _walker = new Walker(WindowSize.Width, WindowSize.Height);
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);

        _pointPixel = new Texture2D(GraphicsDevice, 1, 1);
        _pointPixel.SetData([Color.Black]);
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here
        _walker.Update();
        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        if (!_backgroundDrawn)
        {
           GraphicsDevice.Clear(Color.CornflowerBlue);
            _backgroundDrawn = true;
        }
            

        _spriteBatch.Begin();
        _walker.Draw(_spriteBatch, _pointPixel);
        _spriteBatch.End();
        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}
