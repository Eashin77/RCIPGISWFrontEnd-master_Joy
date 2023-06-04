using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RCIPGISWFrontEnd.Models
{
    public class UserOffice
    {
        public int DesignationId { get; set; }
        public int OfficeTypeId { get; set; }
        public int RegionId { get; set; }
        public int DivisionId { get; set; }
        public int DistrictId { get; set; }
    }
}