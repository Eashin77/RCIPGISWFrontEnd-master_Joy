namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.STRUCTMAINTENANCE")]
    public partial class STRUCTMAINTENANCE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STRUCTMAINTENANCE()
        {
            STRUCTMAINTCOMPs = new HashSet<STRUCTMAINTCOMP>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STRMAINTID { get; set; }

        public int? STRUCTID { get; set; }

        public short? MAINTYEAR { get; set; }

        public short? FUNDSRCID { get; set; }

        public decimal? MAINTCOST { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual FUNDINGSOURCE FUNDINGSOURCE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STRUCTMAINTCOMP> STRUCTMAINTCOMPs { get; set; }

        public virtual STRUCTUREINVENTORY STRUCTUREINVENTORY { get; set; }
    }
}
