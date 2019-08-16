using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchAPIConsole.ModelsDB
{
    public class Launch
    {
        public int LaunchId { get; set; }
        public string MissionName { get; set; }
        //fix
        public DateTime LaunchDate { get; set; }
        public string LaunchSite { get; set; }
        public string RocketName { get; set; }
        public string MissionDetails { get; set; }
        //fix
        public object InfoUrl { get; set; }
        public DateTime ChangedTime { get; set; }
        public Country Country { get; set; }
        public Agency Agency { get; set; }
    }
}
