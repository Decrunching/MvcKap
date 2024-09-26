using System.ComponentModel.DataAnnotations;

namespace MvcKap.Models
{
    public class Patient
    {
        public int Id { get; set; }
        public required string Species { get; set; }
        [Display(Name = "Age (years)")]
        public required int AgeYears { get; set; }
        [Display(Name = "Age (months)")]
        public int AgeMonths { get; set; }
        [Display(Name = "Actual body weight (kg)")]
        public required double BodyWeight { get; set; }
        [Display(Name = "Lean body weight (kg)")]
        public double LeanBodyWeight { get; set; }
        [Display(Name = "Body Condition Score (1-9)")]
        public int Bcs { get; set; }
        [Display(Name = "Respiratory rate (breaths/minute)")]
        public int RespRate { get; set; }
        [Display(Name = "Heart rate (beats/minute)")]
        public int HeartRate { get; set; }
        [Display(Name = "Systolic blood pressure (mmHg)")]
        public int BpSystolic { get; set; }
        [Display(Name = "Mean blood pressure (mmHg)")]
        public int BpMean { get; set; }
        [Display(Name = "Diastolic blood pressure (mmHg)")]
        public int BpDiastolic { get; set; }
    }
}