namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.FUNDALLOCATION")]
    public partial class FUNDALLOCATION
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ALLOCATIONID { get; set; }

        public byte? DISTRICTID { get; set; }

        public short? ALLOCYEAR { get; set; }

        public short? FUNDSRCID { get; set; }

        public decimal? EM { get; set; }

        public decimal? RM_OFF { get; set; }

        public decimal? RM_ON { get; set; }

        public decimal? RESEAL { get; set; }

        public decimal? PM_OTH_R { get; set; }

        public decimal? PM_OTH_S { get; set; }

        public decimal? WIDENING { get; set; }

        public decimal? REHAB_ROAD { get; set; }

        public decimal? REHAB_STRUCT { get; set; }

        public decimal? TREEPLANT { get; set; }

        public decimal? FUNDRELEASE_PH1 { get; set; }

        public decimal? FUNDRELEASE_PH2 { get; set; }

        public decimal? FUNDRELEASE_PH3 { get; set; }

        public decimal? FUNDRELEASE_PH4 { get; set; }

        public virtual FUNDINGSOURCE FUNDINGSOURCE { get; set; }
    }
}
