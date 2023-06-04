namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.UNIONLIST")]
    public partial class UNIONLIST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UNIONLIST()
        {
            UNIONDELVPHISTs = new HashSet<UNIONDELVPHIST>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int UNIONID { get; set; }

        public short? UPAZILAID { get; set; }

        public byte? CONSTITUENCYID { get; set; }

        [Required]
        [StringLength(50)]
        public string UNIONNAME { get; set; }

        public bool ISCONST { get; set; }

        public decimal? YEARLYINCOME { get; set; }

        public decimal? UNIONAREA { get; set; }

        public decimal? COMPLXAREA { get; set; }

        public bool ISELECTRIFIED { get; set; }

        public bool HASLINKROAD { get; set; }

        public bool LINKROADPAVED { get; set; }

        [StringLength(30)]
        public string REMARK { get; set; }

        public byte? UNIONSL { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UNIONDELVPHIST> UNIONDELVPHISTs { get; set; }
    }
}
