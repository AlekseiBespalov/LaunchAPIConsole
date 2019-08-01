using Newtonsoft.Json;
using System.Collections.Generic;

namespace LaunchAPIConsole.ApiModels.LaunchLibrary.Launches
{
    public class LaunchLibraryLocation
    {
        public List<LaunchLibraryPad> Pads { get; set; }

        [JsonProperty(PropertyName = "id")]
        public int LocationId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string LocationName { get; set; }

        public string InfoUrl { get; set; }

        public string WikiUrl { get; set; }

        public string CountryCode { get; set; }
    }
}
