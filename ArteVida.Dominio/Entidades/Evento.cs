using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteVida.Dominio.Entidades
{
    public class Evento : Entidade
    {
        public int EventoId { get; set; }
        public DateTime? DataEvento { get; set; }

        public string Nome { get; set; }
        public string Cidade { get; set; }

    }
}
