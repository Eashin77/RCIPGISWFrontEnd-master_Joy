namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADSEGDCP")]
    public partial class ROADSEGDCP
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ROADDCPID { get; set; }

        public int? ROADID { get; set; }

        public int? ATCHAIN { get; set; }

        public byte? NOOFBLOWBS { get; set; }

        public short? PDEPTHBS { get; set; }

        public short? THICKNESSBS { get; set; }

        public byte? NOOFBLOWSBBS { get; set; }

        public short? PDEPTHSBBS { get; set; }

        public short? THICKNESSSBBS { get; set; }

        public byte? NOOFBLOWIMPSG { get; set; }

        public short? PDEPTHIMPSG { get; set; }

        public short? THICKNESSIMPSG { get; set; }

        public byte? NOOFBLOWSG { get; set; }

        public short? PDEPTHSG { get; set; }

        public short? THICKNESSSG { get; set; }

        [StringLength(50)]
        public string REMARK { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual ROADINVENTORY ROADINVENTORY { get; set; }
    }
}
