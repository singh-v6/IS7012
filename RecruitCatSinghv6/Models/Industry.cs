namespace RecruitCatSinghv6.Models
{
    public class Industry
    {
        public int Id { get; set; }
        public string IndustryName { get; set; }
        public bool? ITSector { get; set; }
        public Double AverageSalary { get; set; }
        public string ReqSkills { get; set; }
        public List<Candidate> Candidates { get; set; }
        public List<Company> Company { get; set; }


    }
}
