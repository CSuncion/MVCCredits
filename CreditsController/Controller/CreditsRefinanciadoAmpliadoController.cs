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
    public class CreditsRefinanciadoAmpliadoController
    {
        private readonly ICreditsRefinanciadoAmpliadoRepository _iCreditsRefinanciadoAmpliadoRepository;
        public CreditsRefinanciadoAmpliadoController()
        {
            this._iCreditsRefinanciadoAmpliadoRepository = new CreditsRefinanciadoAmpliadoRepository();
        }
        public void CrearRefinanciadoAmpliado(CreditsRefinanciadoAmpliadoDto pObj)
        {
            this._iCreditsRefinanciadoAmpliadoRepository.CrearRefinanciadoAmpliado(pObj);
        }

        public CreditsRefinanciadoAmpliadoDto ListarRefinanciadoAmpliadoPorOperacion(CreditsRefinanciadoAmpliadoDto pObj)
        {
            return this._iCreditsRefinanciadoAmpliadoRepository.ListarRefinanciadoAmpliadoPorOperacion(pObj);
        }
    }
}
