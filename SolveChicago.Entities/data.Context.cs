﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SolveChicagoEntities : DbContext
    {
        public SolveChicagoEntities()
            : base("name=SolveChicagoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<AdminInviteCode> AdminInviteCodes { get; set; }
        public virtual DbSet<AspNetRole> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUser> AspNetUsers { get; set; }
        public virtual DbSet<Communication> Communications { get; set; }
        public virtual DbSet<Corporation> Corporations { get; set; }
        public virtual DbSet<Family> Families { get; set; }
        public virtual DbSet<GovernmentProgram> GovernmentPrograms { get; set; }
        public virtual DbSet<Interest> Interests { get; set; }
        public virtual DbSet<MemberCorporation> MemberCorporations { get; set; }
        public virtual DbSet<MemberEmergencyContact> MemberEmergencyContacts { get; set; }
        public virtual DbSet<MemberGovernmentProgram> MemberGovernmentPrograms { get; set; }
        public virtual DbSet<MemberParent> MemberParents { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<MemberSchool> MemberSchools { get; set; }
        public virtual DbSet<MemberSkill> MemberSkills { get; set; }
        public virtual DbSet<MemberSpous> MemberSpouses { get; set; }
        public virtual DbSet<Outcome> Outcomes { get; set; }
        public virtual DbSet<PhoneNumber> PhoneNumbers { get; set; }
        public virtual DbSet<School> Schools { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<ELMAH_Error> ELMAH_Error { get; set; }
        public virtual DbSet<Nonprofit> Nonprofits { get; set; }
        public virtual DbSet<Referrer> Referrers { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<CaseManager> CaseManagers { get; set; }
        public virtual DbSet<CaseNote> CaseNotes { get; set; }
        public virtual DbSet<NonprofitMember> NonprofitMembers { get; set; }
        public virtual DbSet<MemberMilitary> MemberMilitaries { get; set; }
        public virtual DbSet<MilitaryBranch> MilitaryBranches { get; set; }
    
        public virtual ObjectResult<string> ELMAH_GetErrorsXml(string application, Nullable<int> pageIndex, Nullable<int> pageSize, ObjectParameter totalCount)
        {
            var applicationParameter = application != null ?
                new ObjectParameter("Application", application) :
                new ObjectParameter("Application", typeof(string));
    
            var pageIndexParameter = pageIndex.HasValue ?
                new ObjectParameter("PageIndex", pageIndex) :
                new ObjectParameter("PageIndex", typeof(int));
    
            var pageSizeParameter = pageSize.HasValue ?
                new ObjectParameter("PageSize", pageSize) :
                new ObjectParameter("PageSize", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("ELMAH_GetErrorsXml", applicationParameter, pageIndexParameter, pageSizeParameter, totalCount);
        }
    
        public virtual ObjectResult<string> ELMAH_GetErrorXml(string application, Nullable<System.Guid> errorId)
        {
            var applicationParameter = application != null ?
                new ObjectParameter("Application", application) :
                new ObjectParameter("Application", typeof(string));
    
            var errorIdParameter = errorId.HasValue ?
                new ObjectParameter("ErrorId", errorId) :
                new ObjectParameter("ErrorId", typeof(System.Guid));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("ELMAH_GetErrorXml", applicationParameter, errorIdParameter);
        }
    
        public virtual int ELMAH_LogError(Nullable<System.Guid> errorId, string application, string host, string type, string source, string message, string user, string allXml, Nullable<int> statusCode, Nullable<System.DateTime> timeUtc)
        {
            var errorIdParameter = errorId.HasValue ?
                new ObjectParameter("ErrorId", errorId) :
                new ObjectParameter("ErrorId", typeof(System.Guid));
    
            var applicationParameter = application != null ?
                new ObjectParameter("Application", application) :
                new ObjectParameter("Application", typeof(string));
    
            var hostParameter = host != null ?
                new ObjectParameter("Host", host) :
                new ObjectParameter("Host", typeof(string));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var sourceParameter = source != null ?
                new ObjectParameter("Source", source) :
                new ObjectParameter("Source", typeof(string));
    
            var messageParameter = message != null ?
                new ObjectParameter("Message", message) :
                new ObjectParameter("Message", typeof(string));
    
            var userParameter = user != null ?
                new ObjectParameter("User", user) :
                new ObjectParameter("User", typeof(string));
    
            var allXmlParameter = allXml != null ?
                new ObjectParameter("AllXml", allXml) :
                new ObjectParameter("AllXml", typeof(string));
    
            var statusCodeParameter = statusCode.HasValue ?
                new ObjectParameter("StatusCode", statusCode) :
                new ObjectParameter("StatusCode", typeof(int));
    
            var timeUtcParameter = timeUtc.HasValue ?
                new ObjectParameter("TimeUtc", timeUtc) :
                new ObjectParameter("TimeUtc", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ELMAH_LogError", errorIdParameter, applicationParameter, hostParameter, typeParameter, sourceParameter, messageParameter, userParameter, allXmlParameter, statusCodeParameter, timeUtcParameter);
        }
    }
}
