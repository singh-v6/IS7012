using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatSinghv6.Data;
using RecruitCatSinghv6.Models;

namespace RecruitCatSinghv6.Pages.Candidates
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatSinghv6.Data.RecruitCatSinghv6Context _context;

        public CreateModel(RecruitCatSinghv6.Data.RecruitCatSinghv6Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["CompanyID"] = new SelectList(_context.Company, "Id", "CompanyName");
        ViewData["IndustryID"] = new SelectList(_context.Industry, "Id", "IndustryName");
        ViewData["JobID"] = new SelectList(_context.JobTitle, "Id", "Title");
            return Page();
        }

        [BindProperty]
        public Candidate Candidate { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Candidate.Add(Candidate);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
