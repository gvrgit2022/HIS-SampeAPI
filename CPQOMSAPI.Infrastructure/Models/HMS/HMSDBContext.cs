using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class HMSDBContext : DbContext
    {
        public HMSDBContext()
        {
        }

        public HMSDBContext(DbContextOptions<HMSDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BlPatientAdmission> BlPatientAdmissions { get; set; }
        public virtual DbSet<TbEsisuser> TbEsisusers { get; set; }
        public virtual DbSet<TblAllotbed> TblAllotbeds { get; set; }
        public virtual DbSet<TblAmbulancerequest> TblAmbulancerequests { get; set; }
        public virtual DbSet<TblBagExpiryTime> TblBagExpiryTimes { get; set; }
        public virtual DbSet<TblBedComplement> TblBedComplements { get; set; }
        public virtual DbSet<TblBedTransferDetaile> TblBedTransferDetailes { get; set; }
        public virtual DbSet<TblBedmaster> TblBedmasters { get; set; }
        public virtual DbSet<TblBedsideprocerdureorder> TblBedsideprocerdureorders { get; set; }
        public virtual DbSet<TblBedsideresultentry> TblBedsideresultentries { get; set; }
        public virtual DbSet<TblBedtype> TblBedtypes { get; set; }
        public virtual DbSet<TblBloodBankMaster> TblBloodBankMasters { get; set; }
        public virtual DbSet<TblBloodRequestView> TblBloodRequestViews { get; set; }
        public virtual DbSet<TblBloodScreening> TblBloodScreenings { get; set; }
        public virtual DbSet<TblBloodbagassign> TblBloodbagassigns { get; set; }
        public virtual DbSet<TblBloodbagretrun> TblBloodbagretruns { get; set; }
        public virtual DbSet<TblConsultationtype> TblConsultationtypes { get; set; }
        public virtual DbSet<TblConsultationtype1> TblConsultationtypes1 { get; set; }
        public virtual DbSet<TblDiscardreason> TblDiscardreasons { get; set; }
        public virtual DbSet<TblDoctorVisit> TblDoctorVisits { get; set; }
        public virtual DbSet<TblDonorRegistration> TblDonorRegistrations { get; set; }
        public virtual DbSet<TblDonorscreening> TblDonorscreenings { get; set; }
        public virtual DbSet<TblDrugadministration> TblDrugadministrations { get; set; }
        public virtual DbSet<TblDrugadministration1> TblDrugadministrations1 { get; set; }
        public virtual DbSet<TblEmployeepersonaldetail> TblEmployeepersonaldetails { get; set; }
        public virtual DbSet<TblEquipmentSlotDuration> TblEquipmentSlotDurations { get; set; }
        public virtual DbSet<TblEquipmentconnection> TblEquipmentconnections { get; set; }
        public virtual DbSet<TblEquipmentslotduration1> TblEquipmentslotdurations1 { get; set; }
        public virtual DbSet<TblErrorLog> TblErrorLogs { get; set; }
        public virtual DbSet<TblEsisuser> TblEsisusers { get; set; }
        public virtual DbSet<TblHealthPassbook> TblHealthPassbooks { get; set; }
        public virtual DbSet<TblIpcrossmatch> TblIpcrossmatches { get; set; }
        public virtual DbSet<TblIssuetootherhospitial> TblIssuetootherhospitials { get; set; }
        public virtual DbSet<TblLicence> TblLicences { get; set; }
        public virtual DbSet<TblNurse> TblNurses { get; set; }
        public virtual DbSet<TblPatientDischarge> TblPatientDischarges { get; set; }
        public virtual DbSet<TblPatientbedTransfer> TblPatientbedTransfers { get; set; }
        public virtual DbSet<TblPatientcasesheet> TblPatientcasesheets { get; set; }
        public virtual DbSet<TblPatientcheckinrestration> TblPatientcheckinrestrations { get; set; }
        public virtual DbSet<TblPrimarydoctorchange> TblPrimarydoctorchanges { get; set; }
        public virtual DbSet<TblRegsterationpage> TblRegsterationpages { get; set; }
        public virtual DbSet<TblSampleCollection> TblSampleCollections { get; set; }
        public virtual DbSet<TblSplittingbag> TblSplittingbags { get; set; }
        public virtual DbSet<TblSplittingcomponent> TblSplittingcomponents { get; set; }
        public virtual DbSet<TblUhidcreation> TblUhidcreations { get; set; }
        public virtual DbSet<TblUpdateBedStatus> TblUpdateBedStatuses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseMySQL("server=103.168.19.36;database=HMS_Dev;uid=gvrhms;pwd=ByCYRq3aSPZGGHW6");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BlPatientAdmission>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("bl_patient_admission");

                entity.Property(e => e.Address)
                    .HasMaxLength(1000)
                    .HasColumnName("address");

                entity.Property(e => e.Address1)
                    .HasMaxLength(1000)
                    .HasColumnName("address1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(1000)
                    .HasColumnName("address2");

                entity.Property(e => e.Admissionno)
                    .HasMaxLength(300)
                    .HasColumnName("admissionno");

                entity.Property(e => e.Admissiontype)
                    .HasMaxLength(200)
                    .HasColumnName("admissiontype");

                entity.Property(e => e.Admitdatetime)
                    .HasMaxLength(100)
                    .HasColumnName("admitdatetime");

                entity.Property(e => e.Admitingdoctor)
                    .HasMaxLength(200)
                    .HasColumnName("admitingdoctor");

                entity.Property(e => e.Age)
                    .HasMaxLength(200)
                    .HasColumnName("age");

                entity.Property(e => e.Bloodgroup)
                    .HasMaxLength(100)
                    .HasColumnName("bloodgroup");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .HasColumnName("city");

                entity.Property(e => e.Country)
                    .HasMaxLength(50)
                    .HasColumnName("country");

                entity.Property(e => e.Createdby).HasMaxLength(200);

                entity.Property(e => e.Createdip).HasMaxLength(200);

                entity.Property(e => e.Dob)
                    .HasMaxLength(100)
                    .HasColumnName("dob");

                entity.Property(e => e.Education)
                    .HasMaxLength(200)
                    .HasColumnName("education");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(200)
                    .HasColumnName("emailid");

                entity.Property(e => e.Employee)
                    .HasMaxLength(200)
                    .HasColumnName("employee");

                entity.Property(e => e.Estdischargedate)
                    .HasMaxLength(200)
                    .HasColumnName("estdischargedate");

                entity.Property(e => e.Fathername)
                    .HasMaxLength(500)
                    .HasColumnName("fathername");

                entity.Property(e => e.Firstname)
                    .HasMaxLength(1000)
                    .HasColumnName("firstname");

                entity.Property(e => e.Gender)
                    .HasMaxLength(50)
                    .HasColumnName("gender");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Identificationmark1)
                    .HasMaxLength(200)
                    .HasColumnName("identificationmark1");

                entity.Property(e => e.Identificationmark2)
                    .HasMaxLength(300)
                    .HasColumnName("identificationmark2");

                entity.Property(e => e.Ipno)
                    .HasMaxLength(200)
                    .HasColumnName("ipno");

                entity.Property(e => e.Ipnou)
                    .HasMaxLength(300)
                    .HasColumnName("ipnou");

                entity.Property(e => e.Ismlc)
                    .HasMaxLength(200)
                    .HasColumnName("ismlc");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(500)
                    .HasColumnName("lastname");

                entity.Property(e => e.Martialstatus)
                    .HasMaxLength(300)
                    .HasColumnName("martialstatus");

                entity.Property(e => e.Middlename)
                    .HasMaxLength(500)
                    .HasColumnName("middlename");

                entity.Property(e => e.Mobileno)
                    .HasColumnType("int(11)")
                    .HasColumnName("mobileno");

                entity.Property(e => e.Modifedip).HasMaxLength(200);

                entity.Property(e => e.Modifiedby).HasMaxLength(200);

                entity.Property(e => e.Mothersmaidenname)
                    .HasMaxLength(500)
                    .HasColumnName("mothersmaidenname");

                entity.Property(e => e.Nationalid)
                    .HasMaxLength(300)
                    .HasColumnName("nationalid");

                entity.Property(e => e.Newborn)
                    .HasMaxLength(500)
                    .HasColumnName("newborn");

                entity.Property(e => e.Occupation)
                    .HasMaxLength(200)
                    .HasColumnName("occupation");

                entity.Property(e => e.Pensioner)
                    .HasMaxLength(200)
                    .HasColumnName("pensioner");

                entity.Property(e => e.Phoneno)
                    .HasColumnType("int(11)")
                    .HasColumnName("phoneno");

                entity.Property(e => e.Pinzipcode)
                    .HasColumnType("int(11)")
                    .HasColumnName("pinzipcode");

                entity.Property(e => e.Reasonforadmission)
                    .HasMaxLength(200)
                    .HasColumnName("reasonforadmission");

                entity.Property(e => e.Referralsourceofadmission)
                    .HasMaxLength(200)
                    .HasColumnName("referralsourceofadmission");

                entity.Property(e => e.Religion)
                    .HasMaxLength(100)
                    .HasColumnName("religion");

                entity.Property(e => e.Specialization)
                    .HasMaxLength(200)
                    .HasColumnName("specialization");

                entity.Property(e => e.Spousename)
                    .HasMaxLength(500)
                    .HasColumnName("spousename");

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .HasColumnName("state");

                entity.Property(e => e.Title)
                    .HasMaxLength(500)
                    .HasColumnName("title");

                entity.Property(e => e.Uhid)
                    .HasMaxLength(500)
                    .HasColumnName("UHID");

                entity.Property(e => e.Unithead)
                    .HasMaxLength(200)
                    .HasColumnName("unithead");

                entity.Property(e => e.Unitname)
                    .HasMaxLength(200)
                    .HasColumnName("unitname");

                entity.Property(e => e.Visittype)
                    .HasMaxLength(200)
                    .HasColumnName("visittype");

                entity.Property(e => e.Ward)
                    .HasMaxLength(200)
                    .HasColumnName("ward");
            });

            modelBuilder.Entity<TbEsisuser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tb_Esisuser");

                entity.Property(e => e.Company).HasMaxLength(200);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(200)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(200)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Designation).HasMaxLength(200);

                entity.Property(e => e.Emailid).HasMaxLength(200);

                entity.Property(e => e.Employeenumber).HasMaxLength(200);

                entity.Property(e => e.Emptype).HasMaxLength(200);

                entity.Property(e => e.Firstname).HasMaxLength(200);

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Iscore).HasMaxLength(200);

                entity.Property(e => e.Lastname).HasMaxLength(200);

                entity.Property(e => e.Location).HasMaxLength(200);

                entity.Property(e => e.Locationcode).HasMaxLength(200);

                entity.Property(e => e.Locationtype).HasMaxLength(200);

                entity.Property(e => e.Middlename).HasMaxLength(200);

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Password1)
                    .HasMaxLength(200)
                    .HasColumnName("password1");

                entity.Property(e => e.Username)
                    .HasMaxLength(200)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<TblAllotbed>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_allotbed");

                entity.Property(e => e.Admissionnumber).HasMaxLength(100);

                entity.Property(e => e.Age).HasColumnType("int(11)");

                entity.Property(e => e.BedName).HasMaxLength(500);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(500)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(300)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Currentstatus)
                    .HasMaxLength(500)
                    .HasColumnName("currentstatus");

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(500)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(500)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.PatientName).HasMaxLength(300);

                entity.Property(e => e.UnitHead).HasMaxLength(500);

                entity.Property(e => e.UnitName).HasMaxLength(500);
            });

            modelBuilder.Entity<TblAmbulancerequest>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_ambulancerequest");

                entity.Property(e => e.Address).HasMaxLength(1000);

                entity.Property(e => e.Age).HasMaxLength(20);

                entity.Property(e => e.Authorizedby).HasMaxLength(200);

                entity.Property(e => e.Bednumber).HasMaxLength(200);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(200)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(200)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Destination).HasMaxLength(200);

                entity.Property(e => e.Dob)
                    .HasMaxLength(100)
                    .HasColumnName("DOB");

                entity.Property(e => e.External).HasMaxLength(200);

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Insurancenumber).HasMaxLength(200);

                entity.Property(e => e.Internal).HasMaxLength(200);

                entity.Property(e => e.Location).HasMaxLength(200);

                entity.Property(e => e.Mobilenumber).HasMaxLength(200);

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Patientcondition).HasMaxLength(200);

                entity.Property(e => e.Patientname).HasMaxLength(200);

                entity.Property(e => e.Receivedby).HasMaxLength(200);

                entity.Property(e => e.Receiveddate).HasMaxLength(200);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.Requestnumber).HasMaxLength(200);

                entity.Property(e => e.Requireddate).HasMaxLength(200);

                entity.Property(e => e.Uhid)
                    .HasMaxLength(200)
                    .HasColumnName("UHID");
            });

            modelBuilder.Entity<TblBagExpiryTime>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_BagExpiryTime");

                entity.Property(e => e.Bagtype).HasMaxLength(200);

                entity.Property(e => e.Component).HasMaxLength(200);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(200)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(200)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Epirytime).HasMaxLength(200);

                entity.Property(e => e.Expirymonths).HasMaxLength(200);

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Storagetemperature).HasMaxLength(200);

                entity.Property(e => e.Storagetemperature2).HasMaxLength(200);
            });

            modelBuilder.Entity<TblBedComplement>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_bed_complement");

                entity.Property(e => e.Commisionbed).HasMaxLength(100);

                entity.Property(e => e.CommissionedBedCount).HasMaxLength(100);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Sanctionbed).HasMaxLength(100);

                entity.Property(e => e.Specialisation).HasMaxLength(100);
            });

            modelBuilder.Entity<TblBedTransferDetaile>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_BedTransferDetailes");

                entity.Property(e => e.Admissionnumber).HasMaxLength(200);

                entity.Property(e => e.Age).HasMaxLength(20);

                entity.Property(e => e.Bed).HasMaxLength(200);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(200)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(200)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.IpNo).HasMaxLength(200);

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Patientname).HasMaxLength(200);

                entity.Property(e => e.Ward).HasMaxLength(100);
            });

            modelBuilder.Entity<TblBedmaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Bedmaster");

                entity.Property(e => e.Airconditioner).HasMaxLength(200);

                entity.Property(e => e.Bedname).HasMaxLength(200);

                entity.Property(e => e.Bedtype)
                    .HasMaxLength(200)
                    .HasColumnName("bedtype");

                entity.Property(e => e.Blocked).HasMaxLength(200);

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(200)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(200)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Direction).HasMaxLength(200);

                entity.Property(e => e.Extension).HasMaxLength(200);

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Location).HasMaxLength(100);

                entity.Property(e => e.Manufacturer).HasMaxLength(200);

                entity.Property(e => e.Microwaveoven).HasMaxLength(200);

                entity.Property(e => e.Modelno).HasMaxLength(200);

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Nebuliser).HasMaxLength(200);

                entity.Property(e => e.Refrigerator).HasMaxLength(200);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.Room).HasMaxLength(200);

                entity.Property(e => e.Serialno).HasMaxLength(200);

                entity.Property(e => e.Status1).HasMaxLength(200);

                entity.Property(e => e.Wardname).HasMaxLength(200);
            });

            modelBuilder.Entity<TblBedsideprocerdureorder>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_BEDSIDEPROCERDUREORDER");

                entity.Property(e => e.Admissionno).HasMaxLength(50);

                entity.Property(e => e.Age).HasMaxLength(6);

                entity.Property(e => e.Bed)
                    .HasMaxLength(50)
                    .HasColumnName("bed");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(50)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Doctorname)
                    .HasMaxLength(50)
                    .HasColumnName("doctorname");

                entity.Property(e => e.Gender)
                    .HasMaxLength(8)
                    .HasColumnName("gender");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Ipnumber)
                    .HasMaxLength(50)
                    .HasColumnName("ipnumber");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(50)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Operator).HasColumnName("operator");

                entity.Property(e => e.Orderdatetime).HasColumnName("orderdatetime");

                entity.Property(e => e.Orderno)
                    .HasMaxLength(30)
                    .HasColumnName("orderno");

                entity.Property(e => e.Unithead).HasMaxLength(50);
            });

            modelBuilder.Entity<TblBedsideresultentry>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_bedsideresultentry");

                entity.Property(e => e.Admissionnumber).HasMaxLength(200);

                entity.Property(e => e.Age).HasMaxLength(200);

                entity.Property(e => e.Bed).HasMaxLength(200);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(200)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(200)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Doctorname).HasMaxLength(200);

                entity.Property(e => e.Gender).HasMaxLength(200);

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Patientname).HasMaxLength(200);

                entity.Property(e => e.Testname).HasMaxLength(200);

                entity.Property(e => e.Uhid)
                    .HasMaxLength(200)
                    .HasColumnName("UHID");

                entity.Property(e => e.Ward).HasMaxLength(200);
            });

            modelBuilder.Entity<TblBedtype>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_bedtype");

                entity.Property(e => e.Blocked).HasMaxLength(100);

                entity.Property(e => e.Category)
                    .HasMaxLength(100)
                    .HasColumnName("category");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Patientname).HasMaxLength(100);
            });

            modelBuilder.Entity<TblBloodBankMaster>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_BloodBankMaster");

                entity.Property(e => e.Address1).HasMaxLength(500);

                entity.Property(e => e.Blocked).HasMaxLength(20);

                entity.Property(e => e.City).HasMaxLength(20);

                entity.Property(e => e.Code).HasMaxLength(200);

                entity.Property(e => e.Contactperson).HasMaxLength(200);

                entity.Property(e => e.Country).HasMaxLength(10);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(200)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(200)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Emailid).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Lincenseno).HasMaxLength(200);

                entity.Property(e => e.Mobileno).HasMaxLength(20);

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Phoneno).HasMaxLength(20);

                entity.Property(e => e.Pincode).HasMaxLength(10);

                entity.Property(e => e.State1).HasMaxLength(20);
            });

            modelBuilder.Entity<TblBloodRequestView>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_blood_request_view");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(200)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(200)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Gender).HasMaxLength(200);

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.OrderNo).HasMaxLength(200);

                entity.Property(e => e.PatientName).HasMaxLength(200);

                entity.Property(e => e.ReqFromDate).HasMaxLength(200);

                entity.Property(e => e.ReqTodate).HasMaxLength(200);
            });

            modelBuilder.Entity<TblBloodScreening>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Blood_screening");

                entity.Property(e => e.Age).HasMaxLength(10);

                entity.Property(e => e.BagNo).HasMaxLength(200);

                entity.Property(e => e.BloodGroup).HasMaxLength(200);

                entity.Property(e => e.Createdby).HasMaxLength(200);

                entity.Property(e => e.Createdip).HasMaxLength(200);

                entity.Property(e => e.DateofDonation).HasMaxLength(200);

                entity.Property(e => e.DocotorName).HasMaxLength(200);

                entity.Property(e => e.DonorName).HasMaxLength(200);

                entity.Property(e => e.DonorType).HasMaxLength(200);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.Hb)
                    .HasMaxLength(200)
                    .HasColumnName("HB");

                entity.Property(e => e.Id).HasColumnType("int(11)");

                entity.Property(e => e.Modifiedby).HasMaxLength(200);

                entity.Property(e => e.Modifiedip).HasMaxLength(200);

                entity.Property(e => e.NoneTherapeutic).HasMaxLength(200);

                entity.Property(e => e.Remarks).HasMaxLength(200);

                entity.Property(e => e.Remarks1).HasMaxLength(200);

                entity.Property(e => e.SampleNo).HasMaxLength(200);

                entity.Property(e => e.ScreeningType).HasMaxLength(200);

                entity.Property(e => e.Status).HasMaxLength(200);

                entity.Property(e => e.Therapeutic).HasMaxLength(200);

                entity.Property(e => e.TypeofPheresis).HasMaxLength(200);

                entity.Property(e => e.VerifiedBy).HasMaxLength(200);

                entity.Property(e => e.Weight).HasMaxLength(200);
            });

            modelBuilder.Entity<TblBloodbagassign>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_bloodbagassign");

                entity.Property(e => e.Admissionnummber)
                    .HasMaxLength(200)
                    .HasColumnName("admissionnummber");

                entity.Property(e => e.Age)
                    .HasMaxLength(20)
                    .HasColumnName("age");

                entity.Property(e => e.BagNo).HasMaxLength(200);

                entity.Property(e => e.Bednumber)
                    .HasMaxLength(100)
                    .HasColumnName("bednumber");

                entity.Property(e => e.Bloodgroup)
                    .HasMaxLength(100)
                    .HasColumnName("bloodgroup");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(200)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.DoctorName).HasMaxLength(200);

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.PatientName).HasMaxLength(200);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(1000)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblBloodbagretrun>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_bloodbagretrun");

                entity.Property(e => e.Admissionnummber)
                    .HasMaxLength(200)
                    .HasColumnName("admissionnummber");

                entity.Property(e => e.Age)
                    .HasMaxLength(20)
                    .HasColumnName("age");

                entity.Property(e => e.BagNo).HasMaxLength(100);

                entity.Property(e => e.Bednumber)
                    .HasMaxLength(200)
                    .HasColumnName("bednumber");

                entity.Property(e => e.Bloodgroup)
                    .HasMaxLength(200)
                    .HasColumnName("bloodgroup");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(200)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(200)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.DoctorName).HasMaxLength(200);

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(200)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.PatientName).HasMaxLength(200);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(200)
                    .HasColumnName("remarks");
            });

            modelBuilder.Entity<TblConsultationtype>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl__consultationtype");

                entity.Property(e => e.Blocked).HasMaxLength(100);

                entity.Property(e => e.ConsultationCode).HasMaxLength(100);

                entity.Property(e => e.ConsultationType).HasMaxLength(100);

                entity.Property(e => e.CoverageType).HasMaxLength(100);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");
            });

            modelBuilder.Entity<TblConsultationtype1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_consultationtype");

                entity.Property(e => e.Blocked).HasMaxLength(50);

                entity.Property(e => e.ConsultationCode).HasMaxLength(100);

                entity.Property(e => e.ConsultationType).HasMaxLength(100);

                entity.Property(e => e.CoverageType).HasMaxLength(200);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");
            });

            modelBuilder.Entity<TblDiscardreason>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_discardreason");

                entity.Property(e => e.Blocked).HasMaxLength(100);

                entity.Property(e => e.Code)
                    .HasMaxLength(100)
                    .HasColumnName("code");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<TblDoctorVisit>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_DoctorVisits");

                entity.Property(e => e.AdmissionNo).HasMaxLength(100);

                entity.Property(e => e.Age).HasMaxLength(20);

                entity.Property(e => e.Allergies).HasMaxLength(500);

                entity.Property(e => e.Bed).HasMaxLength(100);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.DateTime).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Ipno)
                    .HasMaxLength(50)
                    .HasColumnName("IPNo");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.OrderNo).HasMaxLength(100);

                entity.Property(e => e.PatientName).HasMaxLength(100);

                entity.Property(e => e.Uhid)
                    .HasMaxLength(100)
                    .HasColumnName("UHID");

                entity.Property(e => e.UnitHead).HasMaxLength(100);

                entity.Property(e => e.UnitName).HasMaxLength(100);

                entity.Property(e => e.Ward).HasMaxLength(100);
            });

            modelBuilder.Entity<TblDonorRegistration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Donor_registration");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.Address1).HasMaxLength(100);

                entity.Property(e => e.AdmissionNo).HasMaxLength(100);

                entity.Property(e => e.Age).HasMaxLength(10);

                entity.Property(e => e.BloodGroup).HasMaxLength(100);

                entity.Property(e => e.CampDate).HasMaxLength(100);

                entity.Property(e => e.CampName).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(20);

                entity.Property(e => e.City1).HasMaxLength(20);

                entity.Property(e => e.Country).HasMaxLength(20);

                entity.Property(e => e.Country1).HasMaxLength(20);

                entity.Property(e => e.Createdby).HasMaxLength(20);

                entity.Property(e => e.Createdip).HasMaxLength(100);

                entity.Property(e => e.DateofRegistration).HasMaxLength(100);

                entity.Property(e => e.Dateofbirth).HasMaxLength(100);

                entity.Property(e => e.DonorNo).HasMaxLength(100);

                entity.Property(e => e.DrugAllergies).HasMaxLength(100);

                entity.Property(e => e.Education).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(20);

                entity.Property(e => e.Email1).HasMaxLength(50);

                entity.Property(e => e.Employee).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(200);

                entity.Property(e => e.FoodAllergies).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.KnowAllergies).HasMaxLength(100);

                entity.Property(e => e.LastName).HasMaxLength(200);

                entity.Property(e => e.MiddleName).HasMaxLength(200);

                entity.Property(e => e.Mobile).HasMaxLength(20);

                entity.Property(e => e.Mobile1).HasMaxLength(20);

                entity.Property(e => e.Modifiedby).HasMaxLength(100);

                entity.Property(e => e.Modifiedip).HasMaxLength(100);

                entity.Property(e => e.Occupation).HasMaxLength(100);

                entity.Property(e => e.PhoneNo).HasMaxLength(20);

                entity.Property(e => e.PhoneNo1).HasMaxLength(20);

                entity.Property(e => e.PinZipcode).HasMaxLength(20);

                entity.Property(e => e.PinZipcode1).HasMaxLength(10);

                entity.Property(e => e.State).HasMaxLength(10);

                entity.Property(e => e.State1).HasMaxLength(20);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.Uhid)
                    .HasMaxLength(100)
                    .HasColumnName("UHID");
            });

            modelBuilder.Entity<TblDonorscreening>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Donorscreening");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Age).HasMaxLength(20);

                entity.Property(e => e.BloodGroup).HasMaxLength(100);

                entity.Property(e => e.BloodGroup1).HasMaxLength(50);

                entity.Property(e => e.Bp)
                    .HasMaxLength(50)
                    .HasColumnName("BP");

                entity.Property(e => e.Createdby).HasMaxLength(100);

                entity.Property(e => e.Createdip).HasMaxLength(100);

                entity.Property(e => e.Cvs)
                    .HasMaxLength(100)
                    .HasColumnName("CVS");

                entity.Property(e => e.DonorName).HasMaxLength(200);

                entity.Property(e => e.DonorNo).HasMaxLength(100);

                entity.Property(e => e.DonorQuestionsnaire).HasMaxLength(100);

                entity.Property(e => e.DonorScreenNo).HasMaxLength(200);

                entity.Property(e => e.DonorStatus).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.Hb).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Liver).HasMaxLength(100);

                entity.Property(e => e.MobileNo).HasMaxLength(20);

                entity.Property(e => e.Modifiedby).HasMaxLength(100);

                entity.Property(e => e.Modifiedip).HasMaxLength(100);

                entity.Property(e => e.PhoneNo).HasMaxLength(20);

                entity.Property(e => e.Pluse).HasMaxLength(100);

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.Property(e => e.RespiratorySystem).HasMaxLength(100);

                entity.Property(e => e.Spleen).HasMaxLength(100);

                entity.Property(e => e.Temperature).HasMaxLength(50);

                entity.Property(e => e.Weight).HasMaxLength(100);
            });

            modelBuilder.Entity<TblDrugadministration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Drugadministration");

                entity.Property(e => e.AdmissionNo).HasMaxLength(100);

                entity.Property(e => e.Age).HasMaxLength(50);

                entity.Property(e => e.Allergies).HasMaxLength(100);

                entity.Property(e => e.Bed).HasMaxLength(100);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Ipno)
                    .HasMaxLength(100)
                    .HasColumnName("IPNO");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Operator).HasMaxLength(100);

                entity.Property(e => e.PatientName).HasMaxLength(100);

                entity.Property(e => e.Specialization).HasMaxLength(100);

                entity.Property(e => e.UniteHead).HasMaxLength(100);

                entity.Property(e => e.UniteName).HasMaxLength(100);

                entity.Property(e => e.Ward).HasMaxLength(100);
            });

            modelBuilder.Entity<TblDrugadministration1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl__Drugadministration");

                entity.Property(e => e.AdmissionNo).HasMaxLength(100);

                entity.Property(e => e.Age).HasMaxLength(20);

                entity.Property(e => e.Allergies).HasMaxLength(1000);

                entity.Property(e => e.Bed).HasMaxLength(100);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.DateTime1).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Ipno)
                    .HasMaxLength(100)
                    .HasColumnName("IPNO");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Operator).HasMaxLength(100);

                entity.Property(e => e.PatientName).HasMaxLength(200);

                entity.Property(e => e.Specialization).HasMaxLength(300);

                entity.Property(e => e.UniteHead).HasMaxLength(100);

                entity.Property(e => e.UniteName).HasMaxLength(200);

                entity.Property(e => e.Ward).HasMaxLength(100);
            });

            modelBuilder.Entity<TblEmployeepersonaldetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Employeepersonaldetails");

                entity.Property(e => e.Address1).HasMaxLength(1000);

                entity.Property(e => e.Address2).HasMaxLength(1000);

                entity.Property(e => e.Address3).HasMaxLength(1000);

                entity.Property(e => e.Address4).HasMaxLength(1000);

                entity.Property(e => e.Age).HasMaxLength(200);

                entity.Property(e => e.Blocked).HasMaxLength(20);

                entity.Property(e => e.Bloodgroup).HasMaxLength(100);

                entity.Property(e => e.City).HasMaxLength(300);

                entity.Property(e => e.City2).HasMaxLength(300);

                entity.Property(e => e.Country).HasMaxLength(300);

                entity.Property(e => e.Country2).HasMaxLength(300);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(500)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(500)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Department).HasMaxLength(500);

                entity.Property(e => e.Desisgnation).HasMaxLength(500);

                entity.Property(e => e.Dob).HasMaxLength(100);

                entity.Property(e => e.Employeeno).HasMaxLength(200);

                entity.Property(e => e.Employeetype).HasMaxLength(300);

                entity.Property(e => e.Expirydate).HasMaxLength(200);

                entity.Property(e => e.Firstname).HasMaxLength(500);

                entity.Property(e => e.Fulltime).HasMaxLength(200);

                entity.Property(e => e.Gender).HasMaxLength(200);

                entity.Property(e => e.Id).HasMaxLength(100);

                entity.Property(e => e.Imgpath)
                    .HasMaxLength(100)
                    .HasColumnName("imgpath");

                entity.Property(e => e.Issuedate).HasMaxLength(500);

                entity.Property(e => e.Languagesknown).HasMaxLength(1000);

                entity.Property(e => e.Lastname).HasMaxLength(500);

                entity.Property(e => e.Location).HasMaxLength(500);

                entity.Property(e => e.Middlename).HasMaxLength(500);

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(500)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(50)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Nationality).HasMaxLength(200);

                entity.Property(e => e.Nearby).HasMaxLength(1000);

                entity.Property(e => e.Neraby2).HasMaxLength(1000);

                entity.Property(e => e.Passportno).HasMaxLength(500);

                entity.Property(e => e.Phoneno)
                    .HasMaxLength(20)
                    .HasColumnName("phoneno");

                entity.Property(e => e.Phoneno2).HasMaxLength(20);

                entity.Property(e => e.Pincode).HasMaxLength(20);

                entity.Property(e => e.Pincode2).HasMaxLength(20);

                entity.Property(e => e.Religion).HasMaxLength(300);

                entity.Property(e => e.Ssn).HasMaxLength(300);

                entity.Property(e => e.State2).HasMaxLength(300);

                entity.Property(e => e.States).HasMaxLength(300);

                entity.Property(e => e.Streetno1).HasMaxLength(1000);

                entity.Property(e => e.Streetno2).HasMaxLength(1000);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<TblEquipmentSlotDuration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_equipment_slot_duration");

                entity.Property(e => e.Createdby).HasMaxLength(200);

                entity.Property(e => e.Createdip).HasMaxLength(200);

                entity.Property(e => e.ForEvery).HasMaxLength(200);

                entity.Property(e => e.ForTime).HasMaxLength(200);

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Items).HasMaxLength(200);

                entity.Property(e => e.Modifiedby).HasMaxLength(200);

                entity.Property(e => e.Modifiedip).HasMaxLength(200);

                entity.Property(e => e.ServiceName).HasMaxLength(200);

                entity.Property(e => e.ToTime).HasMaxLength(200);

                entity.Property(e => e.Type).HasMaxLength(200);
            });

            modelBuilder.Entity<TblEquipmentconnection>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_equipmentconnections");

                entity.Property(e => e.AdmissionNo).HasMaxLength(100);

                entity.Property(e => e.Age).HasMaxLength(10);

                entity.Property(e => e.Bed).HasMaxLength(50);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.DateTime1).HasMaxLength(20);

                entity.Property(e => e.DoctorName).HasMaxLength(100);

                entity.Property(e => e.Equipment).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.IpNo).HasMaxLength(50);

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Operator).HasMaxLength(100);

                entity.Property(e => e.OrderNo).HasMaxLength(100);

                entity.Property(e => e.PatientName).HasMaxLength(100);

                entity.Property(e => e.UnitedHead).HasMaxLength(100);
            });

            modelBuilder.Entity<TblEquipmentslotduration1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_equipmentslotduration");

                entity.Property(e => e.Createdby).HasMaxLength(100);

                entity.Property(e => e.Createdip).HasMaxLength(100);

                entity.Property(e => e.ForEvery).HasMaxLength(100);

                entity.Property(e => e.ForTime).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Items).HasMaxLength(100);

                entity.Property(e => e.Modifiedby).HasMaxLength(100);

                entity.Property(e => e.Modifiedip).HasMaxLength(100);

                entity.Property(e => e.ServiceName).HasMaxLength(100);

                entity.Property(e => e.ToTime).HasMaxLength(100);

                entity.Property(e => e.Type1).HasMaxLength(100);
            });

            modelBuilder.Entity<TblErrorLog>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_error_log");

                entity.Property(e => e.ErrDate).HasColumnName("err_date");

                entity.Property(e => e.ErrId)
                    .HasColumnType("int(11)")
                    .HasColumnName("err_id");

                entity.Property(e => e.ErrModule)
                    .HasMaxLength(1000)
                    .HasColumnName("err_module");

                entity.Property(e => e.ErrMsg)
                    .HasMaxLength(300)
                    .HasColumnName("err_msg");

                entity.Property(e => e.ErrNum)
                    .HasMaxLength(20)
                    .HasColumnName("err_num");

                entity.Property(e => e.ErrProc)
                    .HasMaxLength(1000)
                    .HasColumnName("err_proc");

                entity.Property(e => e.ErrSeverity)
                    .HasMaxLength(150)
                    .HasColumnName("err_severity");

                entity.Property(e => e.ErrState)
                    .HasMaxLength(100)
                    .HasColumnName("err_state");

                entity.Property(e => e.ErrType)
                    .HasMaxLength(500)
                    .HasColumnName("err_type");

                entity.Property(e => e.ErrValue)
                    .HasMaxLength(200)
                    .HasColumnName("err_value");
            });

            modelBuilder.Entity<TblEsisuser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Esisuser");

                entity.Property(e => e.Company)
                    .HasMaxLength(100)
                    .HasColumnName("company");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Designation)
                    .HasMaxLength(100)
                    .HasColumnName("designation");

                entity.Property(e => e.Emailid)
                    .HasMaxLength(100)
                    .HasColumnName("emailid");

                entity.Property(e => e.Employeenumber).HasMaxLength(100);

                entity.Property(e => e.Emptype)
                    .HasMaxLength(100)
                    .HasColumnName("emptype");

                entity.Property(e => e.Firstname).HasMaxLength(200);

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Iscore)
                    .HasMaxLength(100)
                    .HasColumnName("iscore");

                entity.Property(e => e.Lastname)
                    .HasMaxLength(200)
                    .HasColumnName("lastname");

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .HasColumnName("location");

                entity.Property(e => e.Locationcode)
                    .HasMaxLength(100)
                    .HasColumnName("locationcode");

                entity.Property(e => e.Locationtype)
                    .HasMaxLength(100)
                    .HasColumnName("locationtype");

                entity.Property(e => e.Middlename).HasMaxLength(200);

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Password1)
                    .HasMaxLength(100)
                    .HasColumnName("password1");

                entity.Property(e => e.Username)
                    .HasMaxLength(200)
                    .HasColumnName("username");
            });

            modelBuilder.Entity<TblHealthPassbook>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_HealthPassbook");

                entity.Property(e => e.Address)
                    .HasMaxLength(1000)
                    .HasColumnName("address");

                entity.Property(e => e.Address2)
                    .HasMaxLength(1000)
                    .HasColumnName("address2");

                entity.Property(e => e.Age).HasColumnType("int(11)");

                entity.Property(e => e.Age1)
                    .HasMaxLength(200)
                    .HasColumnName("age1");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(500)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(300)
                    .HasColumnName("createdip");

                entity.Property(e => e.Datetime).HasColumnName("datetime");

                entity.Property(e => e.Dob)
                    .HasMaxLength(100)
                    .HasColumnName("dob");

                entity.Property(e => e.Dob1)
                    .HasMaxLength(50)
                    .HasColumnName("dob1");

                entity.Property(e => e.Gender)
                    .HasMaxLength(20)
                    .HasColumnName("gender");

                entity.Property(e => e.Gender1)
                    .HasMaxLength(20)
                    .HasColumnName("gender1");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("id");

                entity.Property(e => e.Ipno)
                    .HasMaxLength(300)
                    .HasColumnName("ipno");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(300)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(500)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.Name1).HasMaxLength(200);

                entity.Property(e => e.Relationship)
                    .HasMaxLength(300)
                    .HasColumnName("relationship");

                entity.Property(e => e.Uhid).HasMaxLength(500);
            });

            modelBuilder.Entity<TblIpcrossmatch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_ipcrossmatch");

                entity.Property(e => e.Createdby).HasMaxLength(100);

                entity.Property(e => e.Createdip).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Modifiedby).HasMaxLength(100);

                entity.Property(e => e.Modifiedip).HasMaxLength(100);

                entity.Property(e => e.OrderNo).HasMaxLength(100);

                entity.Property(e => e.PatientName).HasMaxLength(100);

                entity.Property(e => e.ReqFromDate).HasMaxLength(100);

                entity.Property(e => e.ReqToDate).HasMaxLength(100);
            });

            modelBuilder.Entity<TblIssuetootherhospitial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Issuetootherhospitial");

                entity.Property(e => e.BloodBank).HasMaxLength(100);

                entity.Property(e => e.Createdby).HasMaxLength(100);

                entity.Property(e => e.Createdip).HasMaxLength(100);

                entity.Property(e => e.Hospitial).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.IssueNo).HasMaxLength(100);

                entity.Property(e => e.IssuedBy).HasMaxLength(100);

                entity.Property(e => e.IssuedDate).HasMaxLength(100);

                entity.Property(e => e.Modifiedby).HasMaxLength(100);

                entity.Property(e => e.Modifiedip).HasMaxLength(100);

                entity.Property(e => e.Priority).HasMaxLength(100);

                entity.Property(e => e.ReceivedBy).HasMaxLength(100);

                entity.Property(e => e.Remark).HasMaxLength(1000);

                entity.Property(e => e.RequestedBy).HasMaxLength(100);

                entity.Property(e => e.RequestedDate).HasMaxLength(100);
            });

            modelBuilder.Entity<TblLicence>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Licence");

                entity.Property(e => e.Blocked).HasMaxLength(30);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(50)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(50)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Licenceno).HasMaxLength(50);

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(50)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(50)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");
            });

            modelBuilder.Entity<TblNurse>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_nurse");

                entity.Property(e => e.AdmissionNo).HasMaxLength(100);

                entity.Property(e => e.Age).HasColumnType("int(11)");

                entity.Property(e => e.Bed).HasMaxLength(100);

                entity.Property(e => e.Createdby).HasMaxLength(50);

                entity.Property(e => e.Createdip).HasMaxLength(100);

                entity.Property(e => e.Frequency).HasMaxLength(100);

                entity.Property(e => e.FromDate).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Interval1).HasMaxLength(100);

                entity.Property(e => e.Ipno)
                    .HasMaxLength(100)
                    .HasColumnName("IPNo");

                entity.Property(e => e.Modifiedby).HasMaxLength(100);

                entity.Property(e => e.Modifiedip).HasMaxLength(100);

                entity.Property(e => e.Operator).HasMaxLength(100);

                entity.Property(e => e.PatientName).HasMaxLength(100);

                entity.Property(e => e.Task).HasMaxLength(100);

                entity.Property(e => e.ToDate).HasMaxLength(100);

                entity.Property(e => e.Ward).HasMaxLength(100);
            });

            modelBuilder.Entity<TblPatientDischarge>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_PatientDischarge");

                entity.Property(e => e.AdmissionNo).HasMaxLength(100);

                entity.Property(e => e.Age).HasMaxLength(100);

                entity.Property(e => e.Bed).HasMaxLength(100);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.DateTime1).HasMaxLength(100);

                entity.Property(e => e.Datetime).HasMaxLength(100);

                entity.Property(e => e.DischargeReason).HasMaxLength(100);

                entity.Property(e => e.DischargeStatus).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Ipno)
                    .HasMaxLength(50)
                    .HasColumnName("IPNo");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Operator).HasMaxLength(100);

                entity.Property(e => e.OrderNo).HasMaxLength(100);

                entity.Property(e => e.PatientName).HasMaxLength(100);

                entity.Property(e => e.Remarks).HasMaxLength(500);

                entity.Property(e => e.RequestType).HasMaxLength(100);

                entity.Property(e => e.UnitedHead).HasMaxLength(100);
            });

            modelBuilder.Entity<TblPatientbedTransfer>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_PatientbedTransfer");

                entity.Property(e => e.AdmissionNo).HasMaxLength(100);

                entity.Property(e => e.AdmissionRemarks).HasMaxLength(200);

                entity.Property(e => e.AdmittedDateTime).HasMaxLength(50);

                entity.Property(e => e.Age).HasMaxLength(10);

                entity.Property(e => e.Bed).HasMaxLength(100);

                entity.Property(e => e.Bed1).HasMaxLength(100);

                entity.Property(e => e.BedType).HasMaxLength(100);

                entity.Property(e => e.BedType1).HasMaxLength(100);

                entity.Property(e => e.BilledBedType).HasMaxLength(100);

                entity.Property(e => e.BilledBedType1).HasMaxLength(100);

                entity.Property(e => e.Consultant).HasMaxLength(100);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Gender).HasMaxLength(10);

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Ipno)
                    .HasMaxLength(100)
                    .HasColumnName("IPNo");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.OccuipedDateTime).HasMaxLength(50);

                entity.Property(e => e.PatientName).HasMaxLength(200);

                entity.Property(e => e.TransferRequestRemarks).HasMaxLength(100);

                entity.Property(e => e.TransferToNewBed).HasMaxLength(100);

                entity.Property(e => e.Uhid)
                    .HasMaxLength(100)
                    .HasColumnName("UHID");

                entity.Property(e => e.UnitName).HasMaxLength(100);

                entity.Property(e => e.UnitName1).HasMaxLength(100);

                entity.Property(e => e.Ward).HasMaxLength(100);

                entity.Property(e => e.Ward1).HasMaxLength(100);
            });

            modelBuilder.Entity<TblPatientcasesheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Patientcasesheet");

                entity.Property(e => e.Age).HasMaxLength(100);

                entity.Property(e => e.Checindatetime).HasColumnName("checindatetime");

                entity.Property(e => e.Checkinno)
                    .HasColumnType("int(11)")
                    .HasColumnName("checkinno");

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon)
                    .HasColumnType("date")
                    .HasColumnName("createdon");

                entity.Property(e => e.Followup)
                    .HasMaxLength(100)
                    .HasColumnName("followup");

                entity.Property(e => e.Gender)
                    .HasMaxLength(100)
                    .HasColumnName("gender");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Ipno)
                    .HasMaxLength(100)
                    .HasColumnName("ipno");

                entity.Property(e => e.Liveliststatus)
                    .HasMaxLength(100)
                    .HasColumnName("liveliststatus");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon)
                    .HasColumnType("date")
                    .HasColumnName("modifiedon");

                entity.Property(e => e.Newvisit)
                    .HasMaxLength(100)
                    .HasColumnName("newvisit");

                entity.Property(e => e.Patientname)
                    .HasMaxLength(100)
                    .HasColumnName("patientname");

                entity.Property(e => e.Relationship)
                    .HasMaxLength(100)
                    .HasColumnName("relationship");

                entity.Property(e => e.Uhid)
                    .HasMaxLength(100)
                    .HasColumnName("UHID");
            });

            modelBuilder.Entity<TblPatientcheckinrestration>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Patientcheckinrestration");

                entity.Property(e => e.Address).HasMaxLength(500);

                entity.Property(e => e.Address1).HasMaxLength(500);

                entity.Property(e => e.Age).HasMaxLength(10);

                entity.Property(e => e.Age1).HasMaxLength(10);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.DateofBirth).HasMaxLength(10);

                entity.Property(e => e.DateofBirth1).HasMaxLength(50);

                entity.Property(e => e.Datetime1).HasMaxLength(100);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Employee).HasMaxLength(100);

                entity.Property(e => e.Empty1)
                    .HasMaxLength(100)
                    .HasColumnName("empty1");

                entity.Property(e => e.Empty2)
                    .HasMaxLength(100)
                    .HasColumnName("empty2");

                entity.Property(e => e.Followupolidvisit).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Gender1).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Ipno)
                    .HasMaxLength(100)
                    .HasColumnName("IPno");

                entity.Property(e => e.Ipnou)
                    .HasMaxLength(100)
                    .HasColumnName("IPnou");

                entity.Property(e => e.Mobilenumber).HasMaxLength(12);

                entity.Property(e => e.Mobilenumber1).HasMaxLength(12);

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Newpatientvisit).HasMaxLength(100);

                entity.Property(e => e.PatientName).HasMaxLength(10);

                entity.Property(e => e.Pensioner).HasMaxLength(100);

                entity.Property(e => e.Relationship).HasMaxLength(100);

                entity.Property(e => e.Services).HasMaxLength(200);

                entity.Property(e => e.Uhid)
                    .HasMaxLength(100)
                    .HasColumnName("UHID");
            });

            modelBuilder.Entity<TblPrimarydoctorchange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Primarydoctorchange");

                entity.Property(e => e.Admissionno).HasMaxLength(100);

                entity.Property(e => e.Age).HasMaxLength(10);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Gender).HasMaxLength(50);

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Ipno).HasMaxLength(100);

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.PatientName).HasMaxLength(100);

                entity.Property(e => e.PrimaryDoctor).HasMaxLength(100);

                entity.Property(e => e.Specialization).HasMaxLength(100);

                entity.Property(e => e.Ward).HasMaxLength(100);
            });

            modelBuilder.Entity<TblRegsterationpage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Regsterationpage");

                entity.Property(e => e.Addres).HasMaxLength(600);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon)
                    .HasMaxLength(100)
                    .HasColumnName("createdon");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedon");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name");

                entity.Property(e => e.Phonenumber)
                    .HasMaxLength(100)
                    .HasColumnName("phonenumber");
            });

            modelBuilder.Entity<TblSampleCollection>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_Sample_Collection");

                entity.Property(e => e.Age).HasMaxLength(10);

                entity.Property(e => e.Createdby).HasMaxLength(100);

                entity.Property(e => e.Createdip).HasMaxLength(100);

                entity.Property(e => e.DateTime1).HasMaxLength(100);

                entity.Property(e => e.DonorName).HasMaxLength(100);

                entity.Property(e => e.DonorNo).HasMaxLength(100);

                entity.Property(e => e.DonorType).HasMaxLength(100);

                entity.Property(e => e.Gender).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Modifiedby).HasMaxLength(100);

                entity.Property(e => e.Modifiedip).HasMaxLength(100);

                entity.Property(e => e.Remark).HasMaxLength(100);

                entity.Property(e => e.SampleNo).HasMaxLength(100);

                entity.Property(e => e.TypeofPheresis).HasMaxLength(100);
            });

            modelBuilder.Entity<TblSplittingbag>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_splittingbag");

                entity.Property(e => e.Bagno).HasMaxLength(100);

                entity.Property(e => e.Collecteddate).HasMaxLength(100);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Expirydate).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Quantity).HasMaxLength(100);

                entity.Property(e => e.Splitno).HasMaxLength(100);
            });

            modelBuilder.Entity<TblSplittingcomponent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_splittingcomponent");

                entity.Property(e => e.Bagno).HasMaxLength(100);

                entity.Property(e => e.Bagtype).HasMaxLength(100);

                entity.Property(e => e.Collecteddate).HasMaxLength(100);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Expirydate).HasMaxLength(100);

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Quantity).HasMaxLength(100);
            });

            modelBuilder.Entity<TblUhidcreation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_UHIDcreation");

                entity.Property(e => e.Address1).HasMaxLength(1000);

                entity.Property(e => e.Address2).HasMaxLength(1000);

                entity.Property(e => e.Address3).HasMaxLength(1000);

                entity.Property(e => e.Age).HasMaxLength(100);

                entity.Property(e => e.BloodGroup).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(100);

                entity.Property(e => e.City2).HasMaxLength(100);

                entity.Property(e => e.City3).HasMaxLength(100);

                entity.Property(e => e.Country).HasMaxLength(100);

                entity.Property(e => e.Country2).HasMaxLength(100);

                entity.Property(e => e.Country3).HasMaxLength(100);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Dob).HasMaxLength(300);

                entity.Property(e => e.Doorno).HasMaxLength(500);

                entity.Property(e => e.Doorno1)
                    .HasMaxLength(500)
                    .HasColumnName("doorno1");

                entity.Property(e => e.Education).HasMaxLength(200);

                entity.Property(e => e.Emailid).HasMaxLength(100);

                entity.Property(e => e.Emailid1).HasMaxLength(100);

                entity.Property(e => e.Emailid2).HasMaxLength(100);

                entity.Property(e => e.Employee)
                    .HasMaxLength(500)
                    .HasColumnName("employee");

                entity.Property(e => e.Esicpensioneer)
                    .HasMaxLength(100)
                    .HasColumnName("esicpensioneer");

                entity.Property(e => e.Esisemployee)
                    .HasMaxLength(500)
                    .HasColumnName("esisemployee");

                entity.Property(e => e.Externalreferral).HasMaxLength(300);

                entity.Property(e => e.FatherName).HasMaxLength(500);

                entity.Property(e => e.FirstName).HasMaxLength(500);

                entity.Property(e => e.Gender).HasMaxLength(20);

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .HasColumnName("ID");

                entity.Property(e => e.Identificationmarks2).HasMaxLength(500);

                entity.Property(e => e.Identifictionmarks1).HasMaxLength(1000);

                entity.Property(e => e.Internalreferral).HasMaxLength(300);

                entity.Property(e => e.Ipno)
                    .HasMaxLength(100)
                    .HasColumnName("ipno");

                entity.Property(e => e.Ipnou)
                    .HasMaxLength(100)
                    .HasColumnName("ipnou");

                entity.Property(e => e.LastName).HasMaxLength(500);

                entity.Property(e => e.MartialStatus).HasMaxLength(200);

                entity.Property(e => e.MiddleName).HasMaxLength(500);

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.MotherName).HasMaxLength(200);

                entity.Property(e => e.Nationality).HasMaxLength(200);

                entity.Property(e => e.Nearby).HasMaxLength(500);

                entity.Property(e => e.Nearby1).HasMaxLength(500);

                entity.Property(e => e.Nearby2).HasMaxLength(500);

                entity.Property(e => e.Occupation).HasMaxLength(300);

                entity.Property(e => e.Phoneno).HasMaxLength(100);

                entity.Property(e => e.Phoneno1).HasColumnType("int(11)");

                entity.Property(e => e.Phoneno2).HasColumnType("int(11)");

                entity.Property(e => e.Pincodecode3).HasMaxLength(50);

                entity.Property(e => e.Pinzipcode).HasMaxLength(50);

                entity.Property(e => e.Pinzipcode2).HasMaxLength(50);

                entity.Property(e => e.ReferredDoctor).HasMaxLength(500);

                entity.Property(e => e.Relationtopatient).HasMaxLength(500);

                entity.Property(e => e.Religion).HasMaxLength(150);

                entity.Property(e => e.SpouseName).HasMaxLength(500);

                entity.Property(e => e.State2).HasMaxLength(100);

                entity.Property(e => e.State3).HasMaxLength(100);

                entity.Property(e => e.States1).HasMaxLength(100);

                entity.Property(e => e.Tittle).HasMaxLength(100);

                entity.Property(e => e.Txtbox)
                    .HasMaxLength(500)
                    .HasColumnName("txtbox");

                entity.Property(e => e.Uhid)
                    .HasMaxLength(100)
                    .HasColumnName("UHID");
            });

            modelBuilder.Entity<TblUpdateBedStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("tbl_UpdateBedStatus");

                entity.Property(e => e.Bedname).HasMaxLength(100);

                entity.Property(e => e.Changetostatus).HasMaxLength(200);

                entity.Property(e => e.Createdby)
                    .HasMaxLength(100)
                    .HasColumnName("createdby");

                entity.Property(e => e.Createdip)
                    .HasMaxLength(100)
                    .HasColumnName("createdip");

                entity.Property(e => e.Createdon).HasColumnName("createdon");

                entity.Property(e => e.Currentstatus).HasMaxLength(200);

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Informtoconsultantdoctor).HasMaxLength(100);

                entity.Property(e => e.Modifiedby)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedby");

                entity.Property(e => e.Modifiedip)
                    .HasMaxLength(100)
                    .HasColumnName("modifiedip");

                entity.Property(e => e.Modifiedon).HasColumnName("modifiedon");

                entity.Property(e => e.Patientname).HasMaxLength(100);

                entity.Property(e => e.Statusonarrivalremarks).HasMaxLength(500);

                entity.Property(e => e.Unitname).HasMaxLength(100);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
