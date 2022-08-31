using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditsRepository.IRepository
{
    public interface ICreditsReportRepository
    {
        List<dynamic> ListarCreditosOtorgados(int anio);
        List<dynamic> ListarTipoCreditos(int anio);
    }
}
