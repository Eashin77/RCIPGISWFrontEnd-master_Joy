using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RCIPGISWFrontEnd.Models.Dashboard
{
    public class RoadCountByRoadType
    {
        public string RoadTypeCode { get; set; }
        public string RoadType { get; set; }
        public string RoadTypeName { get; set; }
        public int RoadTypeCount { get; set; }
    }

    public class RoadGroupByRoadTypeCountModel
    {
        public string RDTypeCode { get; set; }
        public int RDTypeCount { get; set; }
    }
}
