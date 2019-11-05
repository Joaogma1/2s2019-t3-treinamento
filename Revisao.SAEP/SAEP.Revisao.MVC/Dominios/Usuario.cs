using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SAEP.Revisao.MVC.Dominios
{
    public partial class Usuario
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Informe o Email")]
        [EmailAddress(ErrorMessage = "Informe um Email Valido")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
