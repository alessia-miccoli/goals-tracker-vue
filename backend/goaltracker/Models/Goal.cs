namespace goaltracker.Models
{
    public class Goal
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public bool Done { get; set; }
        public float Weight { get; set; }
        public bool NumericGoal { get; set; }
        public float TargetValue { get; set; }
        public float CurrentValue { get; set; }
    }
}