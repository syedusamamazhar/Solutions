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
    
    public partial class VoteType
    {
        public VoteType()
        {
            this.Votes = new HashSet<Vote>();
        }
    
        public int VoteTypeCode { get; set; }
        public byte[] Description { get; set; }
    
        public virtual ICollection<Vote> Votes { get; set; }
    }
}
