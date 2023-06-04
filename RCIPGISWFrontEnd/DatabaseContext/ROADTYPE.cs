namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADTYPES")]
    public partial class ROADTYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ROADTYPE()
        {
            ROADINVENTORies = new HashSet<ROADINVENTORY>();
        }

        [Key]
        [StringLength(1)]
        public string RDTYPECODE { get; set; }

        [Column("ROADTYPE")]
        [Required]
        [StringLength(5)]
        public string ROADTYPE1 { get; set; }

        [Required]
        [StringLength(15)]
        public string ROADTYPENAME { get; set; }

        [StringLength(5)]
        public string ROADTYPE_PRV { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADINVENTORY> ROADINVENTORies { get; set; }
    }
}
