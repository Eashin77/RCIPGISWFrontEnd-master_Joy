namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.UNIONDELVPHIST")]
    public partial class UNIONDELVPHIST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UNIONDELVPHIST()
        {
            UNIONDELVPCOMPs = new HashSet<UNIONDELVPCOMP>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UNDELVPID { get; set; }

        public int? UNIONID { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNIONDELVPCOMP> UNIONDELVPCOMPs { get; set; }

        public virtual UNIONLIST UNIONLIST { get; set; }
    }
}
