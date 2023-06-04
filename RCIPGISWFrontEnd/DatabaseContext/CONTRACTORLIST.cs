namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.CONTRACTORLIST")]
    public partial class CONTRACTORLIST
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CONTRACTORID { get; set; }

        public byte? DISTRICTID { get; set; }

        public int? UPAZILAID { get; set; }

        [StringLength(1)]
        public string CONTRACTORCLASS { get; set; }

        [StringLength(100)]
        public string CONTRACTORNAME { get; set; }

        [StringLength(255)]
        public string CONTRACTORADDRESS { get; set; }

        [StringLength(30)]
        public string CONTRACTORPHONE { get; set; }
    }
}
