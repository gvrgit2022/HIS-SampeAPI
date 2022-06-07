using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblDrugadministration1
    {
        public string AdmissionNo { get; set; }
        public string Ipno { get; set; }
        public string DateTime1 { get; set; }
        public string PatientName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Bed { get; set; }
        public string Ward { get; set; }
        public string UniteHead { get; set; }
        public string UniteName { get; set; }
        public string Specialization { get; set; }
        public string Operator { get; set; }
        public string Allergies { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
    }
}
