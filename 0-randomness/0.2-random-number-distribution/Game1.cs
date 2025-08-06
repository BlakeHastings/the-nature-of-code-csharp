using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace _0._2_random_number_distribution;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    // chapter specific parts
    private const int TOTAL = 20;
    private readonly int[] _randomCounts = new int[TOTAL];
    private readonly Random _random = new();
    private Texture2D _rectTexture;

    private (int Width, int Height) WindowSize = (640, 240);

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;

        _graphics.PreferredBackBufferHeight = WindowSize.Height;
        _graphics.PreferredBackBufferWidth = WindowSize.Width;
    }

    protected override void Initialize()
    {
        Array.Fill(_randomCounts, 0);
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);


        _rectTexture = new Texture2D(GraphicsDevice, 1, 1);
        _rectTexture.SetData([Color.DarkBlue]);
        // TODO: use this.Content to load your game content here
    }

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.WhiteSmoke);

        var index = (int)Math.Floor((decimal)_random.Next(TOTAL));
        _randomCounts[index]++;

        var w = WindowSize.Width / TOTAL;

        _spriteBatch.Begin();
        for (var x = 0; x < _randomCounts.Length; x++)
        {
            _spriteBatch.Draw(
                _rectTexture,
                new Rectangle(
                    x * w,
                    WindowSize.Height - _randomCounts[x],
                    w - 1,
                    _randomCounts[x]
                ),
                Color.Blue
                );
        }
        _spriteBatch.End();

        base.Draw(gameTime);
    }
}
