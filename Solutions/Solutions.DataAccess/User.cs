//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Solutions.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Block = new HashSet<Block>();
            this.Case = new HashSet<Case>();
            this.Feedback = new HashSet<Feedback>();
            this.Follow = new HashSet<Follow>();
        }
    
        public int UserCode { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int SatisfactoryLevelCode { get; set; }
        public string About { get; set; }
        public int PrivacyCode { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<Block> Block { get; set; }
        public virtual ICollection<Case> Case { get; set; }
        public virtual ICollection<Feedback> Feedback { get; set; }
        public virtual ICollection<Follow> Follow { get; set; }
        public virtual Privacy Privacy { get; set; }
        public virtual SatisfactoryLevel SatisfactoryLevel { get; set; }
    }
}
