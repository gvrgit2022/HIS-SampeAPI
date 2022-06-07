using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblEsisuser
    {
        public int? Id { get; set; }
        public string Employeenumber { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Iscore { get; set; }
        public string Company { get; set; }
        public string Designation { get; set; }
        public string Emptype { get; set; }
        public string Location { get; set; }
        public string Locationtype { get; set; }
        public string Locationcode { get; set; }
        public string Emailid { get; set; }
        public string Username { get; set; }
        public string Password1 { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
    }
}
