using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblPatientcasesheet
    {
        public string Uhid { get; set; }
        public string Ipno { get; set; }
        public string Patientname { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public int? Checkinno { get; set; }
        public DateTime? Checindatetime { get; set; }
        public string Relationship { get; set; }
        public string Newvisit { get; set; }
        public string Followup { get; set; }
        public string Liveliststatus { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
        public int Id { get; set; }
    }
}
