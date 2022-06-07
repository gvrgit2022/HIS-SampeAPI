using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblBedsideresultentry
    {
        public int? Id { get; set; }
        public string Admissionnumber { get; set; }
        public string Uhid { get; set; }
        public DateTime? Datetime { get; set; }
        public string Patientname { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Ward { get; set; }
        public string Bed { get; set; }
        public string Doctorname { get; set; }
        public string Testname { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
    }
}
