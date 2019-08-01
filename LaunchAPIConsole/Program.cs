using Flurl.Http;
using LaunchAPIConsole.ApiModels.LaunchLibrary.Launches;
using LaunchAPIConsole.ApiModels.SpaceX.Launches;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace LaunchAPIConsole
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("ROCKET LAUNCHES");
            await DownloadJSONData();
        }

        private static async Task DownloadJSONData()
        {
            dynamic LaunchLibraryText = await "https://launchlibrary.net/1.4/launch/1388".GetJsonAsync();
            string output = JsonConvert.SerializeObject(LaunchLibraryText);
            LaunchLibraryCollection LibrarylaunchCollection = JsonConvert.DeserializeObject<LaunchLibraryCollection>(output);

            //JObject parsedJson = JObject.Parse(output);

            for (int i = 0; i <= LibrarylaunchCollection.Launches.Count - 1; i++)
            {
                Console.WriteLine(LibrarylaunchCollection.Launches[i].LaunchId);
                Console.WriteLine(LibrarylaunchCollection.Launches[i].LaunchName);
                Console.WriteLine(LibrarylaunchCollection.Launches[i].LaunchTime);
                Console.WriteLine(LibrarylaunchCollection.Launches[i].VidUrls[0]);
                Console.WriteLine(LibrarylaunchCollection.Launches[i].Rocket.Name);
                Console.WriteLine(LibrarylaunchCollection.Launches[i].Location.CountryCode);
            }

            dynamic SpaceXText = await "https://api.spacexdata.com/v3/launches/next".GetJsonAsync();
            string SpaceXoutput = JsonConvert.SerializeObject(SpaceXText);
            SpaceXLaunchModel SpaceXLaunch = JsonConvert.DeserializeObject<SpaceXLaunchModel>(SpaceXoutput);

            Console.WriteLine("SPACEX LAUNCH");
            Console.WriteLine(SpaceXLaunch.Id);
            Console.WriteLine(SpaceXLaunch.Details);
            Console.WriteLine(SpaceXLaunch.Rocket.RocketId);
            Console.WriteLine(SpaceXLaunch.LaunchDateLocal);
        }
    }
}
