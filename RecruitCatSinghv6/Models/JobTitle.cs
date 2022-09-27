using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatSinghv6.Models
{
    public class JobTitle
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title is Required")]
        [StringLength(50, MinimumLength = 2)] 
        public string Title { get; set; }

        [Required(ErrorMessage = "Min Salary is Required")]
        [Range(5000.0, 1000000)]
        [DisplayName("Min Salary")]
        public Double MinSalary { get; set; }

        [Required(ErrorMessage = "Max Salary is Required")]
        [Range(5000.0, 1000000)]
        [DisplayName("Max Salary")]
        public Double MaxSalary { get; set; }

        [DisplayName("Stock option")]
        public Double? Stockoption { get; set; }

        [DisplayName("Year Experirnce")]
        public Double? Yearsexp { get; set; }
        public List<Candidate>? Candidates { get; set; }

    }
}
