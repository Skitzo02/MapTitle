susing Steamworks;

namespace Oxide.Plugins
{
    [Info("MapTitle", "Kenji", "0.1")]
    [Description("A plugin to allow you to change your map title to your server name or discord invite")]
    public class MapTitle: RustPlugin
    {
        private void OnServerInformationUpdated() => SteamServer.MapName = "Server Name or Discord invite";
    }
}
