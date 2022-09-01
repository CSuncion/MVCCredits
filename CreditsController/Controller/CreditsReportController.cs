﻿using CreditsRepository.IRepository;
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
    }
}
