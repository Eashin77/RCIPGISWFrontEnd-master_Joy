namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.UPCOMPLIST")]
    public partial class UPCOMPLIST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UPCOMPLIST()
        {
            UNIONDELVPCOMPs = new HashSet<UNIONDELVPCOMP>();
        }

        [Key]
        public byte UPCOMPID { get; set; }

        [Required]
        [StringLength(50)]
        public string UPCOMPNAME { get; set; }

        [StringLength(10)]
        public string UPCOMPUNIT { get; set; }

        public byte? UPCOMPSL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNIONDELVPCOMP> UNIONDELVPCOMPs { get; set; }
    }
}
