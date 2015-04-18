using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace ArteVida.Dominio.Entidades
{
    public abstract class Entidade
    {
        //[Key]
        //public int Id { get; set; }

        private DateTime? _DataCadastro;


        public DateTime? DataCadastro
        {
            get { return _DataCadastro ?? DateTime.UtcNow; }
            set { _DataCadastro = value; }
        }

        public DateTime? DataAlteracao { get; set; }

        public DateTime? DataInativacao { get; set; }
        public bool Ativo { get; set; }

        public Entidade()
        {
            //DataCadastro = new DateTime(2014, 09, 01);
            //DataAlteracao = DateTime.Now;
            //Ativo = true;
        }

    }
}
