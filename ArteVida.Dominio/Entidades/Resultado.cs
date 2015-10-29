using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteVida.Dominio.Entidades
{
    public class Resultado
    {
        public int ResultadoId { get; set; }

        public DateTime Data { get; set; }
        //FK

        public int PessoaId { get; set; }
        public DateTime DataCompeticao { get; set; }

        public string Competicao { get; set; }

        public string Local { get; set; }

        public string Cidade { get; set; }
        public string Prova { get; set; }

        public string Tempo { get; set; }

        public string Classificacao { get; set; }

    }
}
