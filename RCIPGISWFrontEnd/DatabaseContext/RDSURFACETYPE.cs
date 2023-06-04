namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.RDSURFACETYPE")]
    public partial class RDSURFACETYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RDSURFACETYPE()
        {
            ROADSEGMENTS = new HashSet<ROADSEGMENT>();
            ROADSEGCONSTs = new HashSet<ROADSEGCONST>();
        }

        [Key]
        [StringLength(5)]
        public string CODE { get; set; }

        [Required]
        [StringLength(10)]
        public string NAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADSEGMENT> ROADSEGMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADSEGCONST> ROADSEGCONSTs { get; set; }
    }
}
