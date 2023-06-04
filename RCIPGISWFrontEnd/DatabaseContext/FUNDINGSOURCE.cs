namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.FUNDINGSOURCE")]
    public partial class FUNDINGSOURCE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FUNDINGSOURCE()
        {
            FUNDALLOCATIONs = new HashSet<FUNDALLOCATION>();
            GCSMDELVPHISTs = new HashSet<GCSMDELVPHIST>();
            ROADMAINTNEED_RM = new HashSet<ROADMAINTNEED_RM>();
            ROADMAINTNEEDs = new HashSet<ROADMAINTNEED>();
            ROADSEGCONSTs = new HashSet<ROADSEGCONST>();
            ROADSEGMAINTs = new HashSet<ROADSEGMAINT>();
            STRUCTUREINVENTORies = new HashSet<STRUCTUREINVENTORY>();
            STRUCTMAINTENANCEs = new HashSet<STRUCTMAINTENANCE>();
            UNIONDELVPHISTs = new HashSet<UNIONDELVPHIST>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short FUNDSRCID { get; set; }

        [StringLength(50)]
        public string FUNDSRCNAME { get; set; }

        [StringLength(500)]
        public string FUNDSRCFULLNAME { get; set; }

        public bool INCLDINPMS { get; set; }

        public bool ISDONORFUNDED { get; set; }

        public int? PROJECTMAPID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FUNDALLOCATION> FUNDALLOCATIONs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GCSMDELVPHIST> GCSMDELVPHISTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADMAINTNEED_RM> ROADMAINTNEED_RM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADMAINTNEED> ROADMAINTNEEDs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADSEGCONST> ROADSEGCONSTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADSEGMAINT> ROADSEGMAINTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STRUCTUREINVENTORY> STRUCTUREINVENTORies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STRUCTMAINTENANCE> STRUCTMAINTENANCEs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNIONDELVPHIST> UNIONDELVPHISTs { get; set; }
    }
}
