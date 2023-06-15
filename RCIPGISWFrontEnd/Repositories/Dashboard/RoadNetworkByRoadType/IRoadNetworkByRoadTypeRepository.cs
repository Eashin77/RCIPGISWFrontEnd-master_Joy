using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCIPGISWFrontEnd.Models.Dashboard;
using RCIPGISWFrontEnd.Models.RoadInventory;

namespace RCIPGISWFrontEnd.Repositories.Dashboard.RoadNetworkByRoadType
{
    interface IRoadNetworkByRoadTypeRepository
    {
        IEnumerable<RoadCountByRoadType> GetRoadCountByRoadType();
        // IEnumerable<RoadCountByPavedModel> GetRoadCountByPaved();
    }
}
