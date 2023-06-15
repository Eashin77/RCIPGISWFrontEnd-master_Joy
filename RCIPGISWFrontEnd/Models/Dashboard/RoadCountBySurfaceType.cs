using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RCIPGISWFrontEnd.Models.Dashboard
{
    public class RoadCountBySurfaceType
    {
        public long? roadID { get; set; }
        public long? upazilaID { get; set; }
        public double? surfaceLength { get; set; }
        public string surfaceType { get; set; }
    }

    public class RoadSegmentsBySurfaceType { 
        public double? surfacePercentage { get; set; }
        public string surfaceType { get; set; }
    }
}