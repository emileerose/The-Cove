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
        public Dictionary<string, string[]> keybinds;
        public GameStateManager gsm;

        public Keybinds(GameStateManager gsm)
        {
            this.gsm = gsm;
            keybinds = new Dictionary<string, string[]>();
            keybinds.Add("left", left);
            keybinds.Add("right", right);
            keybinds.Add("up", up);
            keybinds.Add("down", down);
            keybinds.Add("accept", accept);
            keybinds.Add("deny", deny);
            keybinds.Add("pause", pause);
        }
        public void LoadKeybinds()
        {

        }

    }
}
