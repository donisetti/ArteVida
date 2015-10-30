using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArteVida.Dominio.Entidades;

namespace ArteVida.Dominio.Repositorio
{
    public class RepositorioResultado : Repositorio<Resultado>
    {
        public RepositorioResultado(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
            
        }
    }
}
