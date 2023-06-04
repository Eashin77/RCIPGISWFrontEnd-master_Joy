using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RCIPGISWFrontEnd.DatabaseContext;
using RCIPGISWFrontEnd.Models.RoadInventory;

namespace RCIPGISWFrontEnd.Repositories.RoadBasicInformation
{
    public class RoadBasicInformation : IRoadBasicInformation
    {
        private readonly DevRSDMSDbContext _oracleDBContext;
        public RoadBasicInformation()
        {
            _oracleDBContext = new DevRSDMSDbContext();
        }

        public RoadBasicInformation(DevRSDMSDbContext dbContext)
        {
            _oracleDBContext = dbContext;
            _oracleDBContext.Configuration.ValidateOnSaveEnabled = false; // disable automatic validation
        }

        public IEnumerable<RoadInventoryModel> GetRoadInventoryById(long roadID) {
            return _oracleDBContext.ROADINVENTORies.Where(wh=> wh.ROADID == roadID).Select(es => new RoadInventoryModel { 
                ROADID = es.ROADID,
                ROADSLNO = es.ROADSLNO,
                UPAZILAID = es.UPAZILAID,
                RDTYPECODE = es.RDTYPECODE,
                ROADCODE = es.ROADCODE,
                ROADNAME = es.ROADNAME,
                ROADLENGTH = es.ROADLENGTH,
                CRESTWIDTH = es.CRESTWIDTH,
                EMBKHEIGHT = es.EMBKHEIGHT,
                IRI = es.IRI,
                AADT_MT = es.AADT_MT ,
                AADT_NMT = es.AADT_NMT,
                CVD = es.CVD
            }).ToList();
        }
    }
}