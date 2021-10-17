using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ControleDeEstoque.Models
{
    public class LoginViewModel
    {
        //[Display (Name = "Usuário")] = exibir o nomeo Formatado
        [Required(ErrorMessage ="Informe o Usuario")]
        [Display(Name = "Usuário: ")]
        public string Usuario{ get; set; }

        [Required(ErrorMessage ="Informe sua Senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Senha: ")]
        public string Senha{ get; set; }

        [Display(Name = "Lembrar Me")]
        public bool LembrarMe{ get; set; }
    }
}