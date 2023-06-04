namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.STRSD_ELEMENT")]
    public partial class STRSD_ELEMENT
    {
        [Key]
        public byte COMPID { get; set; }

        public int? COMPGROUPID { get; set; }

        [StringLength(50)]
        public string COMPGROUP { get; set; }

        [Required]
        [StringLength(50)]
        public string COMPNAME { get; set; }

        public int? COMPSORTSL { get; set; }
    }
}
