using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using ArteVida.Dominio.Entidades;

namespace ArteVida.GestorWeb.ViewModels
{
    public class IrmaoViewModel
    {
        public int IrmaoId { get; set; }

           [Display(Name = "Nome:")]
        public string Nome { get; set; }
           [Display(Name = "Ficha")]
        public string Numero { get; set; }
           [Display(Name = "Atleta id")]
        public int PessoaId { get; set; }
           [Display(Name = "Atleta:")]
        public Atleta Atleta { get; set; }
           [Display(Name = "Idade:")]
        public string Idade { get; set; }
    }
}