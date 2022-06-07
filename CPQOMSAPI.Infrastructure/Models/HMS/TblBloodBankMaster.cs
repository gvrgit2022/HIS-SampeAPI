using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblBloodBankMaster
    {
        public int? Id { get; set; }
        public string Code { get; set; }
        public string Lincenseno { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public string State1 { get; set; }
        public string Country { get; set; }
        public string Pincode { get; set; }
        public string Mobileno { get; set; }
        public string Phoneno { get; set; }
        public string Emailid { get; set; }
        public string Contactperson { get; set; }
        public string Address1 { get; set; }
        public string Blocked { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
    }
}
