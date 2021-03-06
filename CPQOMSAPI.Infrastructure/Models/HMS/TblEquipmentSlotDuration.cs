using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblEquipmentSlotDuration
    {
        public int? Id { get; set; }
        public string ServiceName { get; set; }
        public string Items { get; set; }
        public string Type { get; set; }
        public string ForTime { get; set; }
        public string ToTime { get; set; }
        public string ForEvery { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
    }
}
