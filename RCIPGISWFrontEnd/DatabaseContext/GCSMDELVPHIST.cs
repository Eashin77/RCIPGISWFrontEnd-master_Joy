namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.GCSMDELVPHIST")]
    public partial class GCSMDELVPHIST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GCSMDELVPHIST()
        {
            GCSMDELVPCOMPs = new HashSet<GCSMDELVPCOMP>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GCDELVPID { get; set; }

        public int? GC_SM_ID { get; set; }

        public short? DEVLPYEAR { get; set; }

        public short? FUNDSRCID { get; set; }

        public decimal? DEVLPCOST { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual FUNDINGSOURCE FUNDINGSOURCE { get; set; }

        public virtual GC_SM_LIST GC_SM_LIST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GCSMDELVPCOMP> GCSMDELVPCOMPs { get; set; }
    }
}
