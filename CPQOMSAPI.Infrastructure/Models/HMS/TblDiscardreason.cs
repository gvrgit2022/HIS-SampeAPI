using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblDiscardreason
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public string Blocked { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
        public int Id { get; set; }
    }
}
