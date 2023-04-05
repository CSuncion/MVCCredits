using CreditsModel.ModelDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditsRepository.IRepository
{
    public interface ICreditsPagosRepository
    {
        void ActualizaMesAnioImpago(CreditsPagosDto pObj);
        List<CreditsPagosDto> RastreaDeudasImpagas(CreditsPagosDto creditsPagosDto);
        void ProcesoReprogramaPagosMesAnioImpago(CreditsPagosDto pObj);
        List<CreditsPagosDto> EnvioMesAnioIdOperacion(CreditsPagosDto creditsPagosDto);
        List<CreditsPagosDto> EnvioMesAnioIdOperacionCaja(CreditsPagosDto creditsPagosDto);
    }
}
