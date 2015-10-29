using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArteVida.GestorWeb.ViewModels
{
    public class VoluntarioViewModel
    {
        public int PessoaId { get; set; }
        public string Nome { get; set; }

        public string Email { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }

        public string Estado { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Rg { get; set; }
       
        public string Cpf { get; set; }
       
        public string Sexo { get; set; }

        public string TelefoneResidencial { get; set; }
        public string TelefoneComercial { get; set; }
        public string TelefoneCelular { get; set; }

        public string Profissao { get; set; }
        public string Empresa { get; set; }
        public string Atividade { get; set; }

        public DateTime? DataInicio { get; set; }
        public string Periodo { get; set; }
        public string DiaSemana { get; set; }
        public string Motivacao { get; set; }





    }
}