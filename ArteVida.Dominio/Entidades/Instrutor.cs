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

       public string Atividade { get; set; }
       public string Profissao { get; set; }
       public string Observacao { get; set; }
    }
}
