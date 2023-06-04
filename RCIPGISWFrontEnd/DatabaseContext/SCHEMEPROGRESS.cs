namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.SCHEMEPROGRESS")]
    public partial class SCHEMEPROGRESS
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SCHEMEPROGID { get; set; }

        public int? SCHEMEID { get; set; }

        public byte? PROGMONTH { get; set; }

        public short? PROGYEAR { get; set; }

        public byte? PROGPCT { get; set; }

        public decimal? AMOUNTSPENT { get; set; }

        public int? EMPLOYMENTGEN { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        public bool FINALBILLGIVEN { get; set; }

        public short? TREEPLANTNO { get; set; }

        public short? TREEHASNO { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual SCHEMELIST SCHEMELIST { get; set; }
    }
}
