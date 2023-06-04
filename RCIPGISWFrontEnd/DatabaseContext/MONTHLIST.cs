namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.MONTHLIST")]
    public partial class MONTHLIST
    {
        [Key]
        public byte MONTHID { get; set; }

        [Required]
        [StringLength(25)]
        public string MONTHNAME { get; set; }
    }
}
