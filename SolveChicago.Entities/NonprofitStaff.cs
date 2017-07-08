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
    
    public partial class NonprofitStaff
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NonprofitStaff()
        {
            this.NonprofitMembers = new HashSet<NonprofitMember>();
        }
    
        public int Id { get; set; }
        public int NonprofitId { get; set; }
        public int CaseManagerId { get; set; }
        public Nullable<int> ProgramId { get; set; }
        public string Role { get; set; }
    
        public virtual CaseManager CaseManager { get; set; }
        public virtual NonprofitProgram NonprofitProgram { get; set; }
        public virtual Nonprofit Nonprofit { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NonprofitMember> NonprofitMembers { get; set; }
    }
}