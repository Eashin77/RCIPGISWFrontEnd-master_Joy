namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.STRSD_MATERIAL_FACTOR")]
    public partial class STRSD_MATERIAL_FACTOR
    {
        [Key]
        public byte MATID { get; set; }

        [Required]
        [StringLength(50)]
        public string MATTYPE { get; set; }

        public byte? MATFACTOR { get; set; }
    }
}
