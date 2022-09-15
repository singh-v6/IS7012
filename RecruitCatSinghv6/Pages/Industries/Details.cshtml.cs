﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatSinghv6.Data;
using RecruitCatSinghv6.Models;

namespace RecruitCatSinghv6.Pages.Industries
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatSinghv6.Data.RecruitCatSinghv6Context _context;

        public DetailsModel(RecruitCatSinghv6.Data.RecruitCatSinghv6Context context)
        {
            _context = context;
        }

      public Industry Industry { get; set; } = default!; 

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Industry == null)
            {
                return NotFound();
            }

            var industry = await _context.Industry.FirstOrDefaultAsync(m => m.Id == id);
            if (industry == null)
            {
                return NotFound();
            }
            else 
            {
                Industry = industry;
            }
            return Page();
        }
    }
}
