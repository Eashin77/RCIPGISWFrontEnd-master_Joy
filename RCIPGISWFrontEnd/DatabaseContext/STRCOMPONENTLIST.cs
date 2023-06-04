namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.STRCOMPONENTLIST")]
    public partial class STRCOMPONENTLIST
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STRCOMPONENTLIST()
        {
            SCHEMESTRUCTCOMPs = new HashSet<SCHEMESTRUCTCOMP>();
            STRSD_ELEMENT_MISI_FACTOR = new HashSet<STRSD_ELEMENT_MISI_FACTOR>();
            STRUCTINSPECTDETAILs = new HashSet<STRUCTINSPECTDETAIL>();
        }

        [Key]
        public byte COMPID { get; set; }

        public int? COMPGROUPID { get; set; }

        [StringLength(50)]
        public string COMPGROUP { get; set; }

        [Required]
        [StringLength(50)]
        public string COMPNAME { get; set; }

        public int? COMPSORTSL { get; set; }

        public bool CANCRACKS { get; set; }

        public bool CANSPILLING { get; set; }

        public bool CANMISSECTION { get; set; }

        public bool CANREBAR { get; set; }

        public bool CANSETTLEMENT { get; set; }

        public bool CANTILTING { get; set; }

        public bool CANMOVEMENT { get; set; }

        public bool CANSCOURING { get; set; }

        public bool CANOBSTRUCT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SCHEMESTRUCTCOMP> SCHEMESTRUCTCOMPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STRSD_ELEMENT_MISI_FACTOR> STRSD_ELEMENT_MISI_FACTOR { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STRUCTINSPECTDETAIL> STRUCTINSPECTDETAILs { get; set; }
    }
}
