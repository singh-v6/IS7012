namespace RecruitCatSinghv6.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Double MinSalary { get; set; }
        public Double MaxSalary { get; set; }
        public Double? Stockoption { get; set; }
        public Double? Yearsexp { get; set; }

    }
}
