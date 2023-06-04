namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADTRAFFIC_HIST")]
    public partial class ROADTRAFFIC_HIST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ROADTRAFFIC_HIST()
        {
            ROADTRAFFICCOUNT_HIST = new HashSet<ROADTRAFFICCOUNT_HIST>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TRHISTID { get; set; }

        public int? ROADID { get; set; }

        [StringLength(50)]
        public string COUNTSTATION { get; set; }

        public DateTime? HATSURVEYDT { get; set; }

        public DateTime? NONHATSURVEYDT { get; set; }

        [StringLength(30)]
        public string SURVEYBY { get; set; }

        public byte? DESIGID { get; set; }

        public virtual ROADINVENTORY ROADINVENTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADTRAFFICCOUNT_HIST> ROADTRAFFICCOUNT_HIST { get; set; }
    }
}
