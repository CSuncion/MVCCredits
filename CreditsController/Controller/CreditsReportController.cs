using CreditsModel.ModelDto;
using CreditsRepository.IRepository;
using CreditsRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditsController.Controller
{
    public class CreditsReportController
    {
        private readonly ICreditsReportRepository _iCreditsReportRepository;
        public CreditsReportController()
        {
            this._iCreditsReportRepository = new CreditsReportRepository();
        }
        public List<dynamic> ListarCreditosOtorgados(int anio)
        {
            return this._iCreditsReportRepository.ListarCreditosOtorgados(anio);
        }
        public List<dynamic> ListarTipoCreditos(int anio)
        {
            return this._iCreditsReportRepository.ListarTipoCreditos(anio);
        }
        public List<dynamic> ListarTipoCreditoPorAnio(int anio, int codCentroCosto)
        {
            return this._iCreditsReportRepository.ListarTipoCreditoPorAnio(anio, codCentroCosto);
        }
        public List<dynamic> ListarSaldoFavorSolicitantes(string desde, string hasta)
        {
            return this._iCreditsReportRepository.ListarSaldoFavorSolicitantes(desde, hasta);
        }
        public List<dynamic> ListarTipoCreditoGeneradoDesembolsado(string desde, string hasta)
        {
            return this._iCreditsReportRepository.ListarTipoCreditoGeneradoDesembolsado(desde, hasta);
        }
        public List<dynamic> ListarCreditoEnProceso(string desde, string hasta)
        {
            return this._iCreditsReportRepository.ListarCreditoEnProceso(desde, hasta);
        }
        public List<dynamic> ListarCreditoMorosos(string hasta)
        {
            return this._iCreditsReportRepository.ListarCreditoMorosos(hasta);
        }
        public List<dynamic> ListarOperacionesRefinanciamientoAmpliacion(CreditsOperationsDto oCreOpe)
        {
            return this._iCreditsReportRepository.ListarOperacionesRefinanciamientoAmpliacion(oCreOpe);
        }
        public List<dynamic> ListarComparativoCreditoOtorgados()
        {
            return this._iCreditsReportRepository.ListarComparativoCreditoOtorgados();
        }
    }
}
