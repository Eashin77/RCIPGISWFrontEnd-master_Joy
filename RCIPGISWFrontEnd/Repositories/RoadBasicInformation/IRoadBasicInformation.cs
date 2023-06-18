using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RCIPGISWFrontEnd.Models.RoadInventory;

namespace RCIPGISWFrontEnd.Repositories.RoadBasicInformation
{
    public interface IRoadBasicInformation
    {
        IEnumerable<RoadInventoryModel> GetRoadInventoryById(long roadID);
        List<RoadInventoryModel> GetRoadInventoryWithPagination(int pageNumber, int pageSize);
        int GetTotalRecordCount();
    }
}
