using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RecruitCatSinghv6.Models;

namespace RecruitCatSinghv6.Data
{
    public class RecruitCatSinghv6Context : DbContext
    {
        public RecruitCatSinghv6Context (DbContextOptions<RecruitCatSinghv6Context> options)
            : base(options)
        {
        }

        public DbSet<RecruitCatSinghv6.Models.Candidate> Candidate { get; set; } = default!;

        public DbSet<RecruitCatSinghv6.Models.Company>? Company { get; set; }

        public DbSet<RecruitCatSinghv6.Models.Industry>? Industry { get; set; }

        public DbSet<RecruitCatSinghv6.Models.JobTitle>? JobTitle { get; set; }
    }
}
