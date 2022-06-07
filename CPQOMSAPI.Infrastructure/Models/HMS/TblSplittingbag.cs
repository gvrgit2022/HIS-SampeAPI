using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblSplittingbag
    {
        public string Bagno { get; set; }
        public string Splitno { get; set; }
        public string Quantity { get; set; }
        public string Collecteddate { get; set; }
        public string Expirydate { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
        public int Id { get; set; }
    }
}
