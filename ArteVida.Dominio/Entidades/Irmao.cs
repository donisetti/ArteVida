using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteVida.Dominio.Entidades
{
    public class Irmao
    {
        public int IrmaoId { get; set; }

        public string Nome { get; set; }

        public string Numero { get; set; }

        public int PessoaId { get; set; }

        public Atleta Atleta { get; set; }
  
        public string Idade { get; set; }
    }
}
