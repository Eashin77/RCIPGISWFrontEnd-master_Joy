namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADTRAFFICCOUNT")]
    public partial class ROADTRAFFICCOUNT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ROADTRAFFICID { get; set; }

        public int? ROADID { get; set; }

        public byte? VEHIID { get; set; }

        public short? COUNTHATDAY { get; set; }

        public short? COUNTNONHATDAY { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual ROADINVENTORY ROADINVENTORY { get; set; }

        public virtual VEHICLELIST VEHICLELIST { get; set; }
    }
}
