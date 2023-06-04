namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADTRAFFICCOUNT_HIST")]
    public partial class ROADTRAFFICCOUNT_HIST
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRCOUNTHISTID { get; set; }

        public int? TRHISTID { get; set; }

        public int? ROADID { get; set; }

        public byte? VEHIID { get; set; }

        public short? COUNTHATDAY { get; set; }

        public short? COUNTNONHATDAY { get; set; }

        public virtual ROADINVENTORY ROADINVENTORY { get; set; }

        public virtual ROADTRAFFIC_HIST ROADTRAFFIC_HIST { get; set; }

        public virtual VEHICLELIST VEHICLELIST { get; set; }
    }
}
