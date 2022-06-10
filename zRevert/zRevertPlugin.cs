using Rocket.Core.Plugins;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using Logger = Rocket.Core.Logging.Logger;
using UnityEngine;

namespace zRevert
{
    public class zRevertPlugin : RocketPlugin<Config>
    {
        private Color defaultColor;

        protected override void Load()
        {
            UnturnedPlayerEvents.OnPlayerChatted += onChat;
            defaultColor = stringToUnityColor(Configuration.Instance.defaultColor);
            LoadUnMessage("Loaded");
        }

        protected override void Unload()
        {
            UnturnedPlayerEvents.OnPlayerChatted -= onChat;
            LoadUnMessage("Unloaded");
            base.Unload();
        }

        #region Dumb shit
        private void LoadUnMessage(string var1)
        {
            Logger.Log("========================");
            Logger.Log($"{var1} zRevert by ");
            Logger.Log("@AceLikesGhosts on Github");
            Logger.Log("========================");
        }

        private Color stringToUnityColor(string color)
        {
            Color returnColor;    
            
            switch (color.ToLower())
            {
                case "white":
                    {
                        returnColor = Color.white;
                        break;
                    }
                case "black":
                    {
                        returnColor = Color.black;
                        break;
                    }
                case "yellow":
                    {
                        returnColor = Color.yellow;
                        break;
                    }
                case "red":
                    {
                        returnColor = Color.red;
                        break;
                    }
                case "grey":
                    {
                        returnColor = Color.grey;
                        break;
                    }
                case "gray":
                    {
                        returnColor = Color.gray;
                        break;
                    }
                case "magenta":
                    {
                        returnColor = Color.magenta;
                        break;
                    }
                case "cyan":
                    {
                        returnColor = Color.cyan;
                        break;
                    }
                case "blue":
                    {
                        returnColor = Color.blue;
                        break;
                    }
                case "green":
                    {
                        returnColor = Color.green;
                        break;
                    }
                case "clear":
                    {
                        returnColor = Color.green;
                        break;
                    }
                default:
                    {
                        returnColor = Color.grey;
                        break;
                    }
            }

            return returnColor;
        }
        #endregion

        private void onChat(UnturnedPlayer player, ref Color color, string msg, EChatMode chatMode, ref bool cancel)
        {
            // If the message is a command, return.
            if (msg.StartsWith("/"))
                return;

            // By default set the player's color to the default.
            color = defaultColor;

            // If the config has showPro enabled && the user is a pro user set the color to yellow 
            if (Configuration.Instance.showPro && player.IsPro)
            {
                color = Color.yellow;
            }

            if(Configuration.Instance.showAdmins && player.IsAdmin)
            {
                color = Color.cyan;
            }
        }
    }
}
