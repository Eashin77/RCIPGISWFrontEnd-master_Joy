namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.DESIGNATIONLIST")]
    public partial class DESIGNATIONLIST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DESIGNATIONLIST()
        {
            STRUCTUREINVENTORies = new HashSet<STRUCTUREINVENTORY>();
        }

        [Key]
        public byte DESIGID { get; set; }

        [StringLength(20)]
        public string SHORTDESIG { get; set; }

        [StringLength(30)]
        public string DESIGNATION { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STRUCTUREINVENTORY> STRUCTUREINVENTORies { get; set; }
    }
}
