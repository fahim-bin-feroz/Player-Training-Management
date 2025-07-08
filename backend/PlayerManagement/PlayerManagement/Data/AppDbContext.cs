using Microsoft.EntityFrameworkCore;
using PlayerManagement.Models;

namespace PlayerManagement.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>op):base(op)
        {
            
        }

        public virtual DbSet<BloodGroup> BloodGroups { get; set; }

        public virtual DbSet<Player> Players { get; set; }

        public virtual DbSet<PlayerTrainingAssignment> PlayerTrainingAssignments { get; set; }

        public virtual DbSet<Religion> Religions { get; set; }

        public virtual DbSet<SportsType> SportsTypes { get; set; }
        public virtual DbSet<Gender> Genders { get; set; }

        public virtual DbSet<Training> Training { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BloodGroup>(entity =>
            {
                entity.HasKey(e => e.BloodGroupId).HasName("PK__BloodGro__4398C68FDE0DDF3E");

                entity.ToTable("BloodGroup");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Gender>(entity =>
            {
                entity.HasKey(e => e.GenderId).HasName("PK__Gender__4E24E9F788C32ACD");

                entity.ToTable("Gender");

                entity.Property(e => e.GenderName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Player>(entity =>
            {
                entity.HasKey(e => e.PlayerId).HasName("PK__Player__4A4E74C8446FF317");

                entity.ToTable("Player");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.FathersName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.FirstName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.Height).HasColumnType("decimal(18, 0)");
                entity.Property(e => e.ImageUrl)
                    .HasMaxLength(100)
                    .IsUnicode(false);
                entity.Property(e => e.LastEducationalQualification)
                    .HasMaxLength(20)
                    .IsUnicode(false);
                entity.Property(e => e.LastName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.MobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);
                entity.Property(e => e.MothersName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
                entity.Property(e => e.PlayerWeight).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.BloodGroup).WithMany(p => p.Players)
                    .HasForeignKey(d => d.BloodGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Player__BloodGro__300424B4");

                entity.HasOne(d => d.Gender).WithMany(p => p.Players)
                    .HasForeignKey(d => d.GenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Player__GenderId__2E1BDC42");

                entity.HasOne(d => d.Religion).WithMany(p => p.Players)
                    .HasForeignKey(d => d.ReligionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Player__Religion__30F848ED");

                entity.HasOne(d => d.SportsType).WithMany(p => p.Players)
                    .HasForeignKey(d => d.SportsTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Player__SportsTy__2F10007B");
            });

            modelBuilder.Entity<PlayerTrainingAssignment>(entity =>
            {
                entity.HasKey(e => e.PlayerTrainingAssignmentId).HasName("PK__PlayerTr__055FA1881DFFF5DE");

                entity.ToTable("PlayerTrainingAssignment");

                entity.Property(e => e.TrainingDate).HasColumnType("datetime");
                entity.Property(e => e.Venue)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Player).WithMany(p => p.PlayerTrainingAssignments)
                    .HasForeignKey(d => d.PlayerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PlayerTra__Playe__34C8D9D1");

                entity.HasOne(d => d.Training).WithMany(p => p.PlayerTrainingAssignments)
                    .HasForeignKey(d => d.TrainingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__PlayerTra__Train__35BCFE0A");
            });

            modelBuilder.Entity<Religion>(entity =>
            {
                entity.HasKey(e => e.ReligionId).HasName("PK__Religion__D3ADAB6A825E3C0E");

                entity.ToTable("Religion");

                entity.Property(e => e.ReligionName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SportsType>(entity =>
            {
                entity.HasKey(e => e.SportsTypeId).HasName("PK__SportsTy__8F679832FD582307");

                entity.ToTable("SportsType");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Training>(entity =>
            {
                entity.HasKey(e => e.TrainingId).HasName("PK__Training__E8D71D828C6BE2AD");

                entity.Property(e => e.TrainingName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });


            modelBuilder.Entity<Training>().HasData(
                new Training { TrainingId = 1, TrainingName = "Batting" },
                new Training { TrainingId = 2, TrainingName = "Bowling" },
                new Training { TrainingId = 3, TrainingName = "Fielding" },
                new Training { TrainingId = 4, TrainingName = "Tactical" },
                new Training { TrainingId = 5, TrainingName = "Strength" }
            );

            modelBuilder.Entity<BloodGroup>().HasData(
                new BloodGroup { BloodGroupId = 1, GroupName = "A+" },
                new BloodGroup { BloodGroupId = 2, GroupName = "A-" },
                new BloodGroup { BloodGroupId = 3, GroupName = "B+" },
                new BloodGroup { BloodGroupId = 4, GroupName = "B-" }
            );

            modelBuilder.Entity<SportsType>().HasData(
                new SportsType { SportsTypeId = 1, TypeName = "Cricket" },
                new SportsType { SportsTypeId = 2, TypeName = "Football" },
                new SportsType { SportsTypeId = 3, TypeName = "Badminton" },
                new SportsType { SportsTypeId = 4, TypeName = "Swimming" }
            );

            modelBuilder.Entity<Religion>().HasData(
                new Religion { ReligionId = 1, ReligionName = "Islam" },
                new Religion { ReligionId = 2, ReligionName = "Hinduism" },
                new Religion { ReligionId = 3, ReligionName = "Christianism" },
                new Religion { ReligionId = 4, ReligionName = "Buddism" }

            );
            modelBuilder.Entity<Gender>().HasData(
                new Gender { GenderId = 1, GenderName = "Male" },
                new Gender { GenderId = 2, GenderName = "Female" },
                new Gender { GenderId = 3, GenderName = "Other" }
            );

        }
    }
}
