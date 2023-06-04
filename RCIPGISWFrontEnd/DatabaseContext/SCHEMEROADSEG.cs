namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.SCHEMEROADSEG")]
    public partial class SCHEMEROADSEG
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SCHEMERDSEGID { get; set; }

        public int? SCHEMEID { get; set; }

        public int? FROMCHAIN { get; set; }

        public int? TOCHAIN { get; set; }

        public byte? CONSTITUENCYID { get; set; }

        public decimal? MAINTCOST { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual SCHEMELIST SCHEMELIST { get; set; }
    }
}
