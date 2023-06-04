namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADSEGCOND")]
    public partial class ROADSEGCOND
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ROADSEGCONDID { get; set; }

        public int? ROADID { get; set; }

        public int? FROMCHAIN { get; set; }

        public int? TOCHAIN { get; set; }

        public byte? RDSECSLNO { get; set; }

        public short? RUTTING_DEPTH { get; set; }

        public short? RUTTING_L { get; set; }

        public short? RUTTING_H { get; set; }

        public short? DEPRESSION_L { get; set; }

        public short? DEPRESSION_H { get; set; }

        public short? RAVELLED_L { get; set; }

        public short? RAVELLED_H { get; set; }

        public short? CRACK_L { get; set; }

        public short? CRACK_H { get; set; }

        public short? POTHOLE_L { get; set; }

        public short? POTHOLE_H { get; set; }

        public short? EDGEDISTRESS_L { get; set; }

        public short? EDGEDISTRESS_H { get; set; }

        public short? HARDSHLDR_L { get; set; }

        public short? HARDSHLDR_H { get; set; }

        public short? LOWEARTH_L { get; set; }

        public short? LOWEARTH_H { get; set; }

        public short? PROTECTION_L { get; set; }

        public short? PROTECTION_H { get; set; }

        [StringLength(25)]
        public string REMARKS { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual ROADINVENTORY ROADINVENTORY { get; set; }
    }
}
