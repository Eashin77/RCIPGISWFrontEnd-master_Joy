namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.PROCUREMETHOD")]
    public partial class PROCUREMETHOD
    {
        [Key]
        public byte PROCMETHODID { get; set; }

        [Required]
        [StringLength(50)]
        public string METHODFULLNAME { get; set; }

        [StringLength(10)]
        public string METHODSHORTNAME { get; set; }
    }
}
