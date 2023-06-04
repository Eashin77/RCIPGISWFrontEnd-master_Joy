namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.STRSD_ELEMENT_MISI_FACTOR")]
    public partial class STRSD_ELEMENT_MISI_FACTOR
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int SDFACTORID { get; set; }

        public byte? COMPID { get; set; }

        public byte? STTYPEID { get; set; }

        public int? MIFACTOR { get; set; }

        public int? SIFACTOR { get; set; }

        public virtual STRCOMPONENTLIST STRCOMPONENTLIST { get; set; }

        public virtual STRUCTURETYPE STRUCTURETYPE { get; set; }
    }
}
