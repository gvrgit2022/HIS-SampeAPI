using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblAmbulancerequest
    {
        public int? Id { get; set; }
        public string Requestnumber { get; set; }
        public string Internal { get; set; }
        public string External { get; set; }
        public string Location { get; set; }
        public string Mobilenumber { get; set; }
        public string Uhid { get; set; }
        public string Insurancenumber { get; set; }
        public string Patientname { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Dob { get; set; }
        public string Patientcondition { get; set; }
        public string Bednumber { get; set; }
        public string Address { get; set; }
        public string Destination { get; set; }
        public string Receivedby { get; set; }
        public string Receiveddate { get; set; }
        public string Requireddate { get; set; }
        public string Authorizedby { get; set; }
        public string Remarks { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
    }
}
