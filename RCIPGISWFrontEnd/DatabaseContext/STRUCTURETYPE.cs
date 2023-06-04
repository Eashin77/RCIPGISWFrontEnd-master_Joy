namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.STRUCTURETYPES")]
    public partial class STRUCTURETYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STRUCTURETYPE()
        {
            SCHEMESTRUCTUREs = new HashSet<SCHEMESTRUCTURE>();
            STRSD_ELEMENT_MISI_FACTOR = new HashSet<STRSD_ELEMENT_MISI_FACTOR>();
            STRUCTUREINVENTORies = new HashSet<STRUCTUREINVENTORY>();
        }

        [Key]
        public byte STTYPEID { get; set; }

        [Required]
        [StringLength(5)]
        public string STTYPECODE { get; set; }

        [Column("STRUCTURETYPE")]
        [Required]
        [StringLength(30)]
        public string STRUCTURETYPE1 { get; set; }

        public byte? STSORTSL { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCHEMESTRUCTURE> SCHEMESTRUCTUREs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STRSD_ELEMENT_MISI_FACTOR> STRSD_ELEMENT_MISI_FACTOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STRUCTUREINVENTORY> STRUCTUREINVENTORies { get; set; }
    }
}
