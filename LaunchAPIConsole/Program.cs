using Flurl.Http;
using LaunchAPIConsole.ApiModels.LaunchLibrary;
using LaunchAPIConsole.ApiModels.LaunchLibrary.Launches;
using LaunchAPIConsole.ApiModels.SpaceX.Launches;
using LaunchAPIConsole.ModelsDB;
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

            //test new adapter
            LaunchLibraryAdapter adapter = new LaunchLibraryAdapter();
            
            for(int i = 0; i < 5; i++)
            {
                Launch launch = await adapter.GetLaunchesModel("https://launchlibrary.net/1.4/launch/next/10", i);

                Console.WriteLine("\n");
                Console.WriteLine(launch.MissionName);
                Console.WriteLine(launch.LaunchSite);
                Console.WriteLine(launch.MissionDetails);
                Console.WriteLine(launch.LaunchDate);
                Console.WriteLine(launch.ChangedTime);
                Console.WriteLine(launch.InfoUrl);
                Console.WriteLine(launch.Country);
                Console.WriteLine(launch.RocketName);
                Console.WriteLine(launch.Agency);
            }
        }
    }
}
