using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementProjet.Models
{
    public class Personnel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Nom")]
        [MinLength(3)]
        [StringLength(20)]
        public string Nom { get; set; }

        [Required]
        [Display(Name = "Prénom")]
        [MinLength(3)]
        [StringLength(20)]
        public string Prenom { get; set; }

        [Required]
        [Display(Name = "Date Nais")]
        [DataType(DataType.Date)]
        public DateTime DateNais { get; set; }

        [Display(Name = "Lieu Nais")]
        public string LieuNais { get; set; }

        [Display(Name = "Num CI")]
        public string NumCI { get; set; }

        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required]
        [Display(Name = "Tache")]
        [MinLength(3)]
        [StringLength(20)]
        public string Tache { get; set; }

        [Display(Name = "MatCnss")]
        public string MatCnss { get; set; }

        [Display(Name = "Commentaire")]
        public string Comment { get; set; }

        public Contrat Contrat { get; set; }

        [Display(Name = "Date Debut Contrat")]
        [DataType(DataType.Date)]
        public DateTime DebutC { get; set; }

        [Display(Name = "Date Fin Contrat")]
        [DataType(DataType.Date)]
        public DateTime FinC { get; set; }

        [Required]
        [MinLength(3)]
        [StringLength(20)]
        public string Grade { get; set; }

        [Required]
        [MinLength(3)]
        [StringLength(20)]
        public string Echelle { get; set; }

        [Required]
        [MinLength(3)]
        [StringLength(20)]
        public string Echelon { get; set; }


        [DataType("decimal(16 ,3")]
        public Decimal PrimeCA { get; set; }

        [Required]
        [DataType("decimal(16 ,3")]
        public Decimal Salaire { get; set; }

        [Display(Name = "Date Sortie")]
        [DataType(DataType.Date)]
        public DateTime DateSortie { get; set; }

    }
}
