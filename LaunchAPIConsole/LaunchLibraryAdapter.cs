using Flurl.Http;
using LaunchAPIConsole.ApiModels.LaunchLibrary.Launches;
using LaunchAPIConsole.ModelsDB;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Threading.Tasks;

namespace LaunchAPIConsole
{
    /// <summary>
    /// make Launch model from API
    /// </summary>
    public class LaunchLibraryAdapter
    {
        private dynamic launchLibraryJson;
        private string serializedJson;

        // string link = "https://launchlibrary.net/1.4/launch/next/1";

        public async Task<Launch> GetLaunchesModel(string link, int launchNumber)
        {
            launchLibraryJson = await link.GetJsonAsync();
            serializedJson = JsonConvert.SerializeObject(launchLibraryJson);

            LaunchLibraryCollection launchLibraryLaunches = JsonConvert.DeserializeObject<LaunchLibraryCollection>(serializedJson);

            return AssignModel(launchLibraryLaunches, launchNumber);
        }

        private Launch AssignModel(LaunchLibraryCollection apiLaunchModel, int launchNumber)
        {
            Launch dbLaunchModel = new Launch();

            dbLaunchModel.LaunchId = apiLaunchModel.Launches[launchNumber].LaunchId;
            dbLaunchModel.MissionName = apiLaunchModel.Launches[launchNumber].LaunchName;

            dbLaunchModel.LaunchDate = DateTime.ParseExact(apiLaunchModel.Launches[launchNumber].LaunchTime, "MMMM dd, yyyy HH:mm:ss UTC", CultureInfo.InvariantCulture);
            dbLaunchModel.LaunchSite = apiLaunchModel.Launches[launchNumber].Location.LocationName;
            dbLaunchModel.RocketName = apiLaunchModel.Launches[launchNumber].Rocket.Name;
            dbLaunchModel.MissionDetails = apiLaunchModel.Launches[launchNumber].Missions[0].MissionName;
            dbLaunchModel.InfoUrl = apiLaunchModel.Launches[launchNumber].InfoUrl;
            dbLaunchModel.ChangedTime = DateTime.Parse(apiLaunchModel.Launches[launchNumber].Changed, CultureInfo.InvariantCulture);

            return dbLaunchModel;
        }
    }
}
