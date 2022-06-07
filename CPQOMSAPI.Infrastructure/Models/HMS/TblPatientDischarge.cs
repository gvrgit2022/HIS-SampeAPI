using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblPatientDischarge
    {
        public string AdmissionNo { get; set; }
        public string Ipno { get; set; }
        public string Datetime { get; set; }
        public string PatientName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Bed { get; set; }
        public string RequestType { get; set; }
        public string DischargeReason { get; set; }
        public string DischargeStatus { get; set; }
        public string UnitedHead { get; set; }
        public string OrderNo { get; set; }
        public string DateTime1 { get; set; }
        public string Operator { get; set; }
        public string Remarks { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
        public int Id { get; set; }
    }
}
