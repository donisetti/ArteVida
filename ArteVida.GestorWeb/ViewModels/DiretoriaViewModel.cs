using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArteVida.GestorWeb.ViewModels
{
    public class DiretoriaViewModel
    {
        public int PessoaId { get; set; }


        [Display(Name = "Nome")]
        public string Nome { get; set; }
    }
}