namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.GCSMLEASEINFO")]
    public partial class GCSMLEASEINFO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int LEASEID { get; set; }

        public int? GC_SM_ID { get; set; }

        public short? LEASEDYEAR { get; set; }

        public decimal? LEASEDMONEY { get; set; }

        [StringLength(30)]
        public string LEASEDTO { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual GC_SM_LIST GC_SM_LIST { get; set; }
    }
}
