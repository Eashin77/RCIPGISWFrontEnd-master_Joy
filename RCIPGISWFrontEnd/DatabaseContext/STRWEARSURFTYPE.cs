namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.STRWEARSURFTYPE")]
    public partial class STRWEARSURFTYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STRWEARSURFTYPE()
        {
            STRUCTUREINVENTORies = new HashSet<STRUCTUREINVENTORY>();
        }

        [Key]
        public byte WEARSURFTYPEID { get; set; }

        [Required]
        [StringLength(30)]
        public string WEARSURFTYPENAME { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STRUCTUREINVENTORY> STRUCTUREINVENTORies { get; set; }
    }
}
