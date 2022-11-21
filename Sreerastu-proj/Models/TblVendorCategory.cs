using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Sreerastu_proj.Models
{
    public partial class TblVendorCategory
    {
        public TblVendorCategory()
        {
            TblVendorRegistration = new HashSet<TblVendorRegistration>();
        }

        public int VendorCategoryId { get; set; }
        public string VcategoryDescription { get; set; }

        public virtual ICollection<TblVendorRegistration> TblVendorRegistration { get; set; }
    }
}
