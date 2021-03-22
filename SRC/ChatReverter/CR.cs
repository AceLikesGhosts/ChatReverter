using Rocket.Core.Plugins;
using Rocket.Unturned.Events;
using Logger = Rocket.Core.Logging.Logger;

namespace ChatReverter
{
    public class CR : RocketPlugin<Configuration>
    {
        ChatEvent ce;
        protected override void Load()
        {
            ce = new ChatEvent();
            UnturnedPlayerEvents.OnPlayerChatted += ce.OnChat; Logger.Log("Registered onChatEvent.");
        }

        protected override void Unload()
        {
            UnturnedPlayerEvents.OnPlayerChatted -= ce.OnChat; Logger.Log("Unregistered onChatEvent.");
        }
    }
}
