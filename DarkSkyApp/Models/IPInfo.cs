using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Globalization;

namespace Models
{
    /// <summary>
    /// Class to read the information from IpInfo API.
    /// </summary>
    internal class IPInfo
    {
        public string IP { get; }
        public string HostName { get; }
        public string City { get; }
        public string Region { get; }
        public string Country { get; }
        public string Location { get; }
        public string Postal { get; }
        
        public double Latitude => Convert.ToDouble(Location.Split(',')[0],CultureInfo.CreateSpecificCulture("en-US"));

        public double Longitude => Convert.ToDouble(Location.Split(',')[1], CultureInfo.CreateSpecificCulture("en-US"));
        
        public IPInfo(string ip, string hostName, string city, string region, string country, string loc, string postal)
        {
            IP = ip;
            HostName = hostName;
            City = city;
            Region = region;
            Country = country;
            Location = loc;
            Postal = postal;
        }
    }
}