using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblBloodRequestView
    {
        public int? Id { get; set; }
        public string PatientName { get; set; }
        public string Gender { get; set; }
        public string ReqFromDate { get; set; }
        public string ReqTodate { get; set; }
        public string OrderNo { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
    }
}
