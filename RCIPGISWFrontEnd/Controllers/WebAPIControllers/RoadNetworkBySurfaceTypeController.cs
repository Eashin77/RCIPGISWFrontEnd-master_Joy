using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RCIPGISWFrontEnd.Repositories.Dashboard.RoadNetworkBySurfaceTypeRepo;

namespace RCIPGISWFrontEnd.Controllers.WebAPIControllers
{
    public class RoadNetworkBySurfaceTypeController : ApiController
    {
        private RoadNetworkBySurfaceTypeDAO _roadCountBySurfaceType;
        public RoadNetworkBySurfaceTypeController()
        {
            _roadCountBySurfaceType = new RoadNetworkBySurfaceTypeDAO();
        }

        // GET: api/RoadNetworkBySurfaceType
        [Route("api/RoadNetworkBySurfaceType")]
        [HttpGet]
        public IHttpActionResult GetRoadCountBySurfaceType()
        {
            return Ok(_roadCountBySurfaceType.GetTotalLengthBySurfaceTypeAsync().Result);
        }
    }
}
