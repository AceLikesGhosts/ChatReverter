using Rocket.API;

namespace ChatReverter
{
    public class Configuration : IRocketPluginConfiguration
    {
        public bool ShowAdmins;
        public bool ShowPro;
        public void LoadDefaults()
        {
            ShowAdmins = true;
            ShowPro = true;
        }
    }
}
