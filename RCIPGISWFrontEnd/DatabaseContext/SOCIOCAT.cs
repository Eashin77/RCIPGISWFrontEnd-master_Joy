namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.SOCIOCAT")]
    public partial class SOCIOCAT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SOCIOCAT()
        {
            SOCIOTYPEs = new HashSet<SOCIOTYPE>();
        }

        [Key]
        public byte S_CAT_ID { get; set; }

        [Required]
        [StringLength(30)]
        public string S_CATEGORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SOCIOTYPE> SOCIOTYPEs { get; set; }
    }
}
