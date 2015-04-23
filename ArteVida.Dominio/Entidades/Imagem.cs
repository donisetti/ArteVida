using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteVida.Dominio.Entidades
{
    public class Imagem
    {

        private DateTime? dataCadastro;

        [Key]
        public int Id { get; set; }

        [Required]
        public string Titulo { get; set; }

        public string Alternativo { get; set; }

        [DataType(DataType.Html)]
        public string Legenda { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string Url { get; set; }


        [Required]
        [DataType(DataType.DateTime)]
        public DateTime DataCadastro
        {
            get { return dataCadastro ?? DateTime.UtcNow; }
            set { dataCadastro = value; }
        }
    }
}
