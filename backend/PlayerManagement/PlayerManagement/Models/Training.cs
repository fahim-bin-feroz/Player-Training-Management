namespace PlayerManagement.Models
{
    public class Training
    {
        public int TrainingId { get; set; }

        public string TrainingName { get; set; } = null!;

        public virtual ICollection<PlayerTrainingAssignment> PlayerTrainingAssignments { get; set; } = new List<PlayerTrainingAssignment>();
    }
}