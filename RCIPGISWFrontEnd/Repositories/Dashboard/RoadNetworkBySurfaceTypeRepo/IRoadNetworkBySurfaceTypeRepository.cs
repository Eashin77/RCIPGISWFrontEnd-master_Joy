using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCIPGISWFrontEnd.Models.Dashboard;
using RCIPGISWFrontEnd.DatabaseContext;

namespace RCIPGISWFrontEnd.Repositories.Dashboard.RoadNetworkBySurfaceTypeRepo
{
    interface IRoadNetworkBySurfaceTypeRepository
    {
        Task<List<RoadSegmentsBySurfaceType>> GetTotalLengthBySurfaceTypeAsync();
    }
}
