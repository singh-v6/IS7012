using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatSinghv6.Data;
using RecruitCatSinghv6.Models;

namespace RecruitCatSinghv6.Pages.Companies
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatSinghv6.Data.RecruitCatSinghv6Context _context;

        public DetailsModel(RecruitCatSinghv6.Data.RecruitCatSinghv6Context context)
        {
            _context = context;
        }

      public Company Company { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Company == null)
            {
                return NotFound();
            }

            var company = await _context.Company.Include(x => x.Candidate).Include(x => x.Industry).FirstOrDefaultAsync(m => m.Id == id);
            if (company == null)
            {
                return NotFound();
            }
            else 
            {
                Company = company;
            }
            return Page();
        }
    }
}
