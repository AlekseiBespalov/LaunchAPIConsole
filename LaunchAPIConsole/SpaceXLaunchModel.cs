using System;
using System.Collections.Generic;
using System.Text;

namespace LaunchAPIConsole
{
    public class SpaceXLaunchModelCollection
    {
        public SpaceXLaunchModel SpaceXLaunches { get; set; }
    }
    public class SpaceXLaunchModel
    {
        public int Flight_number { get; set; }
        public string Mission_name { get; set; }
        public object[] Mission_id { get; set; }
        public string Launch_year { get; set; }
        public int Launch_date_unix { get; set; }
        public DateTime Launch_date_utc { get; set; }
        public DateTime Launch_date_local { get; set; }
        public bool Is_tentative { get; set; }
        public string Tentative_max_precision { get; set; }
        public bool Tbd { get; set; }
        public object Launch_window { get; set; }
        public SpaceXRocket Rocket { get; set; }
        public object[] Ships { get; set; }
        public SpaceXLaunchSite Launch_site { get; set; }
        public object Launch_success { get; set; }
        public SpaceXLinks Links { get; set; }
        public string Details { get; set; }
        public bool Upcoming { get; set; }
        public object Static_fire_date_utc { get; set; }
        public object Static_fire_date_unix { get; set; }
        public object Timeline { get; set; }
        public object Crew { get; set; }
    }
    public class SpaceXLaunchCore
    {
        public object Core_serial { get; set; }
        public object Flight { get; set; }
        public object Block { get; set; }
        public object Gridfins { get; set; }
        public object Legs { get; set; }
        public object Reused { get; set; }
        public object And_success { get; set; }
        public object Landing_intent { get; set; }
        public object Landing_type { get; set; }
        public object Landing_vehicle { get; set; }
    }

    public class SpaceXFirstStage
    {
        public List<SpaceXLaunchCore> Cores { get; set; }
    }

    public class SpaceXOrbitParams
    {
        public string Reference_system { get; set; }
        public string Regime { get; set; }
        public int Longitude { get; set; }
        public object Semi_major_axis_km { get; set; }
        public object Eccentricity { get; set; }
        public object Periapsis_km { get; set; }
        public object Apoapsis_km { get; set; }
        public object Inclination_deg { get; set; }
        public object Period_min { get; set; }
        public int Lifespan_years { get; set; }
        public object Epoch { get; set; }
        public object Mean_motion { get; set; }
        public object Raan { get; set; }
        public object Arg_of_pericenter { get; set; }
        public object Mean_anomaly { get; set; }
    }

    public class SpaceXPayload
    {
        public string Payload_Id { get; set; }
        public List<object> Norad_Id { get; set; }
        public bool Reused { get; set; }
        public List<string> Customers { get; set; }
        public string Nationality { get; set; }
        public string Manufacturer { get; set; }
        public string Payload_type { get; set; }
        public int Payload_mass_kg { get; set; }
        public double Payload_mass_lbs { get; set; }
        public string Orbit { get; set; }
        public SpaceXOrbitParams Orbit_params { get; set; }
    }

    public class SpaceXSecondStage
    {
        public object Block { get; set; }
        public List<SpaceXPayload> Payloads { get; set; }
    }

    public class SpaceXFairings
    {
        public bool Reused { get; set; }
        public bool Recovery_attempt { get; set; }
        public bool Recovered { get; set; }
        public object Ship { get; set; }
    }

    public class SpaceXRocket
    {
        public string Rocket_Id { get; set; }
        public string Rocket_Name { get; set; }
        public string Rocket_Type { get; set; }
        public SpaceXFirstStage First_Stage { get; set; }
        public SpaceXSecondStage Second_Stage { get; set; }
        public SpaceXFairings Fairings { get; set; }
    }

    public class SpaceXLaunchSite
    {
        public string Site_Id { get; set; }
        public string Site_Name { get; set; }
        public string Site_Name_Long { get; set; }
    }

    public class SpaceXLinks
    {
        public string Mission_Patch { get; set; }
        public string Mission_Patch_Small { get; set; }
        public string Reddit_Campaign { get; set; }
        public string Reddit_Launch { get; set; }
        public string Reddit_Recovery { get; set; }
        public string Reddit_Media { get; set; }
        public string Presskit { get; set; }
        public string Article_link { get; set; }
        public string Wikipedia { get; set; }
        public string Video_link { get; set; }
        public string Youtube_id { get; set; }
        public string[] Flickr_images { get; set; }
    }
}
