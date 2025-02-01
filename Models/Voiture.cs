
using System;
namespace Express_Voiture.Models
{
	public class Voiture
	{
		public int VoitureID { get; set; }
		public string ImgUrl { get; set; }
		public float Prix { get; set; }
		public DateOnly Annee { get; set; }
		public string Marque { get; set; }
		public string Modele { get; set; }
		public bool Finition { get; set; }
	}
}

