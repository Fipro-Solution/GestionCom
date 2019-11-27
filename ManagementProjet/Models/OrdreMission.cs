using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementProjet.Models
{
    public class OrdreMission
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Date Mission")]
        public DateTime DateMission { get; set; }

        [Display(Name ="Nom Véhicule")]
        public int VehiculeId { get; set; }
        public virtual Vehicule Vehicule { get; set; }

        [Display(Name = "Matricule")]
        public string matricule { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Conducteur")]
        public string Conducteur { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name = "Num Permis")]
        public string NumPermis { get; set; }

        [Display(Name = "CIN")]
        public string CIN { get; set; }

        [Required]
        [StringLength(20)]
        public string Destinations { get; set; }

        [Required]
        public int CompteurInit { get; set; }

        [Required]
        public int CompteurFinal { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date Depart")]
        public DateTime DateDepart { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Date Retour")]
        public DateTime DateRetour { get; set; }

        [Required]
        public string LibelleMission1 { get; set; }

        public string LibelleMission2 { get; set; }

        public string LibelleMission3 { get; set; }

        [Required]
        [DataType(DataType.MultilineText)]
        [StringLength(1000)]
        public string DetailsMission { get; set; }

        public float? FraisMission1 { get; set; }

        public float? FraisMission2 { get; set; }

        public float? FraisMission3 { get; set; }
        public float? Total { get; set; }
    }
}
