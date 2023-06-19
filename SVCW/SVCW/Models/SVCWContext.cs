﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using Microsoft.EntityFrameworkCore;

namespace SVCW.Models
{
    public partial class SVCWContext : DbContext
    {
        public SVCWContext()
        {
        }

        public SVCWContext(DbContextOptions<SVCWContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Achivement> Achivement { get; set; }
        public virtual DbSet<AchivementUser> AchivementUser { get; set; }
        public virtual DbSet<Activity> Activity { get; set; }
        public virtual DbSet<ActivityResult> ActivityResult { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<BankAccount> BankAccount { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Donation> Donation { get; set; }
        public virtual DbSet<Fanpage> Fanpage { get; set; }
        public virtual DbSet<FollowFanpage> FollowFanpage { get; set; }
        public virtual DbSet<FollowJoinAvtivity> FollowJoinAvtivity { get; set; }
        public virtual DbSet<Like> Like { get; set; }
        public virtual DbSet<Media> Media { get; set; }
        public virtual DbSet<Notification> Notification { get; set; }
        public virtual DbSet<Process> Process { get; set; }
        public virtual DbSet<ProcessType> ProcessType { get; set; }
        public virtual DbSet<Report> Report { get; set; }
        public virtual DbSet<ReportType> ReportType { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Vote> Vote { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
<<<<<<< HEAD
                optionsBuilder.UseSqlServer("Data Source=,1433;Initial Catalog=SVCW;User ID=sa;Password=Yftw-rwup-gheu@11;TrustServerCertificate=true;");
=======
                optionsBuilder.UseSqlServer("Data Source=LAPTOP-8LC85HGU\\SQLEXPRESS;Initial Catalog=SVCW;Persist Security Info=True;User ID=sa;Password=12");
>>>>>>> origin/main
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AchivementUser>(entity =>
            {
                entity.HasKey(e => new { e.AchivementId, e.UserId });

                entity.HasOne(d => d.Achivement)
                    .WithMany(p => p.AchivementUser)
                    .HasForeignKey(d => d.AchivementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AchivementUser_Achivement");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AchivementUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AchivementUser_User");
            });

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.HasOne(d => d.Fanpage)
                    .WithMany(p => p.Activity)
                    .HasForeignKey(d => d.FanpageId)
                    .HasConstraintName("FK_Activity_Fanpage");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Activity)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Activity_User");
            });

            modelBuilder.Entity<ActivityResult>(entity =>
            {
                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.ActivityResult)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ActivityResult_Activity");
            });

            modelBuilder.Entity<BankAccount>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.BankAccount)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BankAccount_User");

                entity.HasMany(d => d.Activity)
                    .WithMany(p => p.BankAccount)
                    .UsingEntity<Dictionary<string, object>>(
                        "BankActivity",
                        l => l.HasOne<Activity>().WithMany().HasForeignKey("ActivityId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_BankActivity_Activity"),
                        r => r.HasOne<BankAccount>().WithMany().HasForeignKey("BankAccountId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_BankActivity_BankAccount"),
                        j =>
                        {
                            j.HasKey("BankAccountId", "ActivityId");

                            j.ToTable("BankActivity");

                            j.IndexerProperty<string>("BankAccountId").HasMaxLength(10).HasColumnName("bankAccountId");

                            j.IndexerProperty<string>("ActivityId").HasMaxLength(10).HasColumnName("activityId");
                        });
            });

            modelBuilder.Entity<Comment>(entity =>
            {
                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_Activity");

                entity.HasOne(d => d.Reply)
                    .WithMany(p => p.InverseReply)
                    .HasForeignKey(d => d.ReplyId)
                    .HasConstraintName("FK_Comment_Comment");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comment)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Comment_User");
            });

            modelBuilder.Entity<Donation>(entity =>
            {
                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.Donation)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Donation_Activity");
            });

            modelBuilder.Entity<Fanpage>(entity =>
            {
                entity.HasOne(d => d.FanpageNavigation)
                    .WithOne(p => p.Fanpage)
                    .HasForeignKey<Fanpage>(d => d.FanpageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Fanpage_User");
            });

            modelBuilder.Entity<FollowFanpage>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.FanpageId });

                entity.HasOne(d => d.Fanpage)
                    .WithMany(p => p.FollowFanpage)
                    .HasForeignKey(d => d.FanpageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FollowFanpage_Fanpage");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FollowFanpage)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FollowFanpage_User");
            });

            modelBuilder.Entity<FollowJoinAvtivity>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ActivityId });

                entity.Property(e => e.IsFollow).IsFixedLength();

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.FollowJoinAvtivity)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FollowJoinAvtivity_Activity");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FollowJoinAvtivity)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FollowJoinAvtivity_User");
            });

            modelBuilder.Entity<Like>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.ActivityId });

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.Like)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Like_Activity");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Like)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Like_User");
            });

            modelBuilder.Entity<Media>(entity =>
            {
                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.Media)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Media_Activity");

                entity.HasOne(d => d.Process)
                    .WithMany(p => p.Media)
                    .HasForeignKey(d => d.ProcessId)
                    .HasConstraintName("FK_Media_Process");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.Notification)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notification_User");
            });

            modelBuilder.Entity<Process>(entity =>
            {
                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.Process)
                    .HasForeignKey(d => d.ActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Process_Activity");

                entity.HasOne(d => d.ProcessType)
                    .WithMany(p => p.Process)
                    .HasForeignKey(d => d.ProcessTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Process_ProcessType");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.HasOne(d => d.ReportType)
                    .WithMany(p => p.Report)
                    .HasForeignKey(d => d.ReportTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_report_ReportType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Report)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_report_User");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Username, "User")
                    .IsUnique()
                    .HasFilter("([username] IS NOT NULL)");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.User)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Role");
            });

            modelBuilder.Entity<Vote>(entity =>
            {
                entity.HasOne(d => d.User)
                    .WithMany(p => p.VoteUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vote_User");

                entity.HasOne(d => d.UserVote)
                    .WithMany(p => p.VoteUserVote)
                    .HasForeignKey(d => d.UserVoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vote_User1");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}