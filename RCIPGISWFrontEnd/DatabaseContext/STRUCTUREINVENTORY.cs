namespace RCIPGISWFrontEnd.DatabaseContext
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DEV_RSDMS.STRUCTUREINVENTORY")]
    public partial class STRUCTUREINVENTORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public STRUCTUREINVENTORY()
        {
            ROADMAINTNEEDSTRUCTs = new HashSet<ROADMAINTNEEDSTRUCT>();
            STRUCTINSPECTDETAILs = new HashSet<STRUCTINSPECTDETAIL>();
            STRUCTMAINTENANCEs = new HashSet<STRUCTMAINTENANCE>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int STRUCTID { get; set; }

        public int? ROADID { get; set; }

        public byte STSLNO { get; set; }

        public byte? STTYPEID { get; set; }

        public int? CHAINAGE { get; set; }

        public short? CONSTYR { get; set; }

        [StringLength(1)]
        public string CONSTYRTYPE { get; set; }

        public short? FUNDSRCID { get; set; }

        public decimal? CONSTCOST { get; set; }

        public decimal? LOADRESTRICTWGHT { get; set; }

        public decimal? STWIDTH { get; set; }

        public decimal? CARRIAGEWIDTH { get; set; }

        public byte? NOOFSPAN1 { get; set; }

        public decimal? LENEACHSPAN1 { get; set; }

        public byte? NOOFSPAN2 { get; set; }

        public decimal? LENEACHSPAN2 { get; set; }

        public byte? NOOFSPAN3 { get; set; }

        public decimal? LENEACHSPAN3 { get; set; }

        public byte? NOOFSPAN4 { get; set; }

        public decimal? LENEACHSPAN4 { get; set; }

        public byte? NOOFSPAN5 { get; set; }

        public decimal? LENEACHSPAN5 { get; set; }

        public byte? NOOFSPAN6 { get; set; }

        public decimal? LENEACHSPAN6 { get; set; }

        public decimal? TOTALLENGTH { get; set; }

        public byte? NOOFBEAM { get; set; }

        public decimal? STWIDTHWALK_L { get; set; }

        public decimal? STWIDTHWALK_R { get; set; }

        public byte? WEARSURFTYPE { get; set; }

        public byte? RAILINGTYPE { get; set; }

        public byte? ABUTMATRLTYPE { get; set; }

        public bool ABUTHASWEEPH { get; set; }

        public byte? PIERMATRLTYPE { get; set; }

        public byte? WINGWMATRLTYPE { get; set; }

        public bool WINGWHASWEEPH { get; set; }

        public byte? ABUTFOUNDNTYPE { get; set; }

        public byte? PIERFOUNDNTYPE { get; set; }

        public bool ABUTPROTECEXISTS { get; set; }

        public bool APPRCHDRAINEXISTS_B { get; set; }

        public bool APPRCHDRAINEXISTS_F { get; set; }

        public bool APPRCHROADEXISTS { get; set; }

        public decimal? APPRCHREQD_B { get; set; }

        public decimal? APPRCHREQD_F { get; set; }

        [StringLength(255)]
        public string REMARKS { get; set; }

        [StringLength(1)]
        public string EMBKSLOPCOND_B { get; set; }

        [StringLength(1)]
        public string EMBKSLOPCOND_F { get; set; }

        [StringLength(1)]
        public string PROTECTIVECOND_B { get; set; }

        [StringLength(1)]
        public string PROTECTIVECOND_F { get; set; }

        [StringLength(1)]
        public string APPRCHRDCOND_B { get; set; }

        [StringLength(1)]
        public string APPRCHRDCOND_F { get; set; }

        [StringLength(1)]
        public string BRIDGEDECKCOND { get; set; }

        [StringLength(1)]
        public string EJOINTSEALCOND_B { get; set; }

        [StringLength(1)]
        public string EJOINTSEALCOND_F { get; set; }

        [StringLength(1)]
        public string RAILBARPOSTCOND_L { get; set; }

        [StringLength(1)]
        public string RAILBARPOSTCOND_R { get; set; }

        [StringLength(1)]
        public string RDSAFETYELMTDMG { get; set; }

        [StringLength(1)]
        public string RDSAFETYELMTPAINT { get; set; }

        [StringLength(1)]
        public string PAINTBEAMTRUST { get; set; }

        [StringLength(1)]
        public string PAINTRPOST { get; set; }

        [StringLength(1)]
        public string CLEANCRGWAY_B { get; set; }

        [StringLength(1)]
        public string CLEANCRGWAY_F { get; set; }

        [StringLength(1)]
        public string CLEANWTRWAY_U { get; set; }

        [StringLength(1)]
        public string CLEANWTRWAY_D { get; set; }

        [StringLength(2)]
        public string TRAFFICVOL { get; set; }

        [StringLength(1)]
        public string SUPERSTRCOND { get; set; }

        [StringLength(1)]
        public string SUBSTRCOND { get; set; }

        public bool CAPEXPNPOSSIBLE { get; set; }

        [StringLength(2)]
        public string EXANSIONOPTION { get; set; }

        public bool REPLACEREQ { get; set; }

        [StringLength(3)]
        public string REPLACEOPTION { get; set; }

        [StringLength(255)]
        public string INSPECTCOMMENT { get; set; }

        public DateTime? INSPECTIONDT { get; set; }

        [StringLength(30)]
        public string INSPECTBY { get; set; }

        public byte? INSPECTDESIGID { get; set; }

        public int? ELEMENTNUM { get; set; }

        public decimal? TOTALCSA { get; set; }

        [StringLength(100)]
        public string CREATEBY { get; set; }

        public DateTime? CREATEDATE { get; set; }

        [StringLength(100)]
        public string MODIFYBY { get; set; }

        public DateTime? MODIFYDATE { get; set; }

        public virtual DESIGNATIONLIST DESIGNATIONLIST { get; set; }

        public virtual FUNDINGSOURCE FUNDINGSOURCE { get; set; }

        public virtual ROADINVENTORY ROADINVENTORY { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ROADMAINTNEEDSTRUCT> ROADMAINTNEEDSTRUCTs { get; set; }

        public virtual STRFOUNDATIONTYPE STRFOUNDATIONTYPE { get; set; }

        public virtual STRFOUNDATIONTYPE STRFOUNDATIONTYPE1 { get; set; }

        public virtual STRRAILINGTYPE STRRAILINGTYPE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STRUCTINSPECTDETAIL> STRUCTINSPECTDETAILs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STRUCTMAINTENANCE> STRUCTMAINTENANCEs { get; set; }

        public virtual STRUCTURETYPE STRUCTURETYPE { get; set; }

        public virtual STRWEARSURFTYPE STRWEARSURFTYPE { get; set; }
    }
}
