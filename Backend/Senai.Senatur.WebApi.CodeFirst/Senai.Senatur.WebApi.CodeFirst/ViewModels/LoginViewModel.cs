using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.Senatur.WebApi.CodeFirst.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informa o email!")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha!")]
        [DataType(DataType.EmailAddress)]
        public string Senha { get; set; }
    }
}
