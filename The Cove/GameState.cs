using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace The_Cove
{
    abstract class GameState
    {
        public GameStateManager gsm;
        public GameState(GameStateManager gsm)
        {
            this.gsm = gsm;
        }

        public abstract void doRender(GameTime gt);
        public abstract void doProcessing(GameTime gt);

    }
}
