using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteVida.Dominio.Entidades
{
    public class MonitoramentoEscolar
    {
        public int ResultadoId { get; set; }

        // pk
        public int PessoaId { get; set; }

        public string Escola { get; set; }

        public string Cursando { get; set; }

        public string Periodo { get; set; }

        public string Aspecto1 { get; set; }
        public string Aspecto2 { get; set; }
        public string Aspecto3 { get; set; }
        public string Aspecto4 { get; set; }
        public string Aspecto5 { get; set; }
        public string Aspecto6 { get; set; }
        public string Aspecto7 { get; set; }

        public string Observacao { get; set; }



    }
}
