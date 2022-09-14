namespace RecruitCatSinghv6.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double TargetSalary { get; set; }
        public DateTime OptionalStartDate { get; set; }
        public string Skills { get; set; }
        public string ContactInfo { get; set; }


    }
}
