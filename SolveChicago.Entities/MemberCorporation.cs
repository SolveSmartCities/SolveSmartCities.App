//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SolveChicago.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class MemberCorporation
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int CorporationId { get; set; }
        public System.DateTime Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }
        public string ReasonForLeaving { get; set; }
        public Nullable<decimal> Pay { get; set; }
        public Nullable<int> NonprofitId { get; set; }
        public Nullable<bool> IsMemberConfirmed { get; set; }
    
        public virtual Corporation Corporation { get; set; }
        public virtual Member Member { get; set; }
        public virtual Nonprofit Nonprofit { get; set; }
    }
}
