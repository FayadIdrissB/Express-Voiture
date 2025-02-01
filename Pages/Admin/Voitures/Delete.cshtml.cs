using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Express_Voiture.Data;
using Express_Voiture.Models;
using Microsoft.AspNetCore.Authorization;

namespace Express_Voiture.Pages.Admin.Voitures
{
    [Authorize]
    public class DeleteModel : PageModel
    {
        private readonly Express_Voiture.Data.DataContext _context;

        public DeleteModel(Express_Voiture.Data.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Voiture Voiture { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Voitures == null)
            {
                return NotFound();
            }

            var voiture = await _context.Voitures.FirstOrDefaultAsync(m => m.VoitureID == id);

            if (voiture == null)
            {
                return NotFound();
            }
            else 
            {
                Voiture = voiture;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Voitures == null)
            {
                return NotFound();
            }
            var voiture = await _context.Voitures.FindAsync(id);

            if (voiture != null)
            {
                Voiture = voiture;
                _context.Voitures.Remove(Voiture);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
