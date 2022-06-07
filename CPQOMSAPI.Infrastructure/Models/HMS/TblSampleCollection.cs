using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblSampleCollection
    {
        public string DonorNo { get; set; }
        public string SampleNo { get; set; }
        public string DateTime1 { get; set; }
        public string DonorName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string DonorType { get; set; }
        public string TypeofPheresis { get; set; }
        public string Remark { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
        public int Id { get; set; }
    }
}
