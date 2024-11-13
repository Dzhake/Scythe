using FlatRedBall;
using Microsoft.Xna.Framework;

namespace Scythe
{
    public partial class Engine : Game
    {
        GraphicsDeviceManager graphics;

        
        partial void GeneratedInitializeEarly();
        partial void GeneratedInitialize();
        partial void GeneratedUpdate(GameTime gameTime);
        partial void GeneratedDrawEarly(GameTime gameTime);
        partial void GeneratedDraw(GameTime gameTime);

        public Engine()
        {
            graphics = new GraphicsDeviceManager(this);

#if  ANDROID || IOS
            graphics.IsFullScreen = true;
#endif
        }

        protected override void Initialize()
        {
            #if IOS
            var bounds = UIKit.UIScreen.MainScreen.Bounds;
            var nativeScale = UIKit.UIScreen.MainScreen.Scale;
            var screenWidth = (int)(bounds.Width * nativeScale);
            var screenHeight = (int)(bounds.Height * nativeScale);
            graphics.PreferredBackBufferWidth = screenWidth;
            graphics.PreferredBackBufferHeight = screenHeight;
            #endif
        
            GeneratedInitializeEarly();

            FlatRedBallServices.InitializeFlatRedBall(this, graphics);

            GeneratedInitialize();

            base.Initialize();
        }

        protected override void Update(GameTime gameTime)
        {
            FlatRedBallServices.Update(gameTime);

            FlatRedBall.Screens.ScreenManager.Activity();

            GeneratedUpdate(gameTime);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GeneratedDrawEarly(gameTime);

            FlatRedBallServices.Draw();

            GeneratedDraw(gameTime);

            base.Draw(gameTime);
        }
    }
}
