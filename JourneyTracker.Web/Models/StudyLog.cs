namespace JourneyTracker.Web.Models
{
    public class StudyLog
    {
        public int Id { get; set; }
        public DateTime LogDate { get; set; }
        public Decimal HoursSpent { get; set; }
        public string TopicCovered { get; set; }
        public string? Notes { get; set; }

    }
}
