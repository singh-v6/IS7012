using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitCatSinghv6.Models
{
    public class Company
    {
        public int Id { get; set; }

        [StringLength(100, MinimumLength = 2)]
        [DisplayName("Company Name")]
        public string CompanyName { get; set; }

        [Required(ErrorMessage = "Position is a required field")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Min Salary is Required")]
        [Range(5000.0, 1000000)]
        [DisplayName("Min Salary")]
        public Double MinSal { get; set; }

        [Required(ErrorMessage = "Max Salary is Required")]
        [Range(5000.0, 1000000)]
        [DisplayName("Max Salary")]
        public double MaxSal { get; set; }

        [DisplayName("Optional Start Date")]
        [DataType(DataType.Date)]
        public DateTime OptionalStartDate { get; set; }

        [Required(ErrorMessage = "Location is Required")]
        [StringLength(100, MinimumLength = 2)]
        public string Location { get; set; }
        public List<Candidate>? Candidate { get; set; }
        [ForeignKey("IndustryID")] 
        public Industry? Industry { get; set; }
        public int? IndustryID { get; set; }

    }
}
