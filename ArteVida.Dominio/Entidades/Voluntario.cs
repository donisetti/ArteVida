using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteVida.Dominio.Entidades
{
    public class Voluntario : Pessoa
    {
        public string Empresa { get; set; }

        public string Atividade { get; set; }

        public string Periodo { get; set; }
        
        public string DiaSemana { get; set; }
        public string Motivacao { get; set; }



    }
}
