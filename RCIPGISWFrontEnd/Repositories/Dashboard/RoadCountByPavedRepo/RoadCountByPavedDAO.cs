using RCIPGISWFrontEnd.DatabaseContext;
using RCIPGISWFrontEnd.Models.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RCIPGISWFrontEnd.Repositories.Dashboard.RoadCountByPavedRepo
{
    public class RoadCountByPavedDAO : IRoadCountByPavedRepository
    {
        private readonly DevRSDMSDbContext _oracleDBContext;
        public RoadCountByPavedDAO()
        {
            _oracleDBContext = new DevRSDMSDbContext();
        }

        public IEnumerable<RoadCountByPaved> GetRoadCountByPaved()
        {
            var roadSegments = _oracleDBContext.ROADSEGMENTS
                .Where(wh => wh.SURFTYPE == "BC" || wh.SURFTYPE == "CC" || wh.SURFTYPE == "RCC")
                .Select(s => new {
                    roadID = s.ROADID,
                    fromChain = s.FROMCHAIN,
                    toChain = s.TOCHAIN,
                    surfaceType = s.SURFTYPE
                })
                .ToList();

            var roadInventory = _oracleDBContext.ROADINVENTORies
                .Select(s => new
                {
                    roadID = s.ROADID,
                    roadLength = s.ROADLENGTH,
                    roadTypeCode = s.RDTYPECODE
                })
                .ToList()
                .Join(
                roadSegments,
                ij => ij.roadID,
                k => k.roadID,
                (ij, k) => new {
                    roadID = ij.roadID,
                    roadLength = ij.roadLength,
                    fromChain = k.fromChain,
                    toChain = k.toChain,
                    surfaceType = k.surfaceType,
                    roadTypeCode = ij.roadTypeCode
                })
                .Select(s => new {
                    roadId = s.roadID,
                    roadLength = s.roadLength,
                    fromChain = s.fromChain,
                    toChain = s.toChain,
                    surfaceType = s.surfaceType,
                    roadTypeCode = s.roadTypeCode
                })
                .ToList();

            var roadCount = _oracleDBContext.ROADTYPES
                .Select(s => new
                {
                    roadType = s.ROADTYPE1,
                    roadTypeCode = s.RDTYPECODE,
                    roadTypeName = s.ROADTYPENAME
                })
                .ToList()
                .GroupBy(gr => new
                {
                    gr.roadType,
                    gr.roadTypeCode,
                    gr.roadTypeName
                })
                .GroupJoin(
                roadInventory,
                ij => ij.Key.roadTypeCode,
                k => k.roadTypeCode,
                (ij, k) => new
                {
                    roadType = ij.Key.roadType,
                    roadTypeCode = ij.Key.roadTypeCode,
                    roadTypeName = ij.Key.roadTypeName,
                    roadLength = k.Sum(i => i.roadLength),
                    surfaceLength = k.Sum(sl => (sl.toChain - sl.fromChain)) / 1000,
                    roadCount = k.Count()
                })
                .SelectMany(
                temp => temp.roadTypeCode.DefaultIfEmpty(),
                (temp, k) => new RoadCountByPaved
                {
                    roadType = temp.roadType,
                    roadTypeCode = temp.roadTypeCode,
                    roadTypeName = temp.roadTypeName,
                    roadCount = temp.roadCount,
                    roadLength = temp.roadLength,
                    surfaceLength = temp.surfaceLength
                })
                .OrderBy(o => o.roadTypeCode)
                .ToList();

            return roadCount;
        }
    }
}