namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.SCHEMESTRUCTURE")]
    public partial class SCHEMESTRUCTURE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SCHEMESTRUCTURE()
        {
            SCHEMESTRUCTCOMPs = new HashSet<SCHEMESTRUCTCOMP>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SCHEMESTRID { get; set; }

        public int? SCHEMEID { get; set; }

        public int? CHAINAGE { get; set; }

        public byte? STTYPEID { get; set; }

        public decimal? SPAN { get; set; }

        public decimal? MAINTCOST { get; set; }

        public byte? TOBESTTYPEID { get; set; }

        public decimal? TOBESPAN { get; set; }

        public byte? CONSTITUENCYID { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual SCHEMELIST SCHEMELIST { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCHEMESTRUCTCOMP> SCHEMESTRUCTCOMPs { get; set; }

        public virtual STRUCTURETYPE STRUCTURETYPE { get; set; }
    }
}
