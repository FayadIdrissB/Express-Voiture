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
    public class IndexModel : PageModel
    {
        private readonly Express_Voiture.Data.DataContext _context;

        public IndexModel(Express_Voiture.Data.DataContext context)
        {
            _context = context;
        }

        public IList<Voiture> Voiture { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Voitures != null)
            {
                Voiture = await _context.Voitures.ToListAsync();
            }
        }
    }
}
