namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.SUPERVISORLIST")]
    public partial class SUPERVISORLIST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SUPERVISORLIST()
        {
            SUPERVISORUNIONs = new HashSet<SUPERVISORUNION>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SUPERVISORID { get; set; }

        public short? UPAZILAID { get; set; }

        public short? FINYEAR { get; set; }

        [Required]
        [StringLength(80)]
        public string SUPERVISORNAME { get; set; }

        public DateTime? APPOINTDATE { get; set; }

        public int? NOOFRMG { get; set; }

        public short? NOOFLCS { get; set; }

        [StringLength(100)]
        public string REMARK { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SUPERVISORUNION> SUPERVISORUNIONs { get; set; }
    }
}
