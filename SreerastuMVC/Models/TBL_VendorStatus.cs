//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SreerastuMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_VendorStatus
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_VendorStatus()
        {
            this.TBL_VendorRegistration = new HashSet<TBL_VendorRegistration>();
        }
    
        public int StatusID { get; set; }
        public string Status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_VendorRegistration> TBL_VendorRegistration { get; set; }
    }
}
