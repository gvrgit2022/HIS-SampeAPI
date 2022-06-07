using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblNurse
    {
        public string AdmissionNo { get; set; }
        public string Ipno { get; set; }
        public string PatientName { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string Bed { get; set; }
        public string Ward { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public string Operator { get; set; }
        public string Frequency { get; set; }
        public string Interval1 { get; set; }
        public string Task { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
        public int Id { get; set; }
    }
}
