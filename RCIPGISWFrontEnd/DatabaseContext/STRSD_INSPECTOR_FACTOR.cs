namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.STRSD_INSPECTOR_FACTOR")]
    public partial class STRSD_INSPECTOR_FACTOR
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short DESIGID { get; set; }

        [Required]
        [StringLength(30)]
        public string SHORTDESIG { get; set; }

        [Required]
        [StringLength(100)]
        public string DESIGNATION { get; set; }

        public byte? INSPECTFACTOR { get; set; }
    }
}
