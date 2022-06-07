using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblDonorscreening
    {
        public int? Id { get; set; }
        public string DonorScreenNo { get; set; }
        public DateTime? DateTime { get; set; }
        public string DonorNo { get; set; }
        public string DonorName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string Address { get; set; }
        public string MobileNo { get; set; }
        public string PhoneNo { get; set; }
        public string DonorQuestionsnaire { get; set; }
        public string Weight { get; set; }
        public string Bp { get; set; }
        public string Pluse { get; set; }
        public string BloodGroup1 { get; set; }
        public string Hb { get; set; }
        public string Temperature { get; set; }
        public string Cvs { get; set; }
        public string Liver { get; set; }
        public string Spleen { get; set; }
        public string RespiratorySystem { get; set; }
        public string Remark { get; set; }
        public string DonorStatus { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
    }
}
