using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ArteVida.GestorWeb.ViewModels
{
    public class PessoaViewModel
    {
        public int PessoaId { get; set; }
        public string NumeroFicha { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }     
        public DateTime? DataCadastro { get; set; }
        public DateTime? DataNascimento { get; set; }
        public string Rg { get; set; }
        //[StringLength(11)]
        public string Cpf { get; set; }
        //[StringLength(1)]
        public string Sexo { get; set; }
        public int Idade { get; set; }
        public string Telefone { get; set; }
        public string Escola { get; set; }
        public string Serie { get; set; }
        public string Pai { get; set; }
        public string TelefonePai { get; set; }
        public string Mae { get; set; }
        public string TelefoneMae { get; set; }
        public string Tipo { get; set; }
    }
}