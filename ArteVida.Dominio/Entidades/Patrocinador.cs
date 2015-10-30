using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArteVida.Dominio.Entidades
{
    public class Patrocinador : Pessoa
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Logo { get; set; }
        public string Responsavel { get; set; }
        public string Atividade { get; set; }
        public string TelefoneResponsavel { get; set; }
        public string CelularResponsavel { get; set; }
        public DateTime? DataAdesao { get; set; }
        public decimal Mensalidade { get; set; }

    }



}
