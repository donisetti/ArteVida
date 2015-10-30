using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteVida.Dominio.Entidades
{
   public  class Instrutor : Pessoa
    {
       public Instrutor()
       {
           this.Tipo = "Instrutor";
       }

        public string Faculdade { get; set; }
        public string Atividade { get; set; }
        public string Cref { get; set; }

        public string Observacao { get; set; }
    }
}
