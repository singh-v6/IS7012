﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatSinghv6.Data;
using RecruitCatSinghv6.Models;

namespace RecruitCatSinghv6.Pages.Industries
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
            return Page();
        }

        [BindProperty]
        public Industry Industry { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Industry == null || Industry == null)
            {
                return Page();
            }

            _context.Industry.Add(Industry);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
