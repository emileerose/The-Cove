using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace The_Cove
{
    class DebugState : GameState
    {

        

        public DebugState(GameStateManager gsm) : base(gsm)
        {

        }
        
        public override void doRender(GameTime gt)
        {

        }

        public override void doProcessing(GameTime gt)
        {
            if (gsm.getInput().left)
            {
                gsm.getSaveManager().WriteKeybinds(gsm.getKeybinds().keybinds);
                Console.WriteLine("Wrote keybinds to file.");
            }
        }
    }
}
