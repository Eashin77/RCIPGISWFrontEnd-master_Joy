using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RCIPGISWFrontEnd.Models.Dashboard
{
    public class TrafficCountByRoadType
    {
        public byte? vehicleID { get; set; }
        public string vehicleName { get; set; }
        public decimal vehicleCount { get; set; }
        public string roadType { get; set; }
        public string roadTypeName { get; set; }
    }
}