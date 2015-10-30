using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArteVida.Dominio.Entidades;

namespace ArteVida.Dominio.Repositorio
{
    class RepositorioSocio : Repositorio<Socio>
    {
        public RepositorioSocio(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            
        }
    }
}
