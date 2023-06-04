namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADSEGCONST")]
    public partial class ROADSEGCONST
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ROADSEGCONSTID { get; set; }

        public int? ROADID { get; set; }

        public byte RDSECSLNO { get; set; }

        public int? FROMCHAIN { get; set; }

        public int? TOCHAIN { get; set; }

        [Required]
        [StringLength(3)]
        public string SURFTYPE { get; set; }

        public byte? CONSTTYPE { get; set; }

        public short? PAVECONSTYR { get; set; }

        public decimal? PAVECONSTCOST { get; set; }

        public short? FUNDSRCID { get; set; }

        [StringLength(25)]
        public string REMARKS { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual FUNDINGSOURCE FUNDINGSOURCE { get; set; }

        public virtual RDSURFACETYPE RDSURFACETYPE { get; set; }

        public virtual ROADINVENTORY ROADINVENTORY { get; set; }
    }
}
