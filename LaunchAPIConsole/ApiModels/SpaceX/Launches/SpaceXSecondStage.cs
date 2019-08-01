using System.Collections.Generic;

namespace LaunchAPIConsole.ApiModels.SpaceX.Launches
{
    public class SpaceXSecondStage
    {
        public object Block { get; set; }

        public List<SpaceXPayload> Payloads { get; set; }
    }
}
