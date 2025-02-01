using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Express_Voiture.Data;
using Express_Voiture.Models;

namespace Express_Voiture.Pages.Admin.Voitures
{
    public class DetailsModel : PageModel
    {
        private readonly Express_Voiture.Data.DataContext _context;

        public DetailsModel(Express_Voiture.Data.DataContext context)
        {
            _context = context;
        }

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
    }
}
