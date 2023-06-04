namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADSEGMAINT")]
    public partial class ROADSEGMAINT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ROADSEGID { get; set; }

        public int? ROADID { get; set; }

        public byte RDSECSLNO { get; set; }

        public int? FROMCHAIN { get; set; }

        public int? TOCHAIN { get; set; }

        public short? MAINTOPRYR { get; set; }

        public byte? MAINTOPRTYPE { get; set; }

        public int? SURFTHICKNESS { get; set; }

        public decimal? MAINTOPRCOST { get; set; }

        public short? MAINTOPRFUNDSRC { get; set; }

        [StringLength(25)]
        public string REMARKS { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual FUNDINGSOURCE FUNDINGSOURCE { get; set; }

        public virtual ROADINVENTORY ROADINVENTORY { get; set; }
    }
}
