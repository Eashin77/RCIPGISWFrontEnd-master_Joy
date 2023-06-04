namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.GC_SM_LIST")]
    public partial class GC_SM_LIST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GC_SM_LIST()
        {
            GCSMDELVPHISTs = new HashSet<GCSMDELVPHIST>();
            GCSMLEASEINFOes = new HashSet<GCSMLEASEINFO>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GC_SM_ID { get; set; }

        public byte? SLNO { get; set; }

        public short? UPAZILAID { get; set; }

        public int? UNIONID { get; set; }

        [StringLength(100)]
        public string GC_SM_NAME { get; set; }

        [StringLength(1)]
        public string GC_SM_TAG { get; set; }

        public bool ISDEVELOPED { get; set; }

        public int? TYPEOFMKT { get; set; }

        public decimal? AREA_GOVT { get; set; }

        public decimal? AREA_PRVT { get; set; }

        public int? ANLTURNOVER { get; set; }

        public bool ISELECTRIFIED { get; set; }

        public bool ISCONNBYRHD { get; set; }

        public bool PERIPHAPPRVD { get; set; }

        public bool HATDAY_SAT { get; set; }

        public bool HATDAY_SUN { get; set; }

        public bool HATDAY_MON { get; set; }

        public bool HATDAY_TUE { get; set; }

        public bool HATDAY_WED { get; set; }

        public bool HATDAY_THR { get; set; }

        public bool HATDAY_FRI { get; set; }

        public bool HATDAY_DAILY { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GCSMDELVPHIST> GCSMDELVPHISTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GCSMLEASEINFO> GCSMLEASEINFOes { get; set; }
    }
}
