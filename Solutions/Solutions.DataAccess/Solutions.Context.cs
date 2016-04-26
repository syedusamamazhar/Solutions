﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SolutionsEntities : DbContext
    {
        public SolutionsEntities()
            : base("name=SolutionsEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Answer> Answers { get; set; }
        public DbSet<AnswerComment> AnswerComments { get; set; }
        public DbSet<AnswerRecomment> AnswerRecomments { get; set; }
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Case> Cases { get; set; }
        public DbSet<CaseComment> CaseComments { get; set; }
        public DbSet<CaseImage> CaseImages { get; set; }
        public DbSet<CaseRecomment> CaseRecomments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Feedback> Feedbacks { get; set; }
        public DbSet<Follow> Follows { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<NotificationType> NotificationTypes { get; set; }
        public DbSet<Privacy> Privacies { get; set; }
        public DbSet<SatisfactoryLevel> SatisfactoryLevels { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Vote> Votes { get; set; }
        public DbSet<VoteType> VoteTypes { get; set; }
    }
}
