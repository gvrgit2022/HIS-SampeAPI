using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblBagExpiryTime
    {
        public int? Id { get; set; }
        public string Bagtype { get; set; }
        public string Component { get; set; }
        public string Storagetemperature { get; set; }
        public string Storagetemperature2 { get; set; }
        public string Epirytime { get; set; }
        public string Expirymonths { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
    }
}
