using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Express_Voiture.Data;
using Express_Voiture.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Express_Voiture.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        DataContext dataContext; 


        public PrivacyModel(ILogger<PrivacyModel> logger, DataContext dataContext)
        {
            _logger = logger;
            this.dataContext = dataContext;
        }

        public void OnGet()
        {
            /*
            var voiture = new Voiture() { ImgUrl = "https://www.google.fr/search?q=voiture+polo&sca_esv=4157d8a3af059079&hl=fr&sxsrf=AHTn8zqeA6iUygkaRgeBy1vK3OPglF274A:1738434836704&source=hp&biw=1470&bih=762&ei=FGmeZ5KkKLqYkdUP1fHvgAw&iflsig=ACkRmUkAAAAAZ553JPGOXPrll2DL3zvRz1ZfchwlTyEv&oq=&gs_lp=EgNpbWciACoCCAAyBxAjGCcY6gIyBxAjGCcY6gIyBxAjGCcY6gIyBxAjGCcY6gIyBxAjGCcY6gIyBxAjGCcY6gIyBxAjGCcY6gIyBxAjGCcY6gIyBxAjGCcY6gIyBxAjGCcY6gJI_QVQAFgAcAF4AJABAJgBAKABAKoBALgBAcgBAIoCC2d3cy13aXotaW1nmAIBoAIHqAIKmAMHkgcBMaAHAA&sclient=img&udm=2#vhid=aKFXmfA5T3mBeM&vssid=mosaic",
                Prix = 11400, Annee = new DateOnly(2025, 2, 1), Marque = "volkswagen", Modele = "Citadine", Finition = false,
            };
            dataContext.Voitures.Add(voiture);
            dataContext.SaveChanges();
            */
        }
    }
}

