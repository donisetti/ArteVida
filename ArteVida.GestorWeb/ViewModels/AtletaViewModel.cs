using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArteVida.GestorWeb.ViewModels
{
    public class AtletaViewModel
    {
        public int PessoaId { get; set; }
          [Display(Name = "Ficha nº")]
        public string NumeroFicha { get; set; }
          [Display(Name = "Nome")]
        public string Nome { get; set; }
          [Display(Name = "Endereço")]
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
          [Display(Name = "Data Cadastro")]
        public DateTime? DataCadastro { get; set; }
          [Display(Name = "Data Nascimento")]
        public DateTime? DataNascimento { get; set; }
        public string Rg { get; set; }
        //[StringLength(11)]
        public string Cpf { get; set; }
        //[StringLength(1)]
        public string Sexo { get; set; }
        public int? Idade { get; set; }
        public string Telefone { get; set; }
        public string Escola { get; set; }
        public string Serie { get; set; }
        public string Pai { get; set; }
          [Display(Name = "Telefone Pai")]
        public string TelefonePai { get; set; }
          [Display(Name = "Mãe")]
        public string Mae { get; set; }
          [Display(Name = "Telefone Mãe")]
        public string TelefoneMae { get; set; }

        public string Modalidade { get; set; }

        public string NomePais { get; set; }
        public string TelefonePais { get; set; }
    }
}