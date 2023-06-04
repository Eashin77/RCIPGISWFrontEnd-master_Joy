namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.UNIONDELVPCOMP")]
    public partial class UNIONDELVPCOMP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DELVPCOMPID { get; set; }

        public int? UNDELVPID { get; set; }

        public byte? UNCOMPID { get; set; }

        public decimal? COMPQTY { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual UNIONDELVPHIST UNIONDELVPHIST { get; set; }

        public virtual UPCOMPLIST UPCOMPLIST { get; set; }
    }
}
