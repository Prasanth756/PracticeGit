using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sreerastu_proj.Models
{
    public partial class TblCustomerRegistration
    {
        public int CustomerId { get; set; }
        public string CustomerFname { get; set; }
        public string CustomerLname { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public string CustomerUserName { get; set; }
        public string CustomerPassword { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Location { get; set; }
        public string Address { get; set; }
    }
}
