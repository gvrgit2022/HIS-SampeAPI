using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblPatientbedTransfer
    {
        public int? Id { get; set; }
        public string AdmissionNo { get; set; }
        public string Uhid { get; set; }
        public string Ipno { get; set; }
        public string PatientName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string OccuipedDateTime { get; set; }
        public string Consultant { get; set; }
        public string AdmittedDateTime { get; set; }
        public string TransferToNewBed { get; set; }
        public string Ward { get; set; }
        public string Bed { get; set; }
        public string Ward1 { get; set; }
        public string Bed1 { get; set; }
        public string BedType { get; set; }
        public string BilledBedType { get; set; }
        public string BedType1 { get; set; }
        public string BilledBedType1 { get; set; }
        public string UnitName { get; set; }
        public string UnitName1 { get; set; }
        public string AdmissionRemarks { get; set; }
        public string TransferRequestRemarks { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
    }
}
