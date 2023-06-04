namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADMAINTNEED")]
    public partial class ROADMAINTNEED
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ROADMAINTNEED()
        {
            ROADMAINTNEED_RM = new HashSet<ROADMAINTNEED_RM>();
            ROADMAINTNEEDSEGs = new HashSet<ROADMAINTNEEDSEG>();
            ROADMAINTNEEDSTRUCTs = new HashSet<ROADMAINTNEEDSTRUCT>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MAINTNEEDID { get; set; }

        public int? ROADID { get; set; }

        public int? PLANYEAR { get; set; }

        public short? FUNDSRCID { get; set; }

        public short? PRIORITYSL { get; set; }

        public bool UNDERWORKPROG { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual FUNDINGSOURCE FUNDINGSOURCE { get; set; }

        public virtual ROADINVENTORY ROADINVENTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADMAINTNEED_RM> ROADMAINTNEED_RM { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADMAINTNEEDSEG> ROADMAINTNEEDSEGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADMAINTNEEDSTRUCT> ROADMAINTNEEDSTRUCTs { get; set; }
    }
}
