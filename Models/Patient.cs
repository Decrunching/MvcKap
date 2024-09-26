namespace MvcKap.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public required string Species { get; set; }
        public required int AgeYears { get; set; }
        public int AgeMonths { get; set; }
        public required double BodyWeight { get; set; }
        public double LeanBodyWeight { get; set; }
        public int Bcs { get; set; }
        public int RespRate { get; set; }
        public int HeartRate { get; set; }
        public int BpSystolic { get; set; }
        public int BpMean { get; set; }
        public int BpDiastolic { get; set; }
    }
}