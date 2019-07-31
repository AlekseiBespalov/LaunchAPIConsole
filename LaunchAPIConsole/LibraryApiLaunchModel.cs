using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchAPIConsole
{
    public class LaunchLibraryApiModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Windowstart { get; set; }
        public string Windowend { get; set; }
        // launch time
        public string Net { get; set; }
        public LaunchLibraryRocket Rocket { get; set; }
        public int Status { get; set; }
        public int TbdTime { get; set; }
        public string[] VidURLs { get; set; }
        public int TbdDate { get; set; }
        public int Probability { get; set; }
        public string Changed { get; set; }
        public string[] infoURLs { get; set; }
        public object infoURL { get; set; }
        public string failreason { get; set; }
    }

    public class LaunchLibraryRocket
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Configuration { get; set; }
        public string FamilyName { get; set; }
        public int[] imageSizes { get; set; }
        public string imageURL { get; set; }
    }

    public class LaunchLibraryCollection
    {
        public List<LaunchLibraryApiModel> launches { get; set; }
    }
}
