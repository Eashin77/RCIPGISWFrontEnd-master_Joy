using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RCIPGISWFrontEnd.Repositories.Dashboard.RoadNetworkByRoadType;

namespace RCIPGISWFrontEnd.Controllers.WebAPIControllers
{
    public class RoadNetworkByRoadTypeController : ApiController
    {
        private RoadNetworkByRoadTypeDAO _roadcountByRoadType;
        public RoadNetworkByRoadTypeController()
        {
            _roadcountByRoadType = new RoadNetworkByRoadTypeDAO();
        }

        [Route("api/RoadCountByRoadType")]
        [HttpGet]
        public IHttpActionResult GetRoadCountByRoadType()
        {
            return Ok(_roadcountByRoadType.GetRoadCountByRoadType().ToList());
        }
    }
}
