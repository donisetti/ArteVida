using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteVida.Dominio.Entidades
{
    public class Atleta : Pessoa
    {
        public Atleta()
        {
            this.Tipo = "Atleta";
        }
        public string Modalidade { get; set; }

        public string Foto { get; set; }

        public List<string> Modalidades { get; set; }

    }
}
