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
    public class CreditsProcesoPagoController
    {
        private readonly ICreditsProcesoPagoRepository _iCreditsProcesoPagoRepository;
        public CreditsProcesoPagoController()
        {
            this._iCreditsProcesoPagoRepository = new CreditsProcesoPagoRepository();
        }
        public CreditsProcesoPagoDto SelProcesoPago(CreditsProcesoPagoDto creditsProcesoPagosDto)
        {
            return this._iCreditsProcesoPagoRepository.SelProcesoPago(creditsProcesoPagosDto);
        }
        public void ProcesoInsertarProcesoPago(CreditsProcesoPagoDto pObj)
        {
            this._iCreditsProcesoPagoRepository.ProcesoInsertarProcesoPago(pObj);
        }
    }
}
