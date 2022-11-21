using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sreerastu_proj.Models
{
    public partial class TblSubscriptionType
    {
        public TblSubscriptionType()
        {
            TblVendorRegistration = new HashSet<TblVendorRegistration>();
        }

        public int SubscriptionTypeId { get; set; }
        [Required(ErrorMessage = "Please Required This Field")]
        [StringLength(100, MinimumLength = 5)]
        public string SubscriptionType { get; set; }

        [Required(ErrorMessage = "Please Enter Amount")]
        public int? Amount { get; set; }

        public virtual ICollection<TblVendorRegistration> TblVendorRegistration { get; set; }
    }
}
