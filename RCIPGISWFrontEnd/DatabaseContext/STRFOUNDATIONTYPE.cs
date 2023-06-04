namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.STRFOUNDATIONTYPE")]
    public partial class STRFOUNDATIONTYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STRFOUNDATIONTYPE()
        {
            STRUCTUREINVENTORies = new HashSet<STRUCTUREINVENTORY>();
            STRUCTUREINVENTORies1 = new HashSet<STRUCTUREINVENTORY>();
        }

        [Key]
        public byte FOUNDATIONTYPEID { get; set; }

        [Required]
        [StringLength(20)]
        public string FOUNDATIONTYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STRUCTUREINVENTORY> STRUCTUREINVENTORies { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STRUCTUREINVENTORY> STRUCTUREINVENTORies1 { get; set; }
    }
}
