namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.VEHICLETYPE")]
    public partial class VEHICLETYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VEHICLETYPE()
        {
            VEHICLELISTs = new HashSet<VEHICLELIST>();
        }

        [Key]
        public byte VEHITYPEID { get; set; }

        [Required]
        [StringLength(50)]
        public string VEHITYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VEHICLELIST> VEHICLELISTs { get; set; }
    }
}
