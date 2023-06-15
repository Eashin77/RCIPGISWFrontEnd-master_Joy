using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RCIPGISWFrontEnd.Repositories.Dashboard.RoadCountByPavedRepo;

namespace RCIPGISWFrontEnd.Controllers.WebAPIControllers
{
    public class RoadCountByPavedController : ApiController
    {
        private RoadCountByPavedDAO _roadCount;

        public RoadCountByPavedController()
        {
            _roadCount = new RoadCountByPavedDAO();
        }

        // GET: api/RoadCountByPaved
        [Route("api/RoadCountByPaved")]
        [HttpGet]
        public IHttpActionResult GetRoadCountByPavedRoad()
        {
            return Ok(_roadCount.GetRoadCountByPaved().ToList());
        }
    }
}
