using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sreerastu_proj.Models
{
    public partial class TblEmployee
    {
        public TblEmployee()
        {
            TblVendorRegistrationApprovedByNavigation = new HashSet<TblVendorRegistration>();
            TblVendorRegistrationVerifiedByNavigation = new HashSet<TblVendorRegistration>();
        }

        public int EmpId { get; set; }
        public string EmpFname { get; set; }
        public string EmpLname { get; set; }
        public string EmpUserName { get; set; }
        public string EmpPassword { get; set; }
        public DateTime? EmpDob { get; set; }
        public string EmpContactNumber { get; set; }
        public string EmpEmail { get; set; }
        public string EmpRole { get; set; }

        public virtual ICollection<TblVendorRegistration> TblVendorRegistrationApprovedByNavigation { get; set; }
        public virtual ICollection<TblVendorRegistration> TblVendorRegistrationVerifiedByNavigation { get; set; }
    }
}
