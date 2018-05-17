//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class UserProfileMaster
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public UserProfileMaster()
        {
            this.UserAddressDetails = new HashSet<UserAddressDetail>();
        }
    
        public long Login_Id { get; set; }
        public string Primary_Email { get; set; }
        public string Password { get; set; }
        public string User_Fname { get; set; }
        public string User_Mname { get; set; }
        public string User_Lname { get; set; }
        public string Secondary_Email { get; set; }
        public string Mobile { get; set; }
        public string Alternate_Mobile { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> User_DOB { get; set; }
        public Nullable<System.DateTime> User_Anniversary { get; set; }
        public bool IsActive { get; set; }
        public int RoleID { get; set; }
        public bool Registration_From_Device { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UserAddressDetail> UserAddressDetails { get; set; }
    }
}