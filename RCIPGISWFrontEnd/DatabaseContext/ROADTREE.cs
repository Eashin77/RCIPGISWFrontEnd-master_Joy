namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADTREE")]
    public partial class ROADTREE
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ROADTREEID { get; set; }

        public int? ROADID { get; set; }

        public byte? TREESL { get; set; }

        public byte? TREETYPE { get; set; }

        public short? NOOFTREE_L { get; set; }

        public short? NOOFTREE_R { get; set; }

        public short? YEARPLANT { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual ROADINVENTORY ROADINVENTORY { get; set; }

        public virtual TREETYPE TREETYPE1 { get; set; }
    }
}
