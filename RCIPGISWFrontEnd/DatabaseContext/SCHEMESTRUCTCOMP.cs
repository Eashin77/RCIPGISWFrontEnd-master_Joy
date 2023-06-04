namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.SCHEMESTRUCTCOMP")]
    public partial class SCHEMESTRUCTCOMP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SCHEMESTRCOMPID { get; set; }

        public int? SCHEMESTRID { get; set; }

        public byte? COMPID { get; set; }

        public virtual STRCOMPONENTLIST STRCOMPONENTLIST { get; set; }

        public virtual SCHEMESTRUCTURE SCHEMESTRUCTURE { get; set; }
    }
}
