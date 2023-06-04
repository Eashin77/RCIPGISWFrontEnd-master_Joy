namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.SCHEMELIST")]
    public partial class SCHEMELIST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SCHEMELIST()
        {
            SCHEMEPROGRESSes = new HashSet<SCHEMEPROGRESS>();
            SCHEMEROADSEGs = new HashSet<SCHEMEROADSEG>();
            SCHEMESTRUCTUREs = new HashSet<SCHEMESTRUCTURE>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SCHEMEID { get; set; }

        public short? UPAZILAID { get; set; }

        public short? PROJECTID { get; set; }

        public short? SCHYEAR { get; set; }

        public short? SCHEMESL { get; set; }

        public byte? WORKTYPE { get; set; }

        [StringLength(10)]
        public string ROADCODE { get; set; }

        [StringLength(400)]
        public string SCHEMENAME { get; set; }

        public decimal? ROADLEN { get; set; }

        public short? NOOFTREE { get; set; }

        public decimal? ESTMCOST { get; set; }

        public decimal? SALVAGECOST { get; set; }

        public decimal? CONTRACTCOST { get; set; }

        public decimal? ALLOCATION { get; set; }

        public DateTime? ALLOCATIONDT { get; set; }

        public DateTime? SCHAPPROVDT { get; set; }

        public DateTime? TENDERDT { get; set; }

        public DateTime? WORKORDERDT { get; set; }

        public DateTime? COMMENCEDT { get; set; }

        public DateTime? ACTUALSTDT { get; set; }

        public DateTime? COMPLETEDT { get; set; }

        public DateTime? REVENDDT { get; set; }

        public DateTime? ACTUALENDDT { get; set; }

        public byte? NOOFLCS { get; set; }

        public int? CONTRSUPRVID { get; set; }

        public byte? PROCMETHOD { get; set; }

        public bool? FINALBILLGIVEN { get; set; }

        [StringLength(255)]
        public string REMARK { get; set; }

        [StringLength(15)]
        public string RSEPS_CODE { get; set; }

        public bool? APPROVED { get; set; }

        public byte? SURFTHICKNESS { get; set; }

        [StringLength(20)]
        public string PACKCODE { get; set; }

        public bool? APPPRINTED { get; set; }

        [StringLength(100)]
        public string REMARK_HQ { get; set; }

        public decimal? AMT2BPAY_CO { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCHEMEPROGRESS> SCHEMEPROGRESSes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCHEMEROADSEG> SCHEMEROADSEGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCHEMESTRUCTURE> SCHEMESTRUCTUREs { get; set; }
    }
}
