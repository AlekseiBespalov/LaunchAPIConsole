using System.Collections.Generic;

namespace LaunchAPIConsole.ApiModels.SpaceX.Launches
{
    /// <summary>
    /// GET request for getting all launches
    /// https://api.spacexdata.com/v3/launches
    /// </summary>
    class SpaceXLaunchCollection
    {
        public List<SpaceXLaunchModel> SpaceXLaunches { get; set; }
    }
}
