using RCIPGISWFrontEnd.Models.Dashboard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RCIPGISWFrontEnd.DatabaseContext;
using System.Threading.Tasks;
using System.Data.Entity;

namespace RCIPGISWFrontEnd.Repositories.Dashboard.RoadNetworkBySurfaceTypeRepo
{
    public class RoadNetworkBySurfaceTypeDAO : IRoadNetworkBySurfaceTypeRepository
    {
        private readonly DevRSDMSDbContext _oracleDBContext;
        static log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public RoadNetworkBySurfaceTypeDAO()
        {
            _oracleDBContext = new DevRSDMSDbContext();
        }
        public async Task<List<RoadSegmentsBySurfaceType>> GetTotalLengthBySurfaceTypeAsync()
        {
            
            try
            {
                /* var roadInfo = await _oracleDBContext.ROADINVENTORies
                 .Select(s => new
                 {
                     roadID = s.ROADID,
                     roadLength = s.ROADLENGTH,
                     roadName = s.ROADNAME
                 }).ToListAsync();

                 // var roadIDlookup = roadInfo.ToLookup(l => l.roadID, l=> new { roadID = l.roadID });
                 // var roadSegmentInfoTry = _oracleDBContext.ROADSEGMENTS.ToList();

                 var roadSegmentInfo = await _oracleDBContext.ROADSEGMENTS
                    .GroupBy(et => new { 
                     roadID = et.ROADID,
                     surfaceType = et.SURFTYPE,
                     surfaceLength = et.TOCHAIN - et.FROMCHAIN,
                    })
                    .Select(ent => new RoadSegmentsBySurfaceType
                    {
                        roadID = ent.Key.roadID,
                        surfaceType = ent.Key.surfaceType,
                        surfaceLength = ent.Sum(s => (s.TOCHAIN - s.FROMCHAIN))
                    })
                    .OrderBy(od => od.roadID)
                    .ToListAsync();


                 var roadSegmentWiseInfo = roadInfo.Join(
                     roadSegmentInfo,
                     oj => oj.roadID,
                     ij => ij.roadID,
                     (oj, ij) => new 
                     {
                         roadID = oj.roadID,
                         roadLength = oj.roadLength,
                         surfaceLength = ij.surfaceLength,
                         surfaceType = ij.surfaceType
                     }
                     )
                     .OrderBy(ob => ob.roadID)
                     .Select(ent => new RoadCountBySurfaceType {
                         roadID = ent.roadID,
                         roadLength = ent.roadLength,
                         surfaceLength = ent.surfaceLength,
                         surfaceType = ent.surfaceType
                     })
                     .ToList();
                 _logger.Info($"The data has been fetched successfully {roadSegmentWiseInfo}");
                 return roadSegmentWiseInfo;*/

                var result = _oracleDBContext.ROADINVENTORies
                                .GroupJoin(
                                    _oracleDBContext.ROADSEGMENTS,
                                    ri => ri.ROADID,
                                    rs => rs.ROADID,
                                    (ri, rs) => new { RoadInventory = ri, RoadSegments = rs }
                                )
                                .SelectMany(
                                    x => x.RoadSegments.DefaultIfEmpty(),
                                    (x, rs) => new { x.RoadInventory, RoadSegment = rs }
                                )
                                .GroupBy(
                                    x => new { x.RoadInventory.ROADID, x.RoadInventory.UPAZILAID, x.RoadSegment.SURFTYPE },
                                    x => x.RoadSegment.TOCHAIN - x.RoadSegment.FROMCHAIN,
                                    (key, lengths) => new RoadCountBySurfaceType
                                    {
                                        roadID = key.ROADID,
                                        upazilaID = key.UPAZILAID,
                                        surfaceLength = lengths.Sum() / 1000,
                                        surfaceType = key.SURFTYPE
                                    }
                                )
                                .OrderBy(x => x.roadID)
                                .ToList();
                double? totalRoadLength = result.Sum(x => x.surfaceLength);
                var surfaceTypePercentage = result
                                            .GroupBy(x => x.surfaceType)
                                            .Select(group => new RoadSegmentsBySurfaceType
                                            {
                                                surfaceType = group.Key,
                                                surfacePercentage = /*(group.Sum(x => x.surfaceLength) / totalRoadLength) * 100*/ (group.Sum(x => x.surfaceLength)) / totalRoadLength * 100
                                            })
                                            .ToList();

                return surfaceTypePercentage;
            }
            catch (Exception e) {
                _logger.Error(e.Message);
                Console.WriteLine($"An exception occured while fetching data: {e.Message}");
                return null;
            }
            
        }
    }
}