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
    
    public partial class Case
    {
        public Case()
        {
            this.Answers = new HashSet<Answer>();
            this.CaseComments = new HashSet<CaseComment>();
            this.CaseImages = new HashSet<CaseImage>();
            this.Notifications = new HashSet<Notification>();
        }
    
        public int CaseCode { get; set; }
        public int UserCode { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int CategoryCode { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public System.DateTime UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual ICollection<Answer> Answers { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<CaseComment> CaseComments { get; set; }
        public virtual ICollection<CaseImage> CaseImages { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
    }
}
