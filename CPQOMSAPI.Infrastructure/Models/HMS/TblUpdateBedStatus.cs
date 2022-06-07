using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblUpdateBedStatus
    {
        public string Patientname { get; set; }
        public string Bedname { get; set; }
        public string Currentstatus { get; set; }
        public string Changetostatus { get; set; }
        public string Unitname { get; set; }
        public string Informtoconsultantdoctor { get; set; }
        public string Statusonarrivalremarks { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
        public int Id { get; set; }
    }
}
