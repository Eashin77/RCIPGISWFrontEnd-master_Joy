using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCIPGISWFrontEnd.Models.Dashboard;

namespace RCIPGISWFrontEnd.Repositories.Dashboard.RoadCountByPavedRepo
{
    interface IRoadCountByPavedRepository
    {
        IEnumerable<RoadCountByPaved> GetRoadCountByPaved();
    }
}
