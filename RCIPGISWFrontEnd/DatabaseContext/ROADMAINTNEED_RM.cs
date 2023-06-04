namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADMAINTNEED_RM")]
    public partial class ROADMAINTNEED_RM
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAINTNEEDRMID { get; set; }

        public int? MAINTNEEDID { get; set; }

        public byte? MAINTOPRTYPE { get; set; }

        public short? PRIORITYSL { get; set; }

        public decimal? MAINTLEN { get; set; }

        public short? FUNDSRCID { get; set; }

        public decimal? ESTMCOST { get; set; }

        public bool UNDERWORKPROG { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual FUNDINGSOURCE FUNDINGSOURCE { get; set; }

        public virtual ROADMAINTNEED ROADMAINTNEED { get; set; }
    }
}
