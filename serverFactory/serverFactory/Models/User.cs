//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServerFactory
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.DefaultUser = false;
            this.IsNew = true;
        }
    
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public short Age { get; set; }
        public System.DateTime EmploymentDate { get; set; }
        public string Resume { get; set; }
        public string Password { get; set; }
        public string AvatarLocation { get; set; }
        public int NationalId { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public bool Gender { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public bool DefaultUser { get; set; }
        public bool IsNew { get; set; }
    
        public virtual User User1 { get; set; }
    }
}
