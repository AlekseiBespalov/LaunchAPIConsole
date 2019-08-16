using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchAPIConsole.ModelsDB
{
    public class Agency
    {
        public int AgencyId { get; set; }
        public string AgencyName { get; set; }
        public string InfoUrl { get; set; }
        public Country Country { get; set; }
        public ICollection<Launch> Launches { get; set; }
    }
}
