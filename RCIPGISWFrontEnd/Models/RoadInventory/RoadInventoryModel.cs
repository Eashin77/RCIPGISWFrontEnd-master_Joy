using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RCIPGISWFrontEnd.Models.RoadInventory
{
    public class RoadInventoryModel
    {
        public RoadInventoryModel()
        {

        }

        public long ROADID { get; set; }
        public int UPAZILAID { get; set; }
        public string RDTYPECODE { get; set; }
        public short ROADSLNO { get; set; }
        public string ROADCODE { get; set; }
        public string ROADNAME { get; set; }
        public Nullable<decimal> ROADLENGTH { get; set; }
        public Nullable<decimal> CRESTWIDTH { get; set; }
        public Nullable<decimal> EMBKHEIGHT { get; set; }
        public Nullable<decimal> IRI { get; set; }
        public Nullable<long> AADT_MT { get; set; }
        public Nullable<long> AADT_NMT { get; set; }
        public Nullable<long> CVD { get; set; }
        public Nullable<decimal> DEFLECTION { get; set; }
        public bool ISIMPPORTANTVR { get; set; }
        public bool ISUNDERCOREROAD { get; set; }
        public string REMARKS { get; set; }
        public string CREATEBY { get; set; }
        public Nullable<System.DateTime> CREATEDATE { get; set; }
        public string MODIFYBY { get; set; }
        public Nullable<System.DateTime> MODIFYDATE { get; set; }
        public string SEGMENTSTATUS { get; set; }
        public string ROADTYPEINFO { get; set; }
    }
}