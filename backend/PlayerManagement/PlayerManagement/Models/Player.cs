namespace PlayerManagement.Models
{
    public class Player
    {
        public int PlayerId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public DateTime? DateOfBirth { get; set; }

        public string? FathersName { get; set; }

        public string? MothersName { get; set; }

        public string MobileNo { get; set; } = null!;

        public string? ImageUrl { get; set; } = null!;

        public string? ImageName { get; set; } = null!;

        public string? NidNumber { get; set; } = null!;

        public string? Email { get; set; }

        public decimal? Height { get; set; }

        public decimal? PlayerWeight { get; set; }

        public string? LastEducationalQualification { get; set; }

        public int SportsTypeId { get; set; }

        public int BloodGroupId { get; set; }

        public int ReligionId { get; set; }

        public int GenderId { get; set; }
        
        public bool IsDeleted { get; set; }

        public Gender Gender { get; set; } = null!;
        public virtual BloodGroup BloodGroup { get; set; } = null!;

        public virtual ICollection<PlayerTrainingAssignment> PlayerTrainingAssignments { get; set; } = new List<PlayerTrainingAssignment>();

        public virtual Religion Religion { get; set; } = null!;

        public virtual SportsType SportsType { get; set; } = null!;
    }

    public partial class SportsType
    {
        public int SportsTypeId { get; set; }

        public string TypeName { get; set; } = null!;

        public virtual ICollection<Player> Players { get; set; } = new List<Player>();
    }

    public partial class Religion
    {
        public int ReligionId { get; set; }

        public string ReligionName { get; set; } = null!;

        public virtual ICollection<Player> Players { get; set; } = new List<Player>();
    }

    public partial class BloodGroup
    {
        public int BloodGroupId { get; set; }

        public string GroupName { get; set; } = null!;

        public virtual ICollection<Player> Players { get; set; } = new List<Player>();
    }

    public class Gender
    {
        public int GenderId { get; set; }
        public string GenderName { get; set; } = null!;
        public ICollection<Player> Players { get; set; } = new List<Player>();
    }
}
