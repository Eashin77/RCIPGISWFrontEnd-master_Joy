namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADSOCIOCONN")]
    public partial class ROADSOCIOCONN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ROADSOCIOID { get; set; }

        public int? ROADID { get; set; }

        public int? SOCIO_SL { get; set; }

        public int? S_TYPE_ID { get; set; }

        [StringLength(100)]
        public string SOCIO_NAME { get; set; }

        public int? SOCIO_AT_CHAIN { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual ROADINVENTORY ROADINVENTORY { get; set; }

        public virtual SOCIOTYPE SOCIOTYPE { get; set; }
    }
}
