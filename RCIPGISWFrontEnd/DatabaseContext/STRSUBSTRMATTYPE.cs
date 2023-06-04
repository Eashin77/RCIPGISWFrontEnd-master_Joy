namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.STRSUBSTRMATTYPE")]
    public partial class STRSUBSTRMATTYPE
    {
        [Key]
        public byte SUBSTRMATTYPEID { get; set; }

        [StringLength(20)]
        public string SUBSTRMATTYPE { get; set; }
    }
}
