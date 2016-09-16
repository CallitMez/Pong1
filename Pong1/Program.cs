using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

class Pong : Game
{
    GraphicsDeviceManager graphics;
    SpriteBatch spriteBatch;
    Color background;

    static void Main()
    {
        Pong game = new Pong();
        game.Run();
    }

    public Pong()
    {
        Content.RootDirectory = "Content";
        graphics = new GraphicsDeviceManager(this);
    }

    protected override void LoadContent()
    {
        spriteBatch = new SpriteBatch(GraphicsDevice);
    }

    protected override void Update(GameTime gameTime)
    {
        background = new Color(1f, 1f, 1f);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(background);
    }
}