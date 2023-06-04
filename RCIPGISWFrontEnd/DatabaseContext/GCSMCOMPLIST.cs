namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.GCSMCOMPLIST")]
    public partial class GCSMCOMPLIST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GCSMCOMPLIST()
        {
            GCSMDELVPCOMPs = new HashSet<GCSMDELVPCOMP>();
        }

        [Key]
        public byte GCCOMPID { get; set; }

        [Required]
        [StringLength(50)]
        public string GCCOMPNAME { get; set; }

        [StringLength(5)]
        public string GCCOMPUNIT { get; set; }

        public byte GCCOMPSL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GCSMDELVPCOMP> GCSMDELVPCOMPs { get; set; }
    }
}
