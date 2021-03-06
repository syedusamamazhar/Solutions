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
    
    public partial class Answer
    {
        public Answer()
        {
            this.AnswerComments = new HashSet<AnswerComment>();
            this.Votes = new HashSet<Vote>();
        }
    
        public int AnswerCode { get; set; }
        public int CaseCode { get; set; }
        public int AnswerUserCode { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
    
        public virtual Case Case { get; set; }
        public virtual ICollection<AnswerComment> AnswerComments { get; set; }
        public virtual ICollection<Vote> Votes { get; set; }
    }
}
