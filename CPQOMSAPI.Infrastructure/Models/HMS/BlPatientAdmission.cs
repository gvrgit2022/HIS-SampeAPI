using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class BlPatientAdmission
    {
        public int? Id { get; set; }
        public string Admissionno { get; set; }
        public string Uhid { get; set; }
        public string Admitdatetime { get; set; }
        public string Ipno { get; set; }
        public string Ipnou { get; set; }
        public string Newborn { get; set; }
        public string Title { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public string Martialstatus { get; set; }
        public string Dob { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string Bloodgroup { get; set; }
        public string Religion { get; set; }
        public string Occupation { get; set; }
        public string Education { get; set; }
        public string Nationalid { get; set; }
        public string Fathername { get; set; }
        public string Spousename { get; set; }
        public string Mothersmaidenname { get; set; }
        public string Identificationmark1 { get; set; }
        public string Identificationmark2 { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public int? Pinzipcode { get; set; }
        public int? Phoneno { get; set; }
        public int? Mobileno { get; set; }
        public string Emailid { get; set; }
        public string Admissiontype { get; set; }
        public string Referralsourceofadmission { get; set; }
        public string Estdischargedate { get; set; }
        public string Reasonforadmission { get; set; }
        public string Specialization { get; set; }
        public string Unitname { get; set; }
        public string Visittype { get; set; }
        public string Unithead { get; set; }
        public string Ward { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdby { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifedip { get; set; }
        public string Employee { get; set; }
        public string Pensioner { get; set; }
        public string State { get; set; }
        public string Address { get; set; }
        public string Ismlc { get; set; }
        public string Admitingdoctor { get; set; }
    }
}
