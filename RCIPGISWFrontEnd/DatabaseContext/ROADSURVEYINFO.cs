namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADSURVEYINFO")]
    public partial class ROADSURVEYINFO
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ROADID { get; set; }

        [StringLength(50)]
        public string TRAFFICCOUNTSTATION { get; set; }

        public DateTime? HATSURVEYDT { get; set; }

        public DateTime? NONHATSURVEYDT { get; set; }

        [StringLength(30)]
        public string TRAFFICSURVEYBY { get; set; }

        public int? TRAFFICDESIGID { get; set; }

        public DateTime? CONDSURVEYFROM { get; set; }

        public DateTime? CONDSURVEYTO { get; set; }

        [StringLength(30)]
        public string CONDSURVEYBY { get; set; }

        public byte? CONDSURVEYDESIGID { get; set; }

        public DateTime? IRISURVEYDT { get; set; }

        [StringLength(30)]
        public string IRISSURVEYBY { get; set; }

        public byte? IRISDESIGID { get; set; }

        public DateTime? DCPSURVEYFROM { get; set; }

        public DateTime? DCPSURVEYTO { get; set; }

        [StringLength(30)]
        public string DCPSURVEYBY { get; set; }

        public byte? DCPDESIGID { get; set; }

        public DateTime? DEFSURVEYFROM { get; set; }

        public DateTime? DEFSURVEYTO { get; set; }

        [StringLength(30)]
        public string DEFSURVEYBY { get; set; }

        public byte? DEFDESIGID { get; set; }

        public virtual ROADINVENTORY ROADINVENTORY { get; set; }
    }
}
