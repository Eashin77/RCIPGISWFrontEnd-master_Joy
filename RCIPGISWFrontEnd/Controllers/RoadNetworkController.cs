using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RCIPGISWFrontEnd.Repositories.RoadBasicInformation;
using RCIPGISWFrontEnd.Models.RoadInventory;

namespace RCIPGISWFrontEnd.Controllers
{
    public class RoadNetworkController : Controller
    {
        // private readonly IRoadBasicInformation _roadBasicInfo;
        private readonly RoadBasicInformation _roadBasicInfo;

        public RoadNetworkController()
        {
            _roadBasicInfo = new RoadBasicInformation();
        }

        public ActionResult Index(int pageNumber = 1, int pageSize = 15)
        {
            List<RoadInventoryModel> roadInventoryPage = _roadBasicInfo.GetRoadInventoryWithPagination(pageNumber, pageSize);
            int totalRecords = _roadBasicInfo.GetTotalRecordCount();

            ViewBag.PageNumber = pageNumber;
            ViewBag.PageSize = pageSize;
            ViewBag.TotalRecords = totalRecords;

            return View(roadInventoryPage);
        }

        // GET: RoadNetworkDetails
        public ActionResult Details(long roadID)
        {
          
            IEnumerable<RoadInventoryModel> roadBasicInformation = _roadBasicInfo.GetRoadInventoryById(roadID);
              
            return View(roadBasicInformation);
        }
       
    }
}