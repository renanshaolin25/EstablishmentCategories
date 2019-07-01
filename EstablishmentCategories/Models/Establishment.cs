using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        [RegularExpression("/^d{2}.d{3}.d{3}/d{4}-d{2}$/", ErrorMessage = "CNPJ Inválido!")]
        public string cnpj { get; set; }

        [EmailAddress]
        public string email { get; set; }

        public string address { get; set; }

        public string city { get; set; }

        public string state { get; set; }

        [Phone]
        public string telephone { get; set; }

        [RegularExpression("/^([0-2][0-9]|(3)[0-1])(/)(((0)[0-9])|((1)[0-2]))(/)d{4}$/", ErrorMessage = "Data de Cadastro Inválido!")]
        public DateTime? registrationDate { get; set; }

        public EstablishmentCategory? category { get; set; }

        public EstablishmentStatus? status { get; set; }

        [RegularExpression("/^d{3}-d$/", ErrorMessage = "Agência Inválido!")]
        public string Agency { get; set; }

        [RegularExpression("/^d{2}.d{3}-d$/", ErrorMessage = "Conta Inválido!")]
        public string account { get; set; }
    }
}