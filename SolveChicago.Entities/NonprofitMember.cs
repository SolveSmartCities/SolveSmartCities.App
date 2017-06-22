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
    
    public partial class NonprofitMember
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NonprofitMember()
        {
            this.NonprofitStaffs = new HashSet<NonprofitStaff>();
        }
    
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int NonprofitId { get; set; }
        public Nullable<int> ProgramId { get; set; }
        public string MemberEnjoyed { get; set; }
        public string MemberStruggled { get; set; }
        public System.DateTime Start { get; set; }
        public Nullable<System.DateTime> End { get; set; }
    
        public virtual Member Member { get; set; }
        public virtual NonprofitProgram NonprofitProgram { get; set; }
        public virtual Nonprofit Nonprofit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NonprofitStaff> NonprofitStaffs { get; set; }
    }
}
