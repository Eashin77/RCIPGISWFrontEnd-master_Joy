using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RCIPGISWFrontEnd.Repositories.Dashboard.TrafficCountByRoadTypeRepo;

namespace RCIPGISWFrontEnd.Controllers.WebAPIControllers
{
    public class TrafficCountByRoadTypeController : ApiController
    {
        private TrafficCountByRoadTypeDAO _trafficCount;

        public TrafficCountByRoadTypeController()
        {
            _trafficCount = new TrafficCountByRoadTypeDAO();
        }

        [Route("api/TrafficCountByRoadType")]
        [HttpGet]
        public IHttpActionResult GetTrafficCount()
        {
            var trafficCount = _trafficCount.GetTrafficCountByAllRoadTypes();
            // Group the objects by Road Type and Vehicle Name
            var trafficGroups = trafficCount.GroupBy(
                x => x.roadTypeName.ToString(),
                x => new {
                    VehicleName = x.vehicleName.ToString(),
                    VehicleCount = x.vehicleCount,
                }
                ).ToList();

            // Extract the distinct vehicle names
            var vehicleNames = trafficGroups.SelectMany(x => x.Select(y => y.VehicleName)).Distinct().ToList();
            vehicleNames.Insert(0, "Vehicle Names");
            // Create a new 2D list to store the result
            var resultList = new List<List<object>>();
            // Add the header row to the result
            resultList.Add(vehicleNames.Cast<object>().ToList());

            // Add the data rows to the result
            foreach (var group in trafficGroups)
            {
                var row = new List<object> { group.Key };
                foreach (var vehicleName in vehicleNames)
                {
                    if (vehicleName != "Vehicle Names")
                    {
                        var vehicleData = group.SingleOrDefault(x => x.VehicleName == vehicleName);
                        row.Add(vehicleData != null ? vehicleData.VehicleCount : 0);
                    }

                }
                resultList.Add(row);
            }

            var result = resultList.Select((element, index) => new { element, index })
            .ToDictionary(ele => ele.index.ToString(), ele => ele.element);
            return Ok(result);
        }
    }
}
