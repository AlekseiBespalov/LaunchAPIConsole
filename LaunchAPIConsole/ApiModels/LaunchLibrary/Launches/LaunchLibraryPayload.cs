﻿using Newtonsoft.Json;

namespace LaunchAPIConsole.ApiModels.LaunchLibrary.Launches
{
    public class LaunchLibraryPayload
    {
        [JsonProperty(PropertyName = "id")]
        public int PayloadId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string PayloadName { get; set; }
    }
}
