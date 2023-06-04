namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.GCSMDELVPCOMP")]
    public partial class GCSMDELVPCOMP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int DEVLPCOMPID { get; set; }

        public int? GCDELVPID { get; set; }

        public byte? GCCOMPID { get; set; }

        public decimal? COMPQTY { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual GCSMCOMPLIST GCSMCOMPLIST { get; set; }

        public virtual GCSMDELVPHIST GCSMDELVPHIST { get; set; }
    }
}
