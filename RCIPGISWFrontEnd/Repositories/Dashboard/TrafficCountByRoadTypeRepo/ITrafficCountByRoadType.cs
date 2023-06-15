using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCIPGISWFrontEnd.Models.Dashboard;

namespace RCIPGISWFrontEnd.Repositories.Dashboard.TrafficCountByRoadTypeRepo
{
    interface ITrafficCountByRoadType
    {
        IEnumerable<TrafficCountByRoadType> GetTrafficCountByAllRoadTypes();
    }
}
