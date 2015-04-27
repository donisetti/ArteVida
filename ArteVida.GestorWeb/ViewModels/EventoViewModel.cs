using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArteVida.GestorWeb.ViewModels
{
    public class EventoViewModel
    {
        public int EventoId { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data Evento:")]
        public DateTime? DataEvento { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Titulo do Evento:")]
        public string Nome { get; set; }

        public string Modalidade { get; set; }
        public string Cidade { get; set; }

    }
}