namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADMAINTNEEDSTRUCT")]
    public partial class ROADMAINTNEEDSTRUCT
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAINTNEEDSTRID { get; set; }

        public int? MAINTNEEDID { get; set; }

        public int? STRUCTID { get; set; }

        public byte? MAINTOPRTYPE { get; set; }

        public decimal? ESTMCOST { get; set; }

        public bool UNDERWORKPROG { get; set; }

        public int? SCHTAG { get; set; }

        [StringLength(25)]
        public string REMARKS { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual ROADMAINTNEED ROADMAINTNEED { get; set; }

        public virtual STRUCTUREINVENTORY STRUCTUREINVENTORY { get; set; }
    }
}
