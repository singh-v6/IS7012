using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatSinghv6.Models
{
    public class Industry
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Industry Name is required")]
        [StringLength(50, MinimumLength = 2)]
        [DisplayName("Industry Name")]
        public string IndustryName { get; set; }

        [DisplayName("IT Sector")]
        public bool? ITSector { get; set; }

        [Required(ErrorMessage = "Average Salary is Required")]
        [Range(5000.0, 1000000)]
        [DisplayName("Average Salary")]
        public Double AverageSalary { get; set; }

        [Required(ErrorMessage = "Skills field is required")]
        [StringLength(200, MinimumLength = 4)]
        [DisplayName("Required Skills")]
        public string ReqSkills { get; set; }
        public List<Candidate>? Candidates { get; set; }
        public List<Company>? Company { get; set; }


    }
}
