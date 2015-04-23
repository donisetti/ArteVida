using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ArteVida.GestorWeb.ViewModels
{

    public class ImagemViewModel
    {
        [Required]
        public string Titulo { get; set; }

        public string Alternativo { get; set; }

        [DataType(DataType.Html)]
        public string Legenda { get; set; }

        [DataType(DataType.Upload)]
        public HttpPostedFileBase ImagemUpload { get; set; }
    }


}