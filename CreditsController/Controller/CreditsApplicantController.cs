using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditsModel.ModelDto;
using CreditsRepository.IRepository;
using CreditsRepository.Repository;

namespace CreditsController.Controller
{
    public class CreditsApplicantController
    {
        private readonly ICreditsApplicantRepository _iCreditsApplicantRepository;
        public CreditsApplicantController()
        {
            this._iCreditsApplicantRepository = new CreditsApplicantRepository();
        }
        public List<CreditsApplicantDto> ListarSolicitantes()
        {
            return this._iCreditsApplicantRepository.ListarSolicitantes();
        }
    }
}
