using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RCIPGISWFrontEnd.Models.Dashboard
{
    public class RoadCountByPaved
    {
        public string roadTypeCode { get; set; }
        public string roadType { get; set; }
        public string roadTypeName { get; set; }
        public decimal? roadLength { get; set; }
        public decimal? surfaceLength { get; set; }
        public int? roadCount { get; set; }
    }
}