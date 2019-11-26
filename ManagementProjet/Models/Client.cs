using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ManagementProjet.Models
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public string Code { get; set; }

        [Required]
        public string Libelle { get; set; }

        [Display(Name = "Type Clt")]
        public TypeClt TypeClt { get; set; }

        [Required]
        [Display(Name = "Mat Fisc")]
        public string MatFisc { get; set; }

        [Required]
        [Display(Name = "Addresse")]
        public string Address { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Tel { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Fax { get; set; }

        [DataType(DataType.Url)]
        [Display(Name = "Site Web")]
        public string Siteweb { get; set; }

        [Required]
        [Display(Name = "Nom Contact")]
        public string NomContact { get; set; }

        [Required]
        [Display(Name = "Fonc Contact")]
        public string FoncContact { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Tel Contact")]
        public string TelContact { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Fax Contact")]
        public string FaxContact { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Gsm Contact")]
        public string GsmContact { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Con")]
        public string EmailCon { get; set; }

        public bool Douleurs { get; set; }

        [Display(Name = "Taux Tva")]
        public TauxTva TauxTva { get; set; }

        [DataType(DataType.MultilineText)]
        public string Remarque { get; set; }
    }
}
