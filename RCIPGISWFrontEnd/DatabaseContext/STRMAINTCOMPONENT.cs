namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.STRMAINTCOMPONENT")]
    public partial class STRMAINTCOMPONENT
    {
        [Key]
        [StringLength(5)]
        public string COMPID { get; set; }

        [Required]
        [StringLength(30)]
        public string COMPNAME { get; set; }

        public bool ISSTRCOMP { get; set; }

        public bool SELECTIONTAG { get; set; }
    }
}
