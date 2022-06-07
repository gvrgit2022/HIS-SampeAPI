using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblBloodScreening
    {
        public int? Id { get; set; }
        public string SampleNo { get; set; }
        public string BagNo { get; set; }
        public DateTime? DateTime { get; set; }
        public string VerifiedBy { get; set; }
        public string DonorName { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string Status { get; set; }
        public string ScreeningType { get; set; }
        public string DonorType { get; set; }
        public string TypeofPheresis { get; set; }
        public string Therapeutic { get; set; }
        public string NoneTherapeutic { get; set; }
        public string DateofDonation { get; set; }
        public string DocotorName { get; set; }
        public string Hb { get; set; }
        public string Weight { get; set; }
        public string Remarks { get; set; }
        public string Remarks1 { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
    }
}
