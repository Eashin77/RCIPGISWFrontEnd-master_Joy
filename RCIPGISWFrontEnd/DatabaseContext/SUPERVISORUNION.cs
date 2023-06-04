namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.SUPERVISORUNION")]
    public partial class SUPERVISORUNION
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SUPERUNIONID { get; set; }

        public int SUPERVISORID { get; set; }

        public int UNIONID { get; set; }

        public virtual SUPERVISORLIST SUPERVISORLIST { get; set; }
    }
}
