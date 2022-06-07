using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblHealthPassbook
    {
        public int? Id { get; set; }
        public string Uhid { get; set; }
        public string Ipno { get; set; }
        public DateTime? Datetime { get; set; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Gender { get; set; }
        public string Dob { get; set; }
        public string Address { get; set; }
        public string Relationship { get; set; }
        public string Name1 { get; set; }
        public string Age1 { get; set; }
        public string Gender1 { get; set; }
        public string Dob1 { get; set; }
        public string Address2 { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
    }
}
