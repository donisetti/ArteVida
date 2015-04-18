using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArteVida.Dominio.Entidades;

namespace ArteVida.Dominio.Repositorio
{
    public class RepositorioTabelaAuxiliar : Repositorio<TabelaAuxiliar>
    {
        public RepositorioTabelaAuxiliar(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {

        }
    }
}
