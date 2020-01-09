using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementProjet.Models
{
    public class Agence
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(20)]
        public string libelle { get; set; }

        [Required]
        [StringLength(20)]
        public string proprietaire { get; set; }

        public decimal? capital { get; set; }

        [Required]
        [StringLength(20)]
        [Display(Name ="Matricule Fiscale")]
        public string MatFiscale { get; set; }
        [Required]
        [StringLength(1000)]
        [Display(Name = "Addresse")]
        public string Address { get; set; }
        [Required]
        [Display(Name = "Téléphone")]
        [DataType(DataType.PhoneNumber)]
        public string Tel { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Fax { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string Telecopie { get; set; }

        [Required]
        [Display(Name = "Email Addresse")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Display(Name = "Addresse WebSite")]
        [DataType(DataType.Url)]
        public string AdrsUrl { get; set; }

        [StringLength(20)]
        public string Contact { get; set; }

        [Display(Name = "Téléphone Contact")]
        [DataType(DataType.PhoneNumber)]
        public string TelContact { get; set; }

        [Display(Name = "Gsm Contact")]
        [DataType(DataType.PhoneNumber)]
        public string GsmContact { get; set; }

        [Display(Name = "Gsm Contact")]
        [DataType(DataType.PhoneNumber)]
        public string MatCNSS { get; set; }

        [StringLength(20)]
        public string Smigar { get; set; }

        public string Cnss { get; set; }

        public float? CnssEmployeur { get; set; }

        public float? Fiprolos { get; set; }

        public float? AccidentTravail { get; set; }

        public float? Tfp { get; set; }

    }
}
