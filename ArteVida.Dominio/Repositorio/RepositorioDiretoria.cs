using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArteVida.Dominio.Entidades;

namespace ArteVida.Dominio.Repositorio
{
    public class RepositorioDiretoria : Repositorio<Diretoria>
    {
        public RepositorioDiretoria(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            
        }
    }
}
