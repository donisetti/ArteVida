using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteVida.Dominio.Entidades
{
    public class Socio : Pessoa
    {
         public DateTime? DataAdesao { get; set; }
         public decimal Mensalidade { get; set; }
    }
}
