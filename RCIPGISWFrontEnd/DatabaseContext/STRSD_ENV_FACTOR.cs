namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.STRSD_ENV_FACTOR")]
    public partial class STRSD_ENV_FACTOR
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UPAZILAID { get; set; }

        [Required]
        [StringLength(50)]
        public string ENVCONDITION { get; set; }

        public byte? ENVFACTOR { get; set; }
    }
}
