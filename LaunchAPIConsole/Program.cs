using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Threading;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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

            for (int i = 0; i <= LibrarylaunchCollection.launches.Count - 1; i++)
            {
                Console.WriteLine(LibrarylaunchCollection.launches[i].Id);
                Console.WriteLine(LibrarylaunchCollection.launches[i].Name);
                Console.WriteLine(LibrarylaunchCollection.launches[i].Net);
                Console.WriteLine(LibrarylaunchCollection.launches[i].VidURLs[0]);
                Console.WriteLine(LibrarylaunchCollection.launches[i].Rocket.Name);
            }

            dynamic SpaceXText = await "https://api.spacexdata.com/v3/launches/next".GetJsonAsync();
            string SpaceXoutput = JsonConvert.SerializeObject(SpaceXText);
            SpaceXLaunchModel SpaceXLaunch = JsonConvert.DeserializeObject<SpaceXLaunchModel>(SpaceXoutput);

            Console.WriteLine("SPACEX LAUNCH");
            Console.WriteLine(SpaceXLaunch.Flight_number);
            Console.WriteLine(SpaceXLaunch.Details);
            Console.WriteLine(SpaceXLaunch.Rocket.Rocket_Id);
        }
    }
}
