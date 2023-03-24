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
    public class CreditsPagosController
    {
        private readonly ICreditsPagosRepository _iCreditsPagosRepository;
        public CreditsPagosController()
        {
            this._iCreditsPagosRepository = new CreditsPagosRepository();
        }
        public void ActualizaMesAnioImpago(CreditsPagosDto pObj)
        {
            this._iCreditsPagosRepository.ActualizaMesAnioImpago(pObj);
        }

        public List<CreditsPagosDto> RastreaDeudasImpagas(CreditsPagosDto creditsPagosDto)
        {
            return this._iCreditsPagosRepository.RastreaDeudasImpagas(creditsPagosDto);
        }
    }
}
