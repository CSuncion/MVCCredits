using CreditsModel.ModelDto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditsRepository.IRepository
{
    public interface ICreditsGeneralRepository
    {
        List<CreditsMesesDto> ListarMeses();
        List<CreditsCentroCostosDto> ListarCentroCostos(string codCosto);
        void CrearBackupDbFbPol();
        List<CreditsUnDsctoDto> ListarPlanillaPago();
        List<CreditsMonedaDto> ListarMoneda();
        List<CreditsEntidadBancariaDto> ListaEntidadBancaria();
        List<CreditsProveedorDto> ListaProveedor();
        List<CreditsMoraDto> ListarMora();
        List<CreditsComisionDto> ListarComisionPorUndDscto(string IdUniDscto);
        List<CreditsIgvDto> ListarIgv();
    }
}
