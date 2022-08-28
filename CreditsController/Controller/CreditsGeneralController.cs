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
    }
}
