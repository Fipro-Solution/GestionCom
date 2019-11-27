using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementProjet.Models
{
    public class Vehicule
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Libelle { get; set; }

        [Required]
        public int Code { get; set; }

        public bool? Actif { get; set; }

        [Required]
        public string immatricule { get; set; }

        public Etat Etat { get; set; }

        [Display(Name ="Fourn.")]
        public string Fourn { get; set; }

        [Required]
        [Display(Name = "Modéle")]
        public string Modele { get; set; }

        [Required]
        public string Marque { get; set; }

        [Required]
        [Display(Name = "Catégorie")]
        public string Categorie { get; set; }

        public string Couleur { get; set; }

        [Display(Name = "Date PMC")]
        [DataType(DataType.Date)]
        public DateTime? DatePMC { get; set; }

        [Display(Name = "Mant Acqui")]
        public decimal? MantAcqui { get; set; }

        [Display(Name = "Date Acqui")]
        [DataType(DataType.Date)]
        public DateTime? DateAcqui { get; set; }

        [Display(Name = "Date FinG")]
        [DataType(DataType.Date)]
        public DateTime? DateFinG { get; set; }

        [Display(Name = "Nº Chassis")]
        public string Nchassis { get; set; }

        [Display(Name = "Nº Moteur")]
        public string NMoteur { get; set; }

        [Display(Name = "Ind Kilomerique")]
        public int? IndKilimetre { get; set; }

        [Display(Name = "Cylindrée")]
        public int? Cylindree { get; set; }

        [Display(Name = "Poids Vide")]
        public float? PoidsVide { get; set; }

        [Display(Name = "Poids Utile")]
        public float? PoidsUtile { get; set; }

        public Energie Energie { get; set; }

        [Display(Name = "Puissance")]
        public string puissance { get; set; }

        public string Debout { get; set; }

        public string Assise { get; set; }

        [Display(Name = "Théorique %")]
        public decimal? theorique { get; set; }

        [Display(Name = "Pratique %")]
        public decimal? Pratique { get; set; }

        [Display(Name = "AV G")]
        public string AVG { get; set; }

        [Display(Name = "AV D")]
        public string AVD { get; set; }

        [Display(Name = "AR G")]
        public string ARG { get; set; }

        [Display(Name = "AR D")]
        public string ARD { get; set; }

        public string Secour { get; set; }

        public decimal? Restant { get; set; }

        public int? Amortis { get; set; }

        public string Accessoire { get; set; }

        public decimal? Taxe { get; set; }

        public bool? climatise { get; set; }

        [Display(Name = "Fermeture Centrale")]
        public bool? FermetureCentrale { get; set; }

        public bool? Alarme { get; set; }

        public bool? Saloncuir { get; set; }

        [Display(Name = "Demarrage Code")]
        public bool? DemarrageCode { get; set; }

        [Display(Name = "Demarrage à distance")]
        public bool? Demarrageadistance { get; set; }

        public bool? Abs { get; set; }

        public bool? Radio { get; set; }

        [Display(Name = "Radio CD")]
        public bool? RadioCD { get; set; }
        [Display(Name = "Jante Allu")]
        public bool? JanteAllu { get; set; }

        public bool? Airbag { get; set; }

        [Display(Name = "Commande à distance")]
        public bool? Commandeadistance { get; set; }

        [Display(Name = "Direction Assisté")]
        public bool? DirectionAssiste { get; set; }

        [Display(Name = "Siege Pilote")]
        public bool? SiegePilote { get; set; }
        [StringLength(1000)]
        [DataType(DataType.MultilineText)]
        public string Observation { get; set; }

        public bool? Vendue { get; set; }

        public virtual ICollection<OrdreMission> OrdreMissions { get; set; }
    }
}
