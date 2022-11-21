using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sreerastu_proj.Models
{
    public partial class TblVendorRegistration
    {
        public int VendorId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string VendorUserName { get; set; }
        public string VendorPassword { get; set; }
        public string VendorBusinessName { get; set; }
        public int? VendorCategoryId { get; set; }
        public DateTime? BusinessStartedDate { get; set; }
        public int? BusinessExperience { get; set; }
        public string ContactNumber { get; set; }
        public string AlternateContactNumber { get; set; }
        public string ContactPerson { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Location { get; set; }
        public DateTime? BusinessRegistrationDate { get; set; }
        public int? StatusId { get; set; }
        public int? SubscriptionTypeId { get; set; }
        public DateTime? SubscriptionExpiryDate { get; set; }
        public DateTime? VendorRegistrationDate { get; set; }
        public string Idproof { get; set; }
        public string AddressProof { get; set; }
        public string SampleWorks { get; set; }
        public string BusinessLogo { get; set; }
        public int? VerifiedBy { get; set; }
        public int? ApprovedBy { get; set; }
        public DateTime? VerifiedDate { get; set; }
        public DateTime? ApprovedDate { get; set; }

        public virtual TblEmployee ApprovedByNavigation { get; set; }
        public virtual TblVendorStatus Status { get; set; }
        public virtual TblSubscriptionType SubscriptionType { get; set; }
        public virtual TblVendorCategory VendorCategory { get; set; }
        public virtual TblEmployee VerifiedByNavigation { get; set; }
    }
}
