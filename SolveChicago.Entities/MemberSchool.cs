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
    
    public partial class MemberSchool
    {
        public int MemberId { get; set; }
        public int SchoolId { get; set; }
        public System.DateTime Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }
        public bool IsCurrent { get; set; }
        public string Degree { get; set; }
    
        public virtual School School { get; set; }
        public virtual Member Member { get; set; }
    }
}
