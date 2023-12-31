using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using FamilyPromiseApp.Data;
using FamilyPromiseApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace FamilyPromiseApp.Pages.Intakes
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly FamilyPromiseApp.Data.FamilyPContext _context;

        public CreateModel(FamilyPromiseApp.Data.FamilyPContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public IntakeModel IntakeModel { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Intake.Add(IntakeModel);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
