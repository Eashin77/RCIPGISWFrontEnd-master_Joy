namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADGC_SM_POSITION")]
    public partial class ROADGC_SM_POSITION
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ROADMARKETID { get; set; }

        public int? ROADID { get; set; }

        public int? GCORHATID { get; set; }

        public int? POSIATCHAIN { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual ROADINVENTORY ROADINVENTORY { get; set; }
    }
}
