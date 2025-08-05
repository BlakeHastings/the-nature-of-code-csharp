using System;
using System.Drawing;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Color = Microsoft.Xna.Framework.Color;
using Rectangle = Microsoft.Xna.Framework.Rectangle;

namespace _0._1_traditional_random_walk;

public class Walker
{
    private int X;
    private int Y;
    private readonly Random _random;

    public Walker(int width, int height)
    {
        X = width / 2;
        Y = height / 2;
        this._random = new Random();
    }

    public void Update()
    {
        var xStep = _random.Next(-1, 2);
        var yStep = _random.Next(-1, 2);

        this.X += xStep;
        this.Y += yStep;
    }

    public void Draw(SpriteBatch spriteBatch, Texture2D pointTexture)
    {
        spriteBatch.Draw(pointTexture, new Rectangle(X, Y, 5, 5), Color.Black);
    }

}