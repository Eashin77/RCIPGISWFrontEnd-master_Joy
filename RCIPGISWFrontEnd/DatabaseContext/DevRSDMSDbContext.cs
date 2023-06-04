using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace RCIPGISWFrontEnd.DatabaseContext
{
    public partial class DevRSDMSDbContext : DbContext
    {
        public DevRSDMSDbContext()
            : base("name=DevRSDMSDbContext")
        {
        }

        public virtual DbSet<CONTRACTORLIST> CONTRACTORLISTs { get; set; }
        public virtual DbSet<DESIGNATIONLIST> DESIGNATIONLISTs { get; set; }
        public virtual DbSet<FUNDALLOCATION> FUNDALLOCATIONs { get; set; }
        public virtual DbSet<FUNDINGSOURCE> FUNDINGSOURCEs { get; set; }
        public virtual DbSet<GC_SM_LIST> GC_SM_LIST { get; set; }
        public virtual DbSet<GCSMCOMPLIST> GCSMCOMPLISTs { get; set; }
        public virtual DbSet<GCSMDELVPCOMP> GCSMDELVPCOMPs { get; set; }
        public virtual DbSet<GCSMDELVPHIST> GCSMDELVPHISTs { get; set; }
        public virtual DbSet<GCSMLEASEINFO> GCSMLEASEINFOes { get; set; }
        public virtual DbSet<MARKETTYPE> MARKETTYPEs { get; set; }
        public virtual DbSet<MONTHLIST> MONTHLISTs { get; set; }
        public virtual DbSet<PROCUREMETHOD> PROCUREMETHODs { get; set; }
        public virtual DbSet<RDPRIORCOMPWEIGHT> RDPRIORCOMPWEIGHTs { get; set; }
        public virtual DbSet<RDPRIORCOMPWEIGHT_DEV> RDPRIORCOMPWEIGHT_DEV { get; set; }
        public virtual DbSet<RDSURFACETYPE> RDSURFACETYPEs { get; set; }
        public virtual DbSet<ROADGC_SM_POSITION> ROADGC_SM_POSITION { get; set; }
        public virtual DbSet<ROADINVENTORY> ROADINVENTORies { get; set; }
        public virtual DbSet<ROADMAINTNEED> ROADMAINTNEEDs { get; set; }
        public virtual DbSet<ROADMAINTNEED_RM> ROADMAINTNEED_RM { get; set; }
        public virtual DbSet<ROADMAINTNEEDSEG> ROADMAINTNEEDSEGs { get; set; }
        public virtual DbSet<ROADMAINTNEEDSTRUCT> ROADMAINTNEEDSTRUCTs { get; set; }
        public virtual DbSet<ROADSEGCOND> ROADSEGCONDs { get; set; }
        public virtual DbSet<ROADSEGCONST> ROADSEGCONSTs { get; set; }
        public virtual DbSet<ROADSEGDCP> ROADSEGDCPs { get; set; }
        public virtual DbSet<ROADSEGDEFLECTION> ROADSEGDEFLECTIONs { get; set; }
        public virtual DbSet<ROADSEGIRI> ROADSEGIRIs { get; set; }
        public virtual DbSet<ROADSEGIRI_HIST> ROADSEGIRI_HIST { get; set; }
        public virtual DbSet<ROADSEGMAINT> ROADSEGMAINTs { get; set; }
        public virtual DbSet<ROADSEGMENT> ROADSEGMENTS { get; set; }
        public virtual DbSet<ROADSOCIOCONN> ROADSOCIOCONNs { get; set; }
        public virtual DbSet<ROADSUMMARY> ROADSUMMARies { get; set; }
        public virtual DbSet<ROADSURVEYINFO> ROADSURVEYINFOes { get; set; }
        public virtual DbSet<ROADTRAFFIC_HIST> ROADTRAFFIC_HIST { get; set; }
        public virtual DbSet<ROADTRAFFICCOUNT> ROADTRAFFICCOUNTs { get; set; }
        public virtual DbSet<ROADTRAFFICCOUNT_HIST> ROADTRAFFICCOUNT_HIST { get; set; }
        public virtual DbSet<ROADTREE> ROADTREEs { get; set; }
        public virtual DbSet<ROADTYPE> ROADTYPES { get; set; }
        public virtual DbSet<ROADUNIONBREAKUP> ROADUNIONBREAKUPs { get; set; }
        public virtual DbSet<SCHEMELIST> SCHEMELISTs { get; set; }
        public virtual DbSet<SCHEMEPROGRESS> SCHEMEPROGRESSes { get; set; }
        public virtual DbSet<SCHEMEROADSEG> SCHEMEROADSEGs { get; set; }
        public virtual DbSet<SCHEMESTRUCTCOMP> SCHEMESTRUCTCOMPs { get; set; }
        public virtual DbSet<SCHEMESTRUCTURE> SCHEMESTRUCTUREs { get; set; }
        public virtual DbSet<SOCIOCAT> SOCIOCATs { get; set; }
        public virtual DbSet<SOCIOTYPE> SOCIOTYPEs { get; set; }
        public virtual DbSet<STRCOMPONENTLIST> STRCOMPONENTLISTs { get; set; }
        public virtual DbSet<STRCONDNONSTRELMT> STRCONDNONSTRELMTs { get; set; }
        public virtual DbSet<STRFOUNDATIONTYPE> STRFOUNDATIONTYPEs { get; set; }
        public virtual DbSet<STRMAINTCOMPONENT> STRMAINTCOMPONENTs { get; set; }
        public virtual DbSet<STRRAILINGTYPE> STRRAILINGTYPEs { get; set; }
        public virtual DbSet<STRSD_ELEMENT> STRSD_ELEMENT { get; set; }
        public virtual DbSet<STRSD_ELEMENT_MISI_FACTOR> STRSD_ELEMENT_MISI_FACTOR { get; set; }
        public virtual DbSet<STRSD_ENV_FACTOR> STRSD_ENV_FACTOR { get; set; }
        public virtual DbSet<STRSD_INSPECTOR_FACTOR> STRSD_INSPECTOR_FACTOR { get; set; }
        public virtual DbSet<STRSD_MATERIAL_FACTOR> STRSD_MATERIAL_FACTOR { get; set; }
        public virtual DbSet<STRSUBSTRMATTYPE> STRSUBSTRMATTYPEs { get; set; }
        public virtual DbSet<STRUCTINSPECTDETAIL> STRUCTINSPECTDETAILs { get; set; }
        public virtual DbSet<STRUCTMAINTCOMP> STRUCTMAINTCOMPs { get; set; }
        public virtual DbSet<STRUCTMAINTENANCE> STRUCTMAINTENANCEs { get; set; }
        public virtual DbSet<STRUCTUREINVENTORY> STRUCTUREINVENTORies { get; set; }
        public virtual DbSet<STRUCTURETYPE> STRUCTURETYPES { get; set; }
        public virtual DbSet<STRWEARSURFTYPE> STRWEARSURFTYPEs { get; set; }
        public virtual DbSet<SUPERVISORLIST> SUPERVISORLISTs { get; set; }
        public virtual DbSet<SUPERVISORUNION> SUPERVISORUNIONs { get; set; }
        public virtual DbSet<TREETYPE> TREETYPEs { get; set; }
        public virtual DbSet<UNIONDELVPCOMP> UNIONDELVPCOMPs { get; set; }
        public virtual DbSet<UNIONDELVPHIST> UNIONDELVPHISTs { get; set; }
        public virtual DbSet<UNIONLIST> UNIONLISTs { get; set; }
        public virtual DbSet<UPCOMPLIST> UPCOMPLISTs { get; set; }
        public virtual DbSet<VEHICLELIST> VEHICLELISTs { get; set; }
        public virtual DbSet<VEHICLETYPE> VEHICLETYPEs { get; set; }
        public virtual DbSet<VEHIMONTHLYMULT> VEHIMONTHLYMULTs { get; set; }
        public virtual DbSet<WORKTYPE> WORKTYPEs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DESIGNATIONLIST>()
                .HasMany(e => e.STRUCTUREINVENTORies)
                .WithOptional(e => e.DESIGNATIONLIST)
                .HasForeignKey(e => e.INSPECTDESIGID);

            modelBuilder.Entity<FUNDALLOCATION>()
                .Property(e => e.EM)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FUNDALLOCATION>()
                .Property(e => e.RM_OFF)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FUNDALLOCATION>()
                .Property(e => e.RM_ON)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FUNDALLOCATION>()
                .Property(e => e.RESEAL)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FUNDALLOCATION>()
                .Property(e => e.PM_OTH_R)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FUNDALLOCATION>()
                .Property(e => e.PM_OTH_S)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FUNDALLOCATION>()
                .Property(e => e.WIDENING)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FUNDALLOCATION>()
                .Property(e => e.REHAB_ROAD)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FUNDALLOCATION>()
                .Property(e => e.REHAB_STRUCT)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FUNDALLOCATION>()
                .Property(e => e.TREEPLANT)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FUNDALLOCATION>()
                .Property(e => e.FUNDRELEASE_PH1)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FUNDALLOCATION>()
                .Property(e => e.FUNDRELEASE_PH2)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FUNDALLOCATION>()
                .Property(e => e.FUNDRELEASE_PH3)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FUNDALLOCATION>()
                .Property(e => e.FUNDRELEASE_PH4)
                .HasPrecision(18, 4);

            modelBuilder.Entity<FUNDINGSOURCE>()
                .HasMany(e => e.FUNDALLOCATIONs)
                .WithOptional(e => e.FUNDINGSOURCE)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FUNDINGSOURCE>()
                .HasMany(e => e.GCSMDELVPHISTs)
                .WithOptional(e => e.FUNDINGSOURCE)
                .WillCascadeOnDelete();

            modelBuilder.Entity<FUNDINGSOURCE>()
                .HasMany(e => e.ROADSEGMAINTs)
                .WithOptional(e => e.FUNDINGSOURCE)
                .HasForeignKey(e => e.MAINTOPRFUNDSRC);

            modelBuilder.Entity<FUNDINGSOURCE>()
                .HasMany(e => e.UNIONDELVPHISTs)
                .WithOptional(e => e.FUNDINGSOURCE)
                .WillCascadeOnDelete();

            modelBuilder.Entity<GC_SM_LIST>()
                .Property(e => e.AREA_GOVT)
                .HasPrecision(18, 4);

            modelBuilder.Entity<GC_SM_LIST>()
                .Property(e => e.AREA_PRVT)
                .HasPrecision(18, 4);

            modelBuilder.Entity<GC_SM_LIST>()
                .HasMany(e => e.GCSMDELVPHISTs)
                .WithOptional(e => e.GC_SM_LIST)
                .WillCascadeOnDelete();

            modelBuilder.Entity<GC_SM_LIST>()
                .HasMany(e => e.GCSMLEASEINFOes)
                .WithOptional(e => e.GC_SM_LIST)
                .WillCascadeOnDelete();

            modelBuilder.Entity<GCSMCOMPLIST>()
                .HasMany(e => e.GCSMDELVPCOMPs)
                .WithOptional(e => e.GCSMCOMPLIST)
                .WillCascadeOnDelete();

            modelBuilder.Entity<GCSMDELVPCOMP>()
                .Property(e => e.COMPQTY)
                .HasPrecision(6, 2);

            modelBuilder.Entity<GCSMDELVPHIST>()
                .Property(e => e.DEVLPCOST)
                .HasPrecision(18, 4);

            modelBuilder.Entity<GCSMDELVPHIST>()
                .HasMany(e => e.GCSMDELVPCOMPs)
                .WithOptional(e => e.GCSMDELVPHIST)
                .WillCascadeOnDelete();

            modelBuilder.Entity<GCSMLEASEINFO>()
                .Property(e => e.LEASEDMONEY)
                .HasPrecision(18, 4);

            modelBuilder.Entity<RDSURFACETYPE>()
                .HasMany(e => e.ROADSEGMENTS)
                .WithOptional(e => e.RDSURFACETYPE)
                .HasForeignKey(e => e.SURFTYPE);

            modelBuilder.Entity<RDSURFACETYPE>()
                .HasMany(e => e.ROADSEGCONSTs)
                .WithRequired(e => e.RDSURFACETYPE)
                .HasForeignKey(e => e.SURFTYPE)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ROADINVENTORY>()
                .Property(e => e.ROADLENGTH)
                .HasPrecision(7, 3);

            modelBuilder.Entity<ROADINVENTORY>()
                .Property(e => e.CRESTWIDTH)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ROADINVENTORY>()
                .Property(e => e.EMBKHEIGHT)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ROADINVENTORY>()
                .Property(e => e.IRI)
                .HasPrecision(6, 2);

            modelBuilder.Entity<ROADINVENTORY>()
                .Property(e => e.DEFLECTION)
                .HasPrecision(6, 2);

            modelBuilder.Entity<ROADINVENTORY>()
                .HasMany(e => e.ROADGC_SM_POSITION)
                .WithOptional(e => e.ROADINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADINVENTORY>()
                .HasOptional(e => e.ROADSURVEYINFO)
                .WithRequired(e => e.ROADINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADINVENTORY>()
                .HasMany(e => e.ROADTRAFFIC_HIST)
                .WithOptional(e => e.ROADINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADINVENTORY>()
                .HasMany(e => e.ROADTRAFFICCOUNTs)
                .WithOptional(e => e.ROADINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADINVENTORY>()
                .HasMany(e => e.ROADTRAFFICCOUNT_HIST)
                .WithOptional(e => e.ROADINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADINVENTORY>()
                .HasMany(e => e.ROADMAINTNEEDs)
                .WithOptional(e => e.ROADINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADINVENTORY>()
                .HasMany(e => e.ROADSEGCONDs)
                .WithOptional(e => e.ROADINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADINVENTORY>()
                .HasMany(e => e.ROADSEGCONSTs)
                .WithOptional(e => e.ROADINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADINVENTORY>()
                .HasMany(e => e.ROADSEGDCPs)
                .WithOptional(e => e.ROADINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADINVENTORY>()
                .HasMany(e => e.ROADSEGDEFLECTIONs)
                .WithOptional(e => e.ROADINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADINVENTORY>()
                .HasMany(e => e.ROADSEGIRI_HIST)
                .WithOptional(e => e.ROADINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADINVENTORY>()
                .HasMany(e => e.ROADSEGIRIs)
                .WithOptional(e => e.ROADINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADINVENTORY>()
                .HasMany(e => e.ROADTREEs)
                .WithOptional(e => e.ROADINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADINVENTORY>()
                .HasMany(e => e.ROADSEGMENTS)
                .WithOptional(e => e.ROADINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADINVENTORY>()
                .HasMany(e => e.ROADSOCIOCONNs)
                .WithOptional(e => e.ROADINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADINVENTORY>()
                .HasMany(e => e.ROADSEGMAINTs)
                .WithOptional(e => e.ROADINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADINVENTORY>()
                .HasMany(e => e.STRUCTUREINVENTORies)
                .WithOptional(e => e.ROADINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADMAINTNEED>()
                .HasMany(e => e.ROADMAINTNEED_RM)
                .WithOptional(e => e.ROADMAINTNEED)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADMAINTNEED>()
                .HasMany(e => e.ROADMAINTNEEDSEGs)
                .WithOptional(e => e.ROADMAINTNEED)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADMAINTNEED>()
                .HasMany(e => e.ROADMAINTNEEDSTRUCTs)
                .WithOptional(e => e.ROADMAINTNEED)
                .WillCascadeOnDelete();

            modelBuilder.Entity<ROADMAINTNEED_RM>()
                .Property(e => e.MAINTLEN)
                .HasPrecision(6, 3);

            modelBuilder.Entity<ROADMAINTNEED_RM>()
                .Property(e => e.ESTMCOST)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ROADMAINTNEEDSEG>()
                .Property(e => e.ESTMCOST)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ROADMAINTNEEDSTRUCT>()
                .Property(e => e.ESTMCOST)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ROADSEGCONST>()
                .Property(e => e.PAVECONSTCOST)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ROADSEGDEFLECTION>()
                .Property(e => e.MAXREAD)
                .HasPrecision(8, 4);

            modelBuilder.Entity<ROADSEGDEFLECTION>()
                .Property(e => e.FINALREAD)
                .HasPrecision(8, 4);

            modelBuilder.Entity<ROADSEGIRI>()
                .Property(e => e.IRI)
                .HasPrecision(6, 2);

            modelBuilder.Entity<ROADSEGIRI_HIST>()
                .Property(e => e.IRI)
                .HasPrecision(6, 2);

            modelBuilder.Entity<ROADSEGMAINT>()
                .Property(e => e.MAINTOPRCOST)
                .HasPrecision(18, 4);

            modelBuilder.Entity<ROADSEGMENT>()
                .Property(e => e.AVGCARGW)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ROADSEGMENT>()
                .Property(e => e.AVGSHOULW_L)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ROADSEGMENT>()
                .Property(e => e.AVGSHOULW_R)
                .HasPrecision(5, 2);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.ROADSUMID)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.ROADNUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.TOTALLENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.BCLENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.CCLENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.RCCLENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.WBMLENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.HBBLENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.BFSLENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.UNBLENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.ERTLENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.SURVEYLENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.GOODLENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.FAIRLENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.POORLENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.BADLENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.BRIDGENUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.BRIDGELENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.GAPNUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.GAPLENGTH)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.MOTORCYCLE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.CAR)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.TEMPO)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.DELIVERYVEHI)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.UTILITYVEHI)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.BUSMINI)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.BUSLIGHT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.BUSHEAVY)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.TRUCKLIGHT)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.TRUCKMEDIUM)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.AUTORICKSHAW)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.RICKSHAW)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.RICKSHAWVAN)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.BICYCLE)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADSUMMARY>()
                .Property(e => e.ANIMCART)
                .HasPrecision(38, 0);

            modelBuilder.Entity<ROADTRAFFIC_HIST>()
                .HasMany(e => e.ROADTRAFFICCOUNT_HIST)
                .WithOptional(e => e.ROADTRAFFIC_HIST)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SCHEMELIST>()
                .Property(e => e.ROADLEN)
                .HasPrecision(8, 3);

            modelBuilder.Entity<SCHEMELIST>()
                .Property(e => e.ESTMCOST)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SCHEMELIST>()
                .Property(e => e.SALVAGECOST)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SCHEMELIST>()
                .Property(e => e.CONTRACTCOST)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SCHEMELIST>()
                .Property(e => e.ALLOCATION)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SCHEMELIST>()
                .Property(e => e.AMT2BPAY_CO)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SCHEMELIST>()
                .HasMany(e => e.SCHEMEPROGRESSes)
                .WithOptional(e => e.SCHEMELIST)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SCHEMELIST>()
                .HasMany(e => e.SCHEMEROADSEGs)
                .WithOptional(e => e.SCHEMELIST)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SCHEMELIST>()
                .HasMany(e => e.SCHEMESTRUCTUREs)
                .WithOptional(e => e.SCHEMELIST)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SCHEMEPROGRESS>()
                .Property(e => e.AMOUNTSPENT)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SCHEMEROADSEG>()
                .Property(e => e.MAINTCOST)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SCHEMESTRUCTURE>()
                .Property(e => e.SPAN)
                .HasPrecision(7, 3);

            modelBuilder.Entity<SCHEMESTRUCTURE>()
                .Property(e => e.MAINTCOST)
                .HasPrecision(18, 4);

            modelBuilder.Entity<SCHEMESTRUCTURE>()
                .Property(e => e.TOBESPAN)
                .HasPrecision(7, 3);

            modelBuilder.Entity<SCHEMESTRUCTURE>()
                .HasMany(e => e.SCHEMESTRUCTCOMPs)
                .WithOptional(e => e.SCHEMESTRUCTURE)
                .WillCascadeOnDelete();

            modelBuilder.Entity<SOCIOCAT>()
                .HasMany(e => e.SOCIOTYPEs)
                .WithOptional(e => e.SOCIOCAT)
                .WillCascadeOnDelete();

            modelBuilder.Entity<STRCOMPONENTLIST>()
                .HasMany(e => e.SCHEMESTRUCTCOMPs)
                .WithOptional(e => e.STRCOMPONENTLIST)
                .WillCascadeOnDelete();

            modelBuilder.Entity<STRCOMPONENTLIST>()
                .HasMany(e => e.STRSD_ELEMENT_MISI_FACTOR)
                .WithOptional(e => e.STRCOMPONENTLIST)
                .WillCascadeOnDelete();

            modelBuilder.Entity<STRCOMPONENTLIST>()
                .HasMany(e => e.STRUCTINSPECTDETAILs)
                .WithOptional(e => e.STRCOMPONENTLIST)
                .HasForeignKey(e => e.DMGCOMPID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<STRFOUNDATIONTYPE>()
                .HasMany(e => e.STRUCTUREINVENTORies)
                .WithOptional(e => e.STRFOUNDATIONTYPE)
                .HasForeignKey(e => e.ABUTFOUNDNTYPE);

            modelBuilder.Entity<STRFOUNDATIONTYPE>()
                .HasMany(e => e.STRUCTUREINVENTORies1)
                .WithOptional(e => e.STRFOUNDATIONTYPE1)
                .HasForeignKey(e => e.PIERFOUNDNTYPE);

            modelBuilder.Entity<STRRAILINGTYPE>()
                .HasMany(e => e.STRUCTUREINVENTORies)
                .WithOptional(e => e.STRRAILINGTYPE)
                .HasForeignKey(e => e.RAILINGTYPE);

            modelBuilder.Entity<STRUCTINSPECTDETAIL>()
                .Property(e => e.COMPQTY)
                .HasPrecision(6, 2);

            modelBuilder.Entity<STRUCTMAINTENANCE>()
                .Property(e => e.MAINTCOST)
                .HasPrecision(18, 4);

            modelBuilder.Entity<STRUCTMAINTENANCE>()
                .HasMany(e => e.STRUCTMAINTCOMPs)
                .WithOptional(e => e.STRUCTMAINTENANCE)
                .WillCascadeOnDelete();

            modelBuilder.Entity<STRUCTUREINVENTORY>()
                .Property(e => e.CONSTCOST)
                .HasPrecision(18, 4);

            modelBuilder.Entity<STRUCTUREINVENTORY>()
                .Property(e => e.LOADRESTRICTWGHT)
                .HasPrecision(7, 3);

            modelBuilder.Entity<STRUCTUREINVENTORY>()
                .Property(e => e.STWIDTH)
                .HasPrecision(7, 2);

            modelBuilder.Entity<STRUCTUREINVENTORY>()
                .Property(e => e.CARRIAGEWIDTH)
                .HasPrecision(5, 2);

            modelBuilder.Entity<STRUCTUREINVENTORY>()
                .Property(e => e.LENEACHSPAN1)
                .HasPrecision(7, 2);

            modelBuilder.Entity<STRUCTUREINVENTORY>()
                .Property(e => e.LENEACHSPAN2)
                .HasPrecision(7, 2);

            modelBuilder.Entity<STRUCTUREINVENTORY>()
                .Property(e => e.LENEACHSPAN3)
                .HasPrecision(7, 2);

            modelBuilder.Entity<STRUCTUREINVENTORY>()
                .Property(e => e.LENEACHSPAN4)
                .HasPrecision(7, 2);

            modelBuilder.Entity<STRUCTUREINVENTORY>()
                .Property(e => e.LENEACHSPAN5)
                .HasPrecision(7, 2);

            modelBuilder.Entity<STRUCTUREINVENTORY>()
                .Property(e => e.LENEACHSPAN6)
                .HasPrecision(7, 2);

            modelBuilder.Entity<STRUCTUREINVENTORY>()
                .Property(e => e.TOTALLENGTH)
                .HasPrecision(7, 2);

            modelBuilder.Entity<STRUCTUREINVENTORY>()
                .Property(e => e.STWIDTHWALK_L)
                .HasPrecision(7, 2);

            modelBuilder.Entity<STRUCTUREINVENTORY>()
                .Property(e => e.STWIDTHWALK_R)
                .HasPrecision(7, 2);

            modelBuilder.Entity<STRUCTUREINVENTORY>()
                .Property(e => e.APPRCHREQD_B)
                .HasPrecision(6, 2);

            modelBuilder.Entity<STRUCTUREINVENTORY>()
                .Property(e => e.APPRCHREQD_F)
                .HasPrecision(6, 2);

            modelBuilder.Entity<STRUCTUREINVENTORY>()
                .Property(e => e.TOTALCSA)
                .HasPrecision(18, 4);

            modelBuilder.Entity<STRUCTUREINVENTORY>()
                .HasMany(e => e.ROADMAINTNEEDSTRUCTs)
                .WithOptional(e => e.STRUCTUREINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<STRUCTUREINVENTORY>()
                .HasMany(e => e.STRUCTINSPECTDETAILs)
                .WithOptional(e => e.STRUCTUREINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<STRUCTUREINVENTORY>()
                .HasMany(e => e.STRUCTMAINTENANCEs)
                .WithOptional(e => e.STRUCTUREINVENTORY)
                .WillCascadeOnDelete();

            modelBuilder.Entity<STRUCTURETYPE>()
                .HasMany(e => e.STRSD_ELEMENT_MISI_FACTOR)
                .WithOptional(e => e.STRUCTURETYPE)
                .WillCascadeOnDelete();

            modelBuilder.Entity<STRWEARSURFTYPE>()
                .HasMany(e => e.STRUCTUREINVENTORies)
                .WithOptional(e => e.STRWEARSURFTYPE)
                .HasForeignKey(e => e.WEARSURFTYPE);

            modelBuilder.Entity<TREETYPE>()
                .HasMany(e => e.ROADTREEs)
                .WithOptional(e => e.TREETYPE1)
                .HasForeignKey(e => e.TREETYPE);

            modelBuilder.Entity<UNIONDELVPCOMP>()
                .Property(e => e.COMPQTY)
                .HasPrecision(6, 2);

            modelBuilder.Entity<UNIONDELVPHIST>()
                .Property(e => e.DEVLPCOST)
                .HasPrecision(18, 4);

            modelBuilder.Entity<UNIONDELVPHIST>()
                .HasMany(e => e.UNIONDELVPCOMPs)
                .WithOptional(e => e.UNIONDELVPHIST)
                .WillCascadeOnDelete();

            modelBuilder.Entity<UNIONLIST>()
                .Property(e => e.YEARLYINCOME)
                .HasPrecision(18, 4);

            modelBuilder.Entity<UNIONLIST>()
                .Property(e => e.UNIONAREA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<UNIONLIST>()
                .Property(e => e.COMPLXAREA)
                .HasPrecision(12, 2);

            modelBuilder.Entity<UNIONLIST>()
                .HasMany(e => e.UNIONDELVPHISTs)
                .WithOptional(e => e.UNIONLIST)
                .WillCascadeOnDelete();

            modelBuilder.Entity<UPCOMPLIST>()
                .HasMany(e => e.UNIONDELVPCOMPs)
                .WithOptional(e => e.UPCOMPLIST)
                .HasForeignKey(e => e.UNCOMPID)
                .WillCascadeOnDelete();

            modelBuilder.Entity<VEHICLELIST>()
                .Property(e => e.HOURLYMULTIPLIER)
                .HasPrecision(6, 2);

            modelBuilder.Entity<VEHICLELIST>()
                .HasMany(e => e.ROADTRAFFICCOUNTs)
                .WithOptional(e => e.VEHICLELIST)
                .WillCascadeOnDelete();

            modelBuilder.Entity<VEHICLELIST>()
                .HasMany(e => e.ROADTRAFFICCOUNT_HIST)
                .WithOptional(e => e.VEHICLELIST)
                .WillCascadeOnDelete();

            modelBuilder.Entity<VEHIMONTHLYMULT>()
                .Property(e => e.MONTHLYMULTIPLIER)
                .HasPrecision(5, 2);
        }
    }
}
