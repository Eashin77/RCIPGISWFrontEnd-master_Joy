namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.VEHICLELIST")]
    public partial class VEHICLELIST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VEHICLELIST()
        {
            ROADTRAFFICCOUNTs = new HashSet<ROADTRAFFICCOUNT>();
            ROADTRAFFICCOUNT_HIST = new HashSet<ROADTRAFFICCOUNT_HIST>();
            VEHIMONTHLYMULTs = new HashSet<VEHIMONTHLYMULT>();
        }

        [Key]
        public byte VEHIID { get; set; }

        public byte? VEHISL { get; set; }

        public byte? LINK_MT_NMT { get; set; }

        public byte? VEHITYPEID { get; set; }

        public bool ISCOMMERCIAL { get; set; }

        [StringLength(50)]
        public string VEHICLENAME { get; set; }

        [StringLength(200)]
        public string VEHIDESCRIPTION { get; set; }

        public decimal? HOURLYMULTIPLIER { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADTRAFFICCOUNT> ROADTRAFFICCOUNTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADTRAFFICCOUNT_HIST> ROADTRAFFICCOUNT_HIST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VEHIMONTHLYMULT> VEHIMONTHLYMULTs { get; set; }

        public virtual VEHICLETYPE VEHICLETYPE { get; set; }
    }
}
