namespace RecruitCatSinghv6.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public Double MinSal { get; set; }
        public double MaxSal { get; set; }
        public DateTime OptionalStartDate { get; set; }
        public string Location { get; set; }
        public List<Candidate> Candidate { get; set; }
        public Industry Industry { get; set; }

    }
}
