namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADSEGDEFLECTION")]
    public partial class ROADSEGDEFLECTION
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ROADDEFID { get; set; }

        public int? ROADID { get; set; }

        public int? ATCHAIN { get; set; }

        public decimal? MAXREAD { get; set; }

        public decimal? FINALREAD { get; set; }

        [StringLength(30)]
        public string REMARK { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual ROADINVENTORY ROADINVENTORY { get; set; }
    }
}
