using Flurl.Http;
using LaunchAPIConsole.ApiModels.LaunchLibrary;
using LaunchAPIConsole.ApiModels.LaunchLibrary.Launches;
using LaunchAPIConsole.ApiModels.SpaceX.Launches;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LaunchAPIConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await DownloadJSONData();
        }

        // test method
        private static async Task DownloadJSONData()
        {
            Console.WriteLine("All rocket launches");
            dynamic launchLibraryText = await "https://launchlibrary.net/1.4/launch/1388".GetJsonAsync();
            string launchLibraryoutput = JsonConvert.SerializeObject(launchLibraryText);
            LaunchLibraryCollection LibrarylaunchCollection = JsonConvert.DeserializeObject<LaunchLibraryCollection>(launchLibraryoutput);

            for (int i = 0; i <= LibrarylaunchCollection.Launches.Count - 1; i++)
            {
                Console.WriteLine(LibrarylaunchCollection.Launches[i].LaunchId);
                Console.WriteLine(LibrarylaunchCollection.Launches[i].LaunchName);
                Console.WriteLine(LibrarylaunchCollection.Launches[i].LaunchTime);
                Console.WriteLine(LibrarylaunchCollection.Launches[i].VidUrls[0]);
                Console.WriteLine(LibrarylaunchCollection.Launches[i].Rocket.Name);
                Console.WriteLine(LibrarylaunchCollection.Launches[i].Location.CountryCode);
                Console.WriteLine(LibrarylaunchCollection.Launches[i].Location.Pads[0].PadName);
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("Next spacex launch");
            dynamic spaceXText = await "https://api.spacexdata.com/v3/launches/next".GetJsonAsync();
            string spaceXoutput = JsonConvert.SerializeObject(spaceXText);
            SpaceXLaunchModel SpaceXLaunch = JsonConvert.DeserializeObject<SpaceXLaunchModel>(spaceXoutput);

            Console.WriteLine(SpaceXLaunch.FlightId);
            Console.WriteLine(SpaceXLaunch.Details);
            Console.WriteLine(SpaceXLaunch.Rocket.RocketId);
            Console.WriteLine(SpaceXLaunch.LaunchDateLocal);

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("All launch providers");
            dynamic launchServiceText = await "https://launchlibrary.net/1.4/lsp".GetJsonAsync();
            var output = JsonConvert.SerializeObject(launchServiceText);
            LaunchServiceProviderCollection launchServiceProviders = JsonConvert.DeserializeObject<LaunchServiceProviderCollection>(output);

            foreach(LaunchServiceProvider provider in launchServiceProviders.Agencies)
            {
                Console.WriteLine(provider.ProviderName);
            }

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("All SpaceX launches");
            dynamic spaceXAllText = await "https://api.spacexdata.com/v3/launches".GetJsonListAsync();
            string spaceXAlloutput = JsonConvert.SerializeObject(spaceXAllText);
            List<SpaceXLaunchModel> spaceXAllLaunches = JsonConvert.DeserializeObject<List<SpaceXLaunchModel>>(spaceXAlloutput);

            foreach(SpaceXLaunchModel launch in spaceXAllLaunches)
            {
                Console.WriteLine(launch.MissionName);
            }
        }
    }
}
