using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblBedmaster
    {
        public int? Id { get; set; }
        public string Bedname { get; set; }
        public string Code { get; set; }
        public string Extension { get; set; }
        public string Wardname { get; set; }
        public string Location { get; set; }
        public string Modelno { get; set; }
        public string Room { get; set; }
        public string Serialno { get; set; }
        public string Direction { get; set; }
        public string Status1 { get; set; }
        public string Manufacturer { get; set; }
        public string Remarks { get; set; }
        public string Bedtype { get; set; }
        public string Airconditioner { get; set; }
        public string Microwaveoven { get; set; }
        public string Nebuliser { get; set; }
        public string Refrigerator { get; set; }
        public string Blocked { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
    }
}
