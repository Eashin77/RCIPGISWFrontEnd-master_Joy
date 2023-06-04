namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.MARKETTYPE")]
    public partial class MARKETTYPE
    {
        [Key]
        public byte MKTTYPEID { get; set; }

        [Required]
        [StringLength(30)]
        public string MKTTYPE { get; set; }
    }
}
