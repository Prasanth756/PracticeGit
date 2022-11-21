using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sreerastu_proj.Models
{
    public partial class TblVendorStatus
    {
        public TblVendorStatus()
        {
            TblVendorRegistration = new HashSet<TblVendorRegistration>();
        }

        public int StatusId { get; set; }
        [Required(ErrorMessage = "Please Required This Field")]
        [StringLength(100, MinimumLength = 5)]

        public string Status { get; set; }

        public virtual ICollection<TblVendorRegistration> TblVendorRegistration { get; set; }
    }
}
