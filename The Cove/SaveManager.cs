using Microsoft.Xna.Framework.Input;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace The_Cove
{
    class SaveManager
    {

        public GameStateManager gsm;

        public SaveManager(GameStateManager gsm)
        {
            this.gsm = gsm;
        }

        public void WritePlayerSaveData(Player p)
        {

        }

        public void WriteKeybinds(Dictionary<Keys, string> keybinds)
        {
            string json = JsonConvert.SerializeObject(keybinds, Formatting.Indented);

            if (File.Exists("save"))
            {
                if (File.Exists("save_old")) File.Delete("save_old");
                System.IO.File.Move("save", "save_old");
            }

            File.WriteAllText(@"save", json);
            ReadKeybinds();
        }

        public void ReadKeybinds()
        {
            string saveFile = File.ReadAllText(@"save");
            Dictionary<Keys, string> keybinds = JsonConvert.DeserializeObject<Dictionary<Keys, string>>(saveFile);
            gsm.getKeybinds().keybinds = keybinds;
        }

    }
}
