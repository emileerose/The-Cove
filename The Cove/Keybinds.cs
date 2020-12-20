using Microsoft.Xna.Framework.Input;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace The_Cove
{
    class Keybinds
    {

        string[] left = { "Left", null };
        string[] right = { "Right", null };
        string[] up = { "Up", null };
        string[] down = { "Down", null };
        string[] accept = { "A", null };
        string[] deny = { "B", null };
        string[] pause = { "Escape", null };
        public GamePadState gamePadState;
        public Dictionary<Keys, string> keybinds;
        public GameStateManager gsm;

        public Keybinds(GameStateManager gsm)
        {
            this.gsm = gsm;
            keybinds = new Dictionary<Keys, string>();
            keybinds.Add(Keys.Left, "left");
            keybinds.Add(Keys.Right, "right");
            keybinds.Add(Keys.Up, "up");
            keybinds.Add(Keys.Down, "down");
            keybinds.Add(Keys.A, "accept");
            keybinds.Add(Keys.B, "deny");
            keybinds.Add(Keys.Escape, "pause");
        }

        public void ChangeKeybind(Keys oldBind, Keys newBind)
        {
            string temp = keybinds[oldBind];
            keybinds.Remove(oldBind);
            keybinds.Add(newBind, temp);
        }



    }
}
