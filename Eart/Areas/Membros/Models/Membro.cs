using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eart.Areas.Membros.Models
{
    public class Membro
    {
        [DisplayName("Id")]
        public long? MembroId { get; set; }

        [DisplayName("Nome")]
        [StringLength(50, ErrorMessage = "O nome do fabricante precisa ter no mínimo 2 caracteres", MinimumLength = 2)]
        [Required(ErrorMessage = "Informe o seu nome")]
        public string Nome { get; set; }

        [DisplayName("Usuário")]
        [StringLength(12, ErrorMessage = "O nome do fabricante precisa ter no mínimo 2 caracteres", MinimumLength = 2)]
        [Required(ErrorMessage = "Informe seu nome de usuário")]
        public string Usuario { get; set; }

        [DisplayName("Email")]
        [Required(ErrorMessage = "Informe o seu email")]
        public string Email { get; set; }

        [DisplayName("Senha")]
        [StringLength(12, ErrorMessage = "Sua senha precisa ter no mínimo 6 caracteres", MinimumLength = 6)]
        [Required(ErrorMessage = "Informe sua senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [DisplayName("Confirme sua senha")]
        [StringLength(12, ErrorMessage = "Sua senha precisa ter no mínimo 6 caracteres", MinimumLength = 6)]
        [Required(ErrorMessage = "Confirme sua senha")]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "A senha e a confirmação da senha estão diferentes")]
        public string ConfSenha { get; set; }

        [DisplayName("Biografia")]
        public string Biografia { get; set; }

    }

    public class LoginViewModel
    {
        public string Usuario { get; set; }

        public string Senha { get; set; }
    }
}

/*
        public string FotoPerfilNome { get; set; }
        public string FotoPerfilCaminho { get; set; }
        public string FotoCapaNome { get; set; }
        public string FotoCapaCaminho { get; set; }
        */