namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADSEGIRI_HIST")]
    public partial class ROADSEGIRI_HIST
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ROADIRIHISTID { get; set; }

        public int? ROADID { get; set; }

        public DateTime? SURVEYDATE { get; set; }

        public int? FROMCHAIN { get; set; }

        public int? TOCHAIN { get; set; }

        public byte? RDSECSLNO { get; set; }

        public decimal? IRI { get; set; }

        [StringLength(30)]
        public string REMARK { get; set; }

        public virtual ROADINVENTORY ROADINVENTORY { get; set; }
    }
}
