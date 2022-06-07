using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblBedComplement
    {
        public int? Id { get; set; }
        public string Sanctionbed { get; set; }
        public string Commisionbed { get; set; }
        public string Specialisation { get; set; }
        public string CommissionedBedCount { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedby { get; set; }
        public string Modifiedip { get; set; }
    }
}
