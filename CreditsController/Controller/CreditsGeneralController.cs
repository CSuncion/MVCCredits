using CreditsRepository.Repository;
using CreditsRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditsModel.ModelDto;

namespace CreditsController.Controller
{
    public class CreditsGeneralController
    {
        private readonly ICreditsGeneralRepository _iCreditsGeneralRepository;
        public CreditsGeneralController()
        {
            this._iCreditsGeneralRepository = new CreditsGeneralRepository();
        }
        public List<CreditsMesesDto> ListarMeses()
        {
            return this._iCreditsGeneralRepository.ListarMeses();
        }
        public List<CreditsCentroCostosDto> ListarCentroCostos(string codCosto)
        {
            return this._iCreditsGeneralRepository.ListarCentroCostos(codCosto);
        }
        public void CrearBackupDbFbPol()
        {
            this._iCreditsGeneralRepository.CrearBackupDbFbPol();
        }
        public List<CreditsUnDsctoDto> ListarPlanillaPago()
        {
            return this._iCreditsGeneralRepository.ListarPlanillaPago();
        }
        public List<CreditsMonedaDto> ListarMoneda()
        {
            return this._iCreditsGeneralRepository.ListarMoneda();
        }
        public List<CreditsEntidadBancariaDto> ListaEntidadBancaria()
        {
            return this._iCreditsGeneralRepository.ListaEntidadBancaria();
        }
        public List<CreditsProveedorDto> ListaProveedor()
        {
            return this._iCreditsGeneralRepository.ListaProveedor();
        }
    }
}
