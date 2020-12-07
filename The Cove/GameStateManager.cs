using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace The_Cove
{
    class GameStateManager
    {

        private Stack<GameState> gameStates;
        private Game1 game;
        private Input input;
        private Keybinds keybinds;
        public GameStateManager(Game1 game)
        {
            this.game = game;
            this.input = new Input(this);
            this.keybinds = new Keybinds(this);
            gameStates = new Stack<GameState>();
            //TODO : Setting GameState to debug, remove this
            pushState(0);
        }

        public void pushState(int stateID)
        {
            gameStates.Push(getState(stateID));
        }

        public GameState popState()
        {
            return gameStates.Pop();
        }

        public GameState getState(int stateID)
        {
            switch (stateID)
            {
                default:
                    return null;
                case 0:
                    return new DebugState(this);
            }
        }

        public void doRenderActive(GameTime gt)
        {
            gameStates.Peek().doRender(gt);
        }

        public void doProccessingActive(GameTime gt)
        {
            gameStates.Peek().doProcessing(gt);
        }

        public GameStateManager gsm() { return this; }
        public Game1 getGame() { return game; }
        public Input getInput() { return input; }
        public Keybinds getKeybinds() { return keybinds; }
    }
}
