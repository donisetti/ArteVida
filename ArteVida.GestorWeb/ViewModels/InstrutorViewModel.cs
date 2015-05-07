using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArteVida.GestorWeb.ViewModels
{
    public class InstrutorViewModel
    {
        public int PessoaId { get; set; }
       

        [Display(Name = "Nome")]
        public string Nome { get; set; }
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        [Display(Name = "Data Cadastro")]
        public DateTime? DataCadastro { get; set; }

        public string Atividade { get; set; }
          [Display(Name = "Profissão")]
        public string Profissao { get; set; }
          [Display(Name = "Observação")]
        public string Observacao { get; set; }
       
    }
}