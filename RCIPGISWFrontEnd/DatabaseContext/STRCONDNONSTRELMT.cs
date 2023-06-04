namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.STRCONDNONSTRELMT")]
    public partial class STRCONDNONSTRELMT
    {
        [Key]
        [StringLength(1)]
        public string CODE { get; set; }

        [Required]
        [StringLength(15)]
        public string CONDTEXTSHORT { get; set; }

        [Required]
        [StringLength(50)]
        public string CONDTEXTLONG { get; set; }
    }
}
