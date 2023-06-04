namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADINVENTORY")]
    public partial class ROADINVENTORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ROADINVENTORY()
        {
            ROADGC_SM_POSITION = new HashSet<ROADGC_SM_POSITION>();
            ROADTRAFFIC_HIST = new HashSet<ROADTRAFFIC_HIST>();
            ROADTRAFFICCOUNTs = new HashSet<ROADTRAFFICCOUNT>();
            ROADTRAFFICCOUNT_HIST = new HashSet<ROADTRAFFICCOUNT_HIST>();
            ROADUNIONBREAKUPs = new HashSet<ROADUNIONBREAKUP>();
            ROADMAINTNEEDs = new HashSet<ROADMAINTNEED>();
            ROADSEGCONDs = new HashSet<ROADSEGCOND>();
            ROADSEGCONSTs = new HashSet<ROADSEGCONST>();
            ROADSEGDCPs = new HashSet<ROADSEGDCP>();
            ROADSEGDEFLECTIONs = new HashSet<ROADSEGDEFLECTION>();
            ROADSEGIRI_HIST = new HashSet<ROADSEGIRI_HIST>();
            ROADSEGIRIs = new HashSet<ROADSEGIRI>();
            ROADTREEs = new HashSet<ROADTREE>();
            ROADSEGMENTS = new HashSet<ROADSEGMENT>();
            ROADSOCIOCONNs = new HashSet<ROADSOCIOCONN>();
            ROADSEGMAINTs = new HashSet<ROADSEGMAINT>();
            STRUCTUREINVENTORies = new HashSet<STRUCTUREINVENTORY>();
        }

            [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ROADID { get; set; }

        public short UPAZILAID { get; set; }

        [StringLength(1)]
        public string RDTYPECODE { get; set; }

        public byte ROADSLNO { get; set; }

        [StringLength(10)]
        public string ROADCODE { get; set; }

        [StringLength(250)]
        public string ROADNAME { get; set; }

        public decimal? ROADLENGTH { get; set; }

        public decimal? CRESTWIDTH { get; set; }

        public decimal? EMBKHEIGHT { get; set; }

        public decimal? IRI { get; set; }

        public int? AADT_MT { get; set; }

        public int? AADT_NMT { get; set; }

        public int? CVD { get; set; }

        public decimal? DEFLECTION { get; set; }

        public bool ISIMPPORTANTVR { get; set; }

        public bool ISUNDERCOREROAD { get; set; }

        [StringLength(100)]
        public string REMARKS { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADGC_SM_POSITION> ROADGC_SM_POSITION { get; set; }

        public virtual ROADSURVEYINFO ROADSURVEYINFO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADTRAFFIC_HIST> ROADTRAFFIC_HIST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADTRAFFICCOUNT> ROADTRAFFICCOUNTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADTRAFFICCOUNT_HIST> ROADTRAFFICCOUNT_HIST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADUNIONBREAKUP> ROADUNIONBREAKUPs { get; set; }

        public virtual ROADTYPE ROADTYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADMAINTNEED> ROADMAINTNEEDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADSEGCOND> ROADSEGCONDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADSEGCONST> ROADSEGCONSTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADSEGDCP> ROADSEGDCPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADSEGDEFLECTION> ROADSEGDEFLECTIONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADSEGIRI_HIST> ROADSEGIRI_HIST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADSEGIRI> ROADSEGIRIs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADTREE> ROADTREEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADSEGMENT> ROADSEGMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADSOCIOCONN> ROADSOCIOCONNs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADSEGMAINT> ROADSEGMAINTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STRUCTUREINVENTORY> STRUCTUREINVENTORies { get; set; }
    }
}
