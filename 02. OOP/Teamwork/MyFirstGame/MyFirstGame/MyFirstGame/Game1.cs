using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace MyFirstGame
{
    /// <summary>
    /// This is the main type for your game
    /// </summary>
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        KeyboardState keyboardState;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
                   
        Texture2D myBall1;

        private Vector2 ballPosition1 = new Vector2(400, 240);
        Vector2 ballSpeed1 = new Vector2(200.0f,200.0f);
        Texture2D myBall2;

        private Vector2 ballPosition2 = Vector2.Zero;
        Vector2 ballSpeed2 = new Vector2(200.0f, 200.0f);
        int ball1Height;
        int ball1Width;
        int ball2Height;
        int ball2Width;
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            myBall1 = this.Content.Load<Texture2D>("ball");
            myBall2 = this.Content.Load<Texture2D>("ball");
            ball1Height = myBall1.Height;
            ball1Width = myBall1.Width;
            ball2Height = myBall2.Height;
            ball2Width = myBall2.Width;
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// all content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime) // moves the images
        {
            // Allows the game to exit
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed)
                this.Exit();

            // TODO: Add your update logic here
            // first ball moves automatically, wall to wall and bounces
            ballPosition1 +=
        ballSpeed1 * (float)gameTime.ElapsedGameTime.TotalSeconds;

            int MaxX =
        graphics.GraphicsDevice.Viewport.Width - myBall1.Width;
            int MinX = 0;
            int MaxY =
                graphics.GraphicsDevice.Viewport.Height - myBall1.Height;
            int MinY = 0;

            if (ballPosition1.X > MaxX)
            {
                ballSpeed1.X *= -1;
                ballPosition1.X = MaxX;
            }

            else if (ballPosition1.X < MinX)
            {
                ballSpeed1.X *= -1;
                ballPosition1.X = MinX;
            }

            if (ballPosition1.Y > MaxY)
            {
                ballSpeed1.Y *= -1;
                ballPosition1.Y = MaxY;
            }
            else if (ballPosition1.Y < MinY)
            {
                ballSpeed1.Y *= -1;
                ballPosition1.Y = MinY;
            }

            // second ball does not move automatically, gets only moved with Up, Down. Left, Right keys

            //ballPosition2 +=
        //ballSpeed2 * (float)gameTime.ElapsedGameTime.TotalSeconds;

            int MaxX2 =
        graphics.GraphicsDevice.Viewport.Width - myBall2.Width;
            int MinX2 = 0;
            int MaxY2 =
                graphics.GraphicsDevice.Viewport.Height - myBall2.Height;
            int MinY2 = 0;

            keyboardState = Keyboard.GetState();

            if (keyboardState.IsKeyDown(Keys.Left))
                ballPosition2.X -= 10f;

            if (keyboardState.IsKeyDown(Keys.Right))
                ballPosition2.X += 10f;

            if (keyboardState.IsKeyDown(Keys.Down))
                ballPosition2.Y += 10f;

            if (keyboardState.IsKeyDown(Keys.Up))
                ballPosition2.Y -= 10f;

            // check for collision
            CheckForCollision();

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        /// 
        /// draws the images and the background
        protected override void Draw(GameTime gameTime)
        {
            // drwas background
            GraphicsDevice.Clear(Color.Orange);

            spriteBatch.Begin(SpriteSortMode.BackToFront, BlendState.AlphaBlend);

            // draws the loaded images
            spriteBatch.Draw(myBall1, ballPosition1, Color.Red);
            spriteBatch.Draw(myBall2, ballPosition2, Color.Red);
            spriteBatch.End();

            base.Draw(gameTime);
        }

        void CheckForCollision()
        {
            // first ball dimentions
            BoundingBox bb1 = new BoundingBox(new Vector3(ballPosition1.X - (ball1Width / 2 - 12), ballPosition1.Y - (ball1Height / 2 - 12), 0), new Vector3(ballPosition1.X + (ball1Width / 2 - 12), ballPosition1.Y + (ball1Height / 2 - 12), 0));
            // second ball dimentions
            BoundingBox bb2 = new BoundingBox(new Vector3(ballPosition2.X - (ball2Width / 2 - 12), ballPosition2.Y - (ball2Height / 2 - 12), 0), new Vector3(ballPosition2.X + (ball2Width / 2 - 12), ballPosition2.Y + (ball2Height / 2 - 12), 0));
            
            // if they intersect = we have collision
            if (bb1.Intersects(bb2))
            {
                // decide what effect we want in case of collision
                Window.Title = "OH NO PIRATES AGAIN! SOMEBODY HELP US!!!";
                ballPosition1.X = 0;
                ballPosition1.Y = 0;
            }
        }
    }
}
