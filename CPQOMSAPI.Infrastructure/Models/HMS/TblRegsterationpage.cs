using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblRegsterationpage
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Addres { get; set; }
        public string Phonenumber { get; set; }
        public string Createdby { get; set; }
        public string Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public string Modifiedon { get; set; }
        public string Modifiedip { get; set; }
        public int Id { get; set; }
    }
}
