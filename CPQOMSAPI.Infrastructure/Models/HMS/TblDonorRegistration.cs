using System;
using System.Collections.Generic;

#nullable disable

namespace SampleAPI.Infrastructure.Models.HMS
{
    public partial class TblDonorRegistration
    {
        public int? Id { get; set; }
        public string DonorNo { get; set; }
        public string AdmissionNo { get; set; }
        public string Uhid { get; set; }
        public string DateofRegistration { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Dateofbirth { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string Education { get; set; }
        public string Occupation { get; set; }
        public string Employee { get; set; }
        public string FoodAllergies { get; set; }
        public string DrugAllergies { get; set; }
        public string KnowAllergies { get; set; }
        public string CampName { get; set; }
        public string CampDate { get; set; }
        public string Address1 { get; set; }
        public string City1 { get; set; }
        public string State1 { get; set; }
        public string Country1 { get; set; }
        public string PinZipcode1 { get; set; }
        public string PhoneNo1 { get; set; }
        public string Mobile1 { get; set; }
        public string Email1 { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string PinZipcode { get; set; }
        public string PhoneNo { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Createdby { get; set; }
        public DateTime? Createdon { get; set; }
        public string Createdip { get; set; }
        public string Modifiedby { get; set; }
        public DateTime? Modifiedon { get; set; }
        public string Modifiedip { get; set; }
    }
}
