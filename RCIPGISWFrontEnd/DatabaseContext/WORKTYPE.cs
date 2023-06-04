namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.WORKTYPE")]
    public partial class WORKTYPE
    {
        public byte WORKTYPEID { get; set; }

        [StringLength(5)]
        public string WORKCATID { get; set; }

        [StringLength(20)]
        public string WORKTYPESHORT { get; set; }

        [StringLength(50)]
        public string WORKTYPENAME { get; set; }

        [StringLength(50)]
        public string PREFIX { get; set; }

        public int? REPORTSL { get; set; }

        [StringLength(50)]
        public string APPLETTER_HEAD_B { get; set; }

        [StringLength(50)]
        public string APPLETTER_HEAD_E { get; set; }

        public int? APPLETTER_SORTSL { get; set; }
    }
}
