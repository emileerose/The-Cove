using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace The_Cove
{
    class Input
    {
        public bool left, right, up, down, accept, deny, pause;
        public GameStateManager gsm;
        public KeyboardState state;
        #region Actions
        public enum Action
        {
            Left,
            Right,
            Up,
            Down,
            Ok,
            Back,
            Start
        }

        public readonly string[] actionNames =
        {
            "Left",
            "Right",
            "Up",
            "Down",
            "Ok",
            "Back",
            "Start"
        };
        public enum GamePadButtons
        {
            A,
            B,
            X,
            Y,
            Start,
            Select,
            Up,
            Down,
            Left,
            Right,
            LeftShoulder,
            RightShoulder,
            LeftTrigger,
            RightTrigger
        }
        public string getActionName(Action action)
        {
            int index = (int)action;
            if (index < 0 || index > actionNames.Length) throw new ArgumentOutOfRangeException("Action");
            return actionNames[index];
        }

        #endregion


        public Input(GameStateManager gsm)
        {
            this.gsm = gsm;
        }

        public void InputUpdate()
        {
            KeyboardState state = Keyboard.GetState();

            foreach(KeyValuePair<Keys, string> keybind in gsm.getKeybinds().keybinds)
            {
                if (state.IsKeyDown(keybind.Key))
                {
                    switch(keybind.Value)
                    {
                        default:
                            break;
                        case "left":
                            left = true;
                            break;
                        case "right":
                            right = true;
                            break;
                        case "up":
                            up = true;
                            break;
                        case "down":
                            down = true;
                            break;
                        case "accept":
                            accept = true;
                            break;
                        case "deny":
                            deny = true;
                            break;
                        case "pause":
                            pause = true;
                            break;
                    }
                }

                if (state.IsKeyUp(keybind.Key))
                {
                    switch (keybind.Value)
                    {
                        default:
                            break;
                        case "left":
                            left = false;
                            break;
                        case "right":
                            right = false;
                            break;
                        case "up":
                            up = false;
                            break;
                        case "down":
                            down = false;
                            break;
                        case "accept":
                            accept = false;
                            break;
                        case "deny":
                            deny = false;
                            break;
                        case "pause":
                            pause = false;
                            break;
                    }
                }
            }
        }

        public class ActionMap
        {
            public List<GamePadButtons> gamePadButtons = new List<GamePadButtons>();
            public List<Keys> keyboardKeys = new List<Keys>();
        }

    }
}
