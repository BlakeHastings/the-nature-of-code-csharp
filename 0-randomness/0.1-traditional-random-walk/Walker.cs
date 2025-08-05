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

    public Walker(int width, int height)
    {
        X = width / 2;
        Y = height / 2;
    }

    public void Show(SpriteBatch spriteBatch, Texture2D pointTexture)
    {
        spriteBatch.Draw(pointTexture, new Rectangle(X,Y, 5, 5), Color.Black);
    }

}