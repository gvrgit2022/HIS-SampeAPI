using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblBedsideprocerdureorder
    {
        public int? Id { get; set; }
        public string Admissionno { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Orderno { get; set; }
        public DateTime? Orderdatetime { get; set; }
        public string Ipnumber { get; set; }
        public string Unithead { get; set; }
        public DateTime? Operator { get; set; }
        public string Doctorname { get; set; }
        public string Bed { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
    }
}
