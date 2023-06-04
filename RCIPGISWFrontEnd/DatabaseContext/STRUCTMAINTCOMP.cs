namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.STRUCTMAINTCOMP")]
    public partial class STRUCTMAINTCOMP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STRMAINTCOMPID { get; set; }

        public int? STRMAINTID { get; set; }

        [StringLength(5)]
        public string REPCOMPID { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual STRUCTMAINTENANCE STRUCTMAINTENANCE { get; set; }
    }
}
