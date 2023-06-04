namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.ROADSUMMARY")]
    public partial class ROADSUMMARY
    {
        [Key]
        public decimal ROADSUMID { get; set; }

        public short UPAZILAID { get; set; }

        [Required]
        [StringLength(1)]
        public string RDTYPECODE { get; set; }

        public decimal? ROADNUM { get; set; }

        public decimal? TOTALLENGTH { get; set; }

        public decimal? BCLENGTH { get; set; }

        public decimal? CCLENGTH { get; set; }

        public decimal? RCCLENGTH { get; set; }

        public decimal? WBMLENGTH { get; set; }

        public decimal? HBBLENGTH { get; set; }

        public decimal? BFSLENGTH { get; set; }

        public decimal? UNBLENGTH { get; set; }

        public decimal? ERTLENGTH { get; set; }

        public decimal? SURVEYLENGTH { get; set; }

        public decimal? GOODLENGTH { get; set; }

        public decimal? FAIRLENGTH { get; set; }

        public decimal? POORLENGTH { get; set; }

        public decimal? BADLENGTH { get; set; }

        public decimal? BRIDGENUM { get; set; }

        public decimal? BRIDGELENGTH { get; set; }

        public decimal? GAPNUM { get; set; }

        public decimal? GAPLENGTH { get; set; }

        public decimal? MOTORCYCLE { get; set; }

        public decimal? CAR { get; set; }

        public decimal? TEMPO { get; set; }

        public decimal? DELIVERYVEHI { get; set; }

        public decimal? UTILITYVEHI { get; set; }

        public decimal? BUSMINI { get; set; }

        public decimal? BUSLIGHT { get; set; }

        public decimal? BUSHEAVY { get; set; }

        public decimal? TRUCKLIGHT { get; set; }

        public decimal? TRUCKMEDIUM { get; set; }

        public decimal? AUTORICKSHAW { get; set; }

        public decimal? RICKSHAW { get; set; }

        public decimal? RICKSHAWVAN { get; set; }

        public decimal? BICYCLE { get; set; }

        public decimal? ANIMCART { get; set; }
    }
}
