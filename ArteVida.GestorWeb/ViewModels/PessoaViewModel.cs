using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArteVida.GestorWeb.ViewModels
{
    public class PessoaViewModel
    {
        public int PessoaId { get; set; }
        [DataType(DataType.Text)]
        [Display(Name = "Ficha nº")]
        public string NumeroFicha { get; set; }
        [DataType(DataType.Text)]
        public string Nome { get; set; }
        [DataType(DataType.Text)]
        public string Endereco { get; set; }
        [DataType(DataType.Text)]
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data Cadastro")]
        public DateTime? DataCadastro { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Data Nascimento")]
        public DateTime? DataNascimento { get; set; }
        public string Rg { get; set; }
        //[StringLength(11)]
        public string Cpf { get; set; }
        //[StringLength(1)]
        public string Sexo { get; set; }
        public int? Idade { get; set; }
        [DataType(DataType.PhoneNumber)]
        public string Telefone { get; set; }
        public string Escola { get; set; }
        public string Serie { get; set; }
          [Display(Name = "Pai:")]
        public string Pai { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefone Pai:")]
        public string TelefonePai { get; set; }
         [Display(Name = "Mãe:")]
        public string Mae { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Telefone Mãe:")]
        public string TelefoneMae { get; set; }
        public string Tipo { get; set; }
    }
}