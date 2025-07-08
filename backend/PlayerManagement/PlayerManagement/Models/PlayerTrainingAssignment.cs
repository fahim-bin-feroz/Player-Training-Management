namespace PlayerManagement.Models
{
    public class PlayerTrainingAssignment
    {
        public int PlayerTrainingAssignmentId { get; set; }

        public int PlayerId { get; set; }

        public int TrainingId { get; set; }

        public DateTime? TrainingDate { get; set; }

        public int Duration { get; set; }

        public string Venue { get; set; } = null!;

        public virtual Player Player { get; set; } = null!;

        public virtual Training Training { get; set; } = null!;
    }
}