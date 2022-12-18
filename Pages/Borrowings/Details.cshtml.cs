using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Farkas_Szabolcs_Lab2.Data;
using Farkas_Szabolcs_Lab2.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Farkas_Szabolcs_Lab2.Pages.Borrowings
{
    public class DetailsModel : PageModel
    {
        private readonly Farkas_Szabolcs_Lab2.Data.Farkas_Szabolcs_Lab2Context _context;

        public DetailsModel(Farkas_Szabolcs_Lab2.Data.Farkas_Szabolcs_Lab2Context context)
        {
            _context = context;
        }

      public Borrowing Borrowing { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Borrowing == null)
            {
                return NotFound();
            }

            var borrowing = await _context.Borrowing
                .Include(m=>m.Member)
                .Include(m=>m.Book)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (borrowing == null)
            {
                return NotFound();
            }
            else 
            {
                Borrowing = borrowing;
            
            }
           
            return Page();
        }
    }
}
