namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.SOCIOTYPE")]
    public partial class SOCIOTYPE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SOCIOTYPE()
        {
            ROADSOCIOCONNs = new HashSet<ROADSOCIOCONN>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int S_TYPE_ID { get; set; }

        public byte? S_CAT_ID { get; set; }

        [Required]
        [StringLength(50)]
        public string S_TYPE_NAME { get; set; }

        public byte? P_COMP_ID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADSOCIOCONN> ROADSOCIOCONNs { get; set; }

        public virtual SOCIOCAT SOCIOCAT { get; set; }
    }
}
