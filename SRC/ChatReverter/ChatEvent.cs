using Rocket.Unturned.Player;
using SDG.Unturned;
using UnityEngine;

namespace ChatReverter
{
    class ChatEvent
    {
        Configuration config;
        public void OnChat(UnturnedPlayer player, ref Color color, string msg, EChatMode chatMode, ref bool cancel)
        {
            config = new Configuration();
            if (msg.StartsWith("/"))
                return;
            if (player.IsAdmin)
            {
                if (config.ShowPro == true)
                {
                    color = Color.cyan;
                }
                else
                {
                    color = Color.white;
                }
            }
            if (player.IsPro)
            {
                if (config.ShowPro == true)
                {
                    color = Color.yellow;
                }
                else
                {
                    color = Color.white;
                }
            }
            if (!player.IsPro)
                color = Color.white;
        }
    }
}
