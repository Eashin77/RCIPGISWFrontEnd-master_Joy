namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADSEGMENTS")]
    public partial class ROADSEGMENT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public int ROADSEGID { get; set; }

        public int? ROADID { get; set; }

        public byte RDSECSLNO { get; set; }

        public int? FROMCHAIN { get; set; }

        public int? TOCHAIN { get; set; }

        public short? RDSURVEYYR { get; set; }

        [StringLength(5)]
        public string SURFTYPE { get; set; }

        public decimal? AVGCARGW { get; set; }

        public decimal? AVGSHOULW_L { get; set; }

        public decimal? AVGSHOULW_R { get; set; }

        [StringLength(1)]
        public string SHOULCON { get; set; }

        [StringLength(1)]
        public string SLOPECON { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual RDSURFACETYPE RDSURFACETYPE { get; set; }

        public virtual ROADINVENTORY ROADINVENTORY { get; set; }
    }
}
