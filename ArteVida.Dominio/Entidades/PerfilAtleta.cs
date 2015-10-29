using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteVida.Dominio.Entidades
{
    public class PerfilAtleta
    {
        // FK
        public int PessoaId { get; set; }

        public string Peso { get; set; }
        public string Altura { get; set; }

        public string Provas { get; set; }

        public string MelhorMarca { get; set; }

        public string Tempo { get; set; }

        public string ComoComecou { get; set; }

        public string MomentoMarcante { get; set; }

        public string PrimeiraConquista { get; set; }

        public string UmaMusica { get; set; }

        public string UmLivro { get; set; }

        public string Sonho { get; set; }
        public string UmFilme { get; set; }

        public string UmIdoloEsporte { get; set; }

        public string UmIdoloVida { get; set; }
        public string UmaComida { get; set; }
        public string UmaSobremesa { get; set; }
        public string LugarDescanso { get; set; }
        public string Lazer { get; set; }

        public string PassaTempo { get; set; }

        public string Time { get; set; }

        public string OutrosEsportes { get; set; }

        public List<Resultado>  Resultados { get; set; }

    }
}
