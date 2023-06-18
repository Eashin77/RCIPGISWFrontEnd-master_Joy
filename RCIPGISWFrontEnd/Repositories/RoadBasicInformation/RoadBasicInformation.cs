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

        public int GetTotalRecordCount()
        {
            return _oracleDBContext.ROADINVENTORies.Count();
        }

        public List<RoadInventoryModel> GetRoadInventoryWithPagination(int pageNumber, int pageSize)
        {
            var query = _oracleDBContext.ROADINVENTORies
            .OrderBy(ob => ob.ROADID)
            .Skip((pageNumber - 1) * pageSize)
            .Take(pageSize);

            var roadInventoryInformation = query.Select(et => new RoadInventoryModel
            {
                ROADID = et.ROADID,
                ROADCODE = et.ROADCODE,
                ROADLENGTH = et.ROADLENGTH,
                RDTYPECODE = et.RDTYPECODE,
                ROADSLNO = et.ROADSLNO,
                ROADNAME = et.ROADNAME,
                CRESTWIDTH = et.CRESTWIDTH,
                EMBKHEIGHT = et.EMBKHEIGHT,
                IRI = et.IRI,
                AADT_MT = et.AADT_MT,
                AADT_NMT = et.AADT_NMT,
                CVD = et.CVD,
                DEFLECTION = et.DEFLECTION,
                ISIMPPORTANTVR = et.ISIMPPORTANTVR,
                ISUNDERCOREROAD = et.ISUNDERCOREROAD,
                REMARKS = et.REMARKS,
                CREATEBY = et.CREATEBY,
                CREATEDATE = et.CREATEDATE,
                MODIFYBY = et.MODIFYBY,
                MODIFYDATE = et.MODIFYDATE
            }).ToList();

            return roadInventoryInformation;
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