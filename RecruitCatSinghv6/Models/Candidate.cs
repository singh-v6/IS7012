using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitCatSinghv6.Models
{
    public class Candidate
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        [StringLength(50, MinimumLength = 2)]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        [StringLength(50, MinimumLength = 2)]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Target Salary is Required")]
        [Range(5000.0, 1000000)]
        [DisplayName("Target Salary")]
        public double TargetSalary { get; set; }

        [DataType (DataType.Date)]
        [DisplayName("Optional Start Date")]
        public DateTime OptionalStartDate { get; set; }

        [Required(ErrorMessage = "Minimum 1 Skill required")]
        [StringLength(100, MinimumLength = 2)]
        public string Skills { get; set; }


        [StringLength(10, MinimumLength = 10)]
        [DisplayName("Contact Info")]
        public string ContactInfo { get; set; }

        [ForeignKey("CompanyID")]
        public Company? Company { get; set; }
        public int? CompanyID { get; set; }

        [ForeignKey("JobID")]
        [DisplayName("Job Title")]
        public JobTitle? JobTitle { get; set; }
        public int? JobID { get; set; }

        [ForeignKey("IndustryID")]
        public Industry? Industry { get; set; }
        public int? IndustryID { get; set; }


    }
}
