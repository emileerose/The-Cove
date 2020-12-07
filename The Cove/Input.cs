using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace The_Cove
{
    class Input
    {
        bool left, right, up, down, accept, deny, pause;
        public GameStateManager gsm;
        public KeyboardState state;

        public Input(GameStateManager gsm)
        {
            this.gsm = gsm;
        }
        public void ProcessKeyboardInput()
        {
            state = Keyboard.GetState();
            
            foreach(string key in gsm.getKeybinds().keybinds.Keys)
            {

            }

            
        }

    }
}
