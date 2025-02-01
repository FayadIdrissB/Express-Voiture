using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Express_Voiture.Data;
using Express_Voiture.Models;
using Microsoft.AspNetCore.Authorization;

namespace Express_Voiture.Pages.Admin.Voitures
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly Express_Voiture.Data.DataContext _context;

        public CreateModel(Express_Voiture.Data.DataContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Voiture Voiture { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Voitures.Add(Voiture);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
