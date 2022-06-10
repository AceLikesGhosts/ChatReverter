using Rocket.API;

namespace zRevert
{
    public class Config : IRocketPluginConfiguration
    {
        public bool showPro;
        public bool showAdmins;
        public string defaultColor;

        public void LoadDefaults()
        {
            showPro = true;
            showAdmins = false;
            defaultColor = "grey";
        }
    }
}
