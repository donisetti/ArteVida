using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArteVida.Dominio.Entidades;

namespace ArteVida.Dominio.Repositorio
{
    public class RepositorioMonitoramentoEscolar : Repositorio<MonitoramentoEscolar>
    {
        public RepositorioMonitoramentoEscolar(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
                
        }
    }
}
