using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Monogame3DAnimator
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Model LoadedModel;

        Vector3 CamPos = Vector3.One * 2;

        Matrix View = Matrix.CreateLookAt(Vector3.One * 2, Vector3.Zero, Vector3.Up);
        Matrix Projection = Matrix.CreatePerspectiveFieldOfView(MathHelper.ToRadians(65), 800f / 600f, 0.1f, 500f);

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

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            LoadedModel?.Draw(Matrix.Identity,View,Projection);

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
