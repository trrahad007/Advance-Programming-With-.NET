using System.ComponentModel.DataAnnotations;

namespace ElectricityBillComplaint.Models
{
    public class Bill
    {
        [Required(ErrorMessage = "Please Provide Customer's Full name")]
        [StringLength(60,ErrorMessage ="Customer's Full name can't exceed 60 characterts")]
        public string FullName {  get; set; }
        [Required]
        [EmailAddress]
        public string Email {  get; set; }
        [Required(ErrorMessage = "Please Provide Comaplaint Description")]
        [StringLength(200, ErrorMessage = "Complaint description can't exceed 200 characterts")]
        public string Description {  get; set; }
        [Required]
        [Range(100,500000)]
        public int Amount { get; set; }
        [Required(ErrorMessage = "Please Provide Meter readrers name")]
        [StringLength(60, ErrorMessage = "Customer's Full name can't exceed 60 characterts")]
        public string MeterName {  get; set; }

    }
}
