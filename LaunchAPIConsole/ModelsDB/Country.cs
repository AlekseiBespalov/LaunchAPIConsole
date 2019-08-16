using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchAPIConsole.ModelsDB
{
    public class Country
    {
        public int CountryId { get; set; }
        public string CountryCode { get; set; }
        public ICollection<Agency> Agencies { get; set; }
        public ICollection<Launch> Launches { get; set; }
    }
}
