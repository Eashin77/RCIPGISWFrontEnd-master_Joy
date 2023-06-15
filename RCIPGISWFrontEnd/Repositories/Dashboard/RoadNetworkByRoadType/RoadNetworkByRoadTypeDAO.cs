using RCIPGISWFrontEnd.Models.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RCIPGISWFrontEnd.DatabaseContext;
using RCIPGISWFrontEnd.Models.RoadInventory;

namespace RCIPGISWFrontEnd.Repositories.Dashboard.RoadNetworkByRoadType
{
    public class RoadNetworkByRoadTypeDAO : IRoadNetworkByRoadTypeRepository
    {
        private readonly DevRSDMSDbContext _oracleDBContext;

        public RoadNetworkByRoadTypeDAO()
        {
            _oracleDBContext = new DevRSDMSDbContext();
        }

        public RoadNetworkByRoadTypeDAO(DevRSDMSDbContext oracleDBContext) {
            _oracleDBContext = oracleDBContext;
        }

        public IEnumerable<RoadCountByRoadType> GetRoadCountByRoadType()
        {
            var cntRoadTypeWise = _oracleDBContext.ROADINVENTORies
                .GroupBy(g => new { g.RDTYPECODE })
                .Select(n => new RoadGroupByRoadTypeCountModel
                {
                    RDTypeCode = n.Key.RDTYPECODE,
                    RDTypeCount = n.Count()
                }).ToList();

            List<RoadCountByRoadType> roadCountByRoadType = _oracleDBContext.ROADTYPES
                .Select(s => new
                {
                    RDTypeCode = s.RDTYPECODE,
                    RDTypeName = s.ROADTYPENAME,
                    RDType = s.ROADTYPE1
                })
                .ToList()
                .Join(
                cntRoadTypeWise,
                cR => cR.RDTypeCode,
                jR => jR.RDTypeCode,
                (cR, jR) => new RoadCountByRoadType
                {
                    RoadType = cR.RDType,
                    RoadTypeCode = cR.RDTypeCode,
                    RoadTypeName = cR.RDTypeName,
                    RoadTypeCount = jR.RDTypeCount
                }).ToList();

            return roadCountByRoadType;
        }
    }
}