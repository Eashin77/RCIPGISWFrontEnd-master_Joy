using RCIPGISWFrontEnd.Models.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RCIPGISWFrontEnd.DatabaseContext;

namespace RCIPGISWFrontEnd.Repositories.Dashboard.TrafficCountByRoadTypeRepo
{
    public class TrafficCountByRoadTypeDAO : ITrafficCountByRoadType
    {
        private readonly DevRSDMSDbContext _oracleDBContext;
        public TrafficCountByRoadTypeDAO()
        {
            _oracleDBContext = new DevRSDMSDbContext();
        }
        public IEnumerable<TrafficCountByRoadType> GetTrafficCountByAllRoadTypes()
        {
            var vehicleList = _oracleDBContext.VEHICLELISTs
                .Select(s => new {
                    vehicleID = s.VEHIID,
                    vehicleName = s.VEHICLENAME
                }).ToList();
            var roadInventory = _oracleDBContext.ROADINVENTORies
                .Select(s => new {
                    roadID = s.ROADID,
                    roadTypeCode = s.RDTYPECODE
                }).ToList();
            var roadTypes = _oracleDBContext.ROADTYPES
                .Select(s => new {
                    roadTypeCode = s.RDTYPECODE,
                    roadType = s.ROADTYPE1,
                    roadTypeName = s.ROADTYPENAME
                }).ToList();

            var trafficCountByRoadType = _oracleDBContext.ROADTRAFFICCOUNTs
                .Select(s => new
                {
                    roadID = s.ROADID,
                    vehicleID = s.VEHIID,
                    countHatDay = s.COUNTHATDAY,
                    countNonHatDay = s.COUNTNONHATDAY
                })
                .ToList()
                .Join(
                vehicleList,
                oj => oj.vehicleID,
                k => k.vehicleID,
                (oj, k) => new
                {
                    roadID = oj.roadID,
                    vehicleName = k.vehicleName,
                    vehicleID = oj.vehicleID,
                    countHatDay = oj.countHatDay,
                    countNonHatDay = oj.countNonHatDay
                })
                .Join(
                roadInventory,
                oj => oj.roadID,
                k => k.roadID,
                (oj, k) => new
                {
                    roadID = k.roadID,
                    roadTypeCode = k.roadTypeCode,
                    vehicleName = oj.vehicleName,
                    vehicleID = oj.vehicleID,
                    countHatDay = oj.countHatDay,
                    countNonHatDay = oj.countNonHatDay
                })
                .Join(
                roadTypes,
                oj => oj.roadTypeCode,
                k => k.roadTypeCode,
                (oj, k) => new
                {
                    roadType = k.roadType,
                    roadTypeName = k.roadTypeName,
                    roadTypeCode = k.roadTypeCode,
                    vehicleName = oj.vehicleName,
                    vehicleID = oj.vehicleID,
                    countHatDay = oj.countHatDay,
                    countNonHatDay = oj.countNonHatDay
                })
                .GroupBy(gr => new {
                    gr.roadType,
                    gr.vehicleID,
                    gr.vehicleName,
                    gr.roadTypeName
                })
                .Select(s => new TrafficCountByRoadType
                {
                    roadType = s.FirstOrDefault().roadType,
                    roadTypeName = s.FirstOrDefault().roadTypeName,
                    vehicleID = s.FirstOrDefault().vehicleID,
                    vehicleName = s.FirstOrDefault().vehicleName,
                    vehicleCount = Math.Ceiling(s.Average(data => Convert.ToDecimal(((data.countHatDay * 2) + (data.countNonHatDay * 5)) / 7))),
                })
                .OrderBy(o => o.vehicleID)
                .ToList();
            return trafficCountByRoadType;
        }
    }
}