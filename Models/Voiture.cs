
using System;
using System.ComponentModel.DataAnnotations;

namespace Express_Voiture.Models
{
	public class Voiture
	{
		public int VoitureID { get; set; }
        [Display(Name = "Image")]
        public string ImgUrl { get; set; }

        [Display(Name = "Prix (€)")]
        public float Prix { get; set; }

        [Display(Name = "Année")]
        public DateOnly Annee { get; set; }

		public string Marque { get; set; }

        [Display(Name = "Modèle")]
        public string Modele { get; set; }


		public bool Finition { get; set; }
	}
}

