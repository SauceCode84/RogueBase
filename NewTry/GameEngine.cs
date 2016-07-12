using RLNET;

namespace RogueBase
{
    public class GameEngine
    {
        private RLRootConsole rootConsole;

        private int playerX;
        private int playerY;

        public GameEngine(RLRootConsole console)
        {
            rootConsole = console;

            rootConsole.Render += OnRender;
            rootConsole.Update += OnUpdate;
        }
        
        private void OnRender(object sender, UpdateEventArgs e)
        {
            rootConsole.Clear();
            rootConsole.Set(playerX, playerY, RLColor.White, null, '@');
            rootConsole.Draw();
        }

        private void OnUpdate(object sender, UpdateEventArgs e)
        {
            RLKeyPress keyPress = rootConsole.Keyboard.GetKeyPress();

            if (keyPress == null)
            {
                return;
            }

            switch (keyPress.Key)
            {
                case RLKey.Keypad8:
                    playerY--;
                    break;

                case RLKey.Keypad2:
                    playerY++;
                    break;

                case RLKey.Keypad4:
                    playerX--;
                    break;

                case RLKey.Keypad6:
                    playerX++;
                    break;
            }
        }
    }
}
