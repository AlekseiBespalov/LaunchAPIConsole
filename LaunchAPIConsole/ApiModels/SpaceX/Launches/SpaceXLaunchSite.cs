using Newtonsoft.Json;

namespace LaunchAPIConsole.ApiModels.SpaceX.Launches
{
    public class SpaceXLaunchSite
    {
        [JsonProperty(PropertyName = "site_id")]
        public string SiteId { get; set; }

        [JsonProperty(PropertyName = "site_name")]
        public string SiteName { get; set; }

        [JsonProperty(PropertyName = "site_name_long")]
        public string SiteNameLong { get; set; }
    }
}
