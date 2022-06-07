using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblBloodbagretrun
    {
        public int? Id { get; set; }
        public string BagNo { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string Admissionnummber { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Bednumber { get; set; }
        public string Bloodgroup { get; set; }
        public string Remarks { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
    }
}
