namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.STRUCTINSPECTDETAIL")]
    public partial class STRUCTINSPECTDETAIL
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STRUCTINSPID { get; set; }

        public int? STRUCTID { get; set; }

        public byte? DMGCOMPID { get; set; }

        public decimal? COMPQTY { get; set; }

        public short? CRACK_N { get; set; }

        public short? CRACK_M { get; set; }

        public short? CRACK_H { get; set; }

        public short? CRACK_S { get; set; }

        public short? SPALLING_N { get; set; }

        public short? SPALLING_M { get; set; }

        public short? SPALLING_H { get; set; }

        public short? SPALLING_S { get; set; }

        public short? DMGSEC_N { get; set; }

        public short? DMGSEC_M { get; set; }

        public short? DMGSEC_H { get; set; }

        public short? DMGSEC_S { get; set; }

        public short? REBAR_N { get; set; }

        public short? REBAR_M { get; set; }

        public short? REBAR_H { get; set; }

        public short? REBAR_S { get; set; }

        public short? SETTLE_N { get; set; }

        public short? SETTLE_M { get; set; }

        public short? SETTLE_H { get; set; }

        public short? SETTLE_S { get; set; }

        public short? TILT_N { get; set; }

        public short? TILT_M { get; set; }

        public short? TILT_H { get; set; }

        public short? TILT_S { get; set; }

        public short? MOVE_N { get; set; }

        public short? MOVE_M { get; set; }

        public short? MOVE_H { get; set; }

        public short? MOVE_S { get; set; }

        public short? SCOUR_N { get; set; }

        public short? SCOUR_M { get; set; }

        public short? SCOUR_H { get; set; }

        public short? SCOUR_S { get; set; }

        public short? OBST_N { get; set; }

        public short? OBST_M { get; set; }

        public short? OBST_H { get; set; }

        public short? OBST_S { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual STRCOMPONENTLIST STRCOMPONENTLIST { get; set; }

        public virtual STRUCTUREINVENTORY STRUCTUREINVENTORY { get; set; }
    }
}
