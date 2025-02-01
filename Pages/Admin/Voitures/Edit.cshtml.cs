using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Express_Voiture.Data;
using Express_Voiture.Models;
using Microsoft.AspNetCore.Authorization;

namespace Express_Voiture.Pages.Admin.Voitures
{
    [Authorize]
    public class EditModel : PageModel
    {
        private readonly Express_Voiture.Data.DataContext _context;

        public EditModel(Express_Voiture.Data.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Voiture Voiture { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Voitures == null)
            {
                return NotFound();
            }

            var voiture =  await _context.Voitures.FirstOrDefaultAsync(m => m.VoitureID == id);
            if (voiture == null)
            {
                return NotFound();
            }
            Voiture = voiture;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Voiture).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VoitureExists(Voiture.VoitureID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool VoitureExists(int id)
        {
          return _context.Voitures.Any(e => e.VoitureID == id);
        }
    }
}
