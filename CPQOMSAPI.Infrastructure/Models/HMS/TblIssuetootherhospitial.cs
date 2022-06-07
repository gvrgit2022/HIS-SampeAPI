using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblIssuetootherhospitial
    {
        public string IssueNo { get; set; }
        public string BloodBank { get; set; }
        public string Hospitial { get; set; }
        public DateTime? DateTime1 { get; set; }
        public string RequestedBy { get; set; }
        public string RequestedDate { get; set; }
        public string Priority { get; set; }
        public string IssuedBy { get; set; }
        public string IssuedDate { get; set; }
        public string ReceivedBy { get; set; }
        public string Remark { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
        public int Id { get; set; }
    }
}
