using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EstablishmentCategories.Models
{
    public class Establishment
    {

        public long Id { get; set; }

        [Required]
        public string companyName { get; set; }

        public string fantasyName { get; set; }

        [Required]
        [RegularExpression(@"(^(\d{2}.\d{3}.\d{3}/\d{4}-\d{2})|(\d{14})$)", ErrorMessage = "CNPJ em formato Inválido!")]
        [StringLength(200)]
        [Index(IsUnique = true)]
        public string cnpj { get; set; }

        [EmailAddress(ErrorMessage= "E-Mail em formato inválido!")]
        public string email { get; set; }

        public string address { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        [Phone(ErrorMessage= "Telefone em formato inválido!")]
        public string telephone { get; set; }

	    [DataType(DataType.Date)]
        public DateTime? registrationDate { get; set; }

        public EstablishmentCategory? category { get; set; }

        public EstablishmentStatus? status { get; set; }

        [RegularExpression(@"^\d{3}-\d$", ErrorMessage = "Agência em formato Inválido!")]
        public string Agency { get; set; }

        [RegularExpression(@"^\d{2}.\d{3}-\d$", ErrorMessage = "Conta em formato Inválido!")]
        public string account { get; set; }
    }
}