namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.RDPRIORCOMPWEIGHT_DEV")]
    public partial class RDPRIORCOMPWEIGHT_DEV
    {
        [Key]
        public byte P_COMP_ID { get; set; }

        [Required]
        [StringLength(100)]
        public string P_COMPONENT { get; set; }

        public byte? P_WEIGHT { get; set; }

        public byte? P_COMP_GROUP { get; set; }
    }
}
