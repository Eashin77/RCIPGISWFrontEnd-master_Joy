namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.VEHIMONTHLYMULT")]
    public partial class VEHIMONTHLYMULT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int VEHIMMID { get; set; }

        public byte? MONTHID { get; set; }

        public decimal? MONTHLYMULTIPLIER { get; set; }

        public byte? VEHIID { get; set; }

        public virtual VEHICLELIST VEHICLELIST { get; set; }
    }
}
