using CreditsConnection.Connection;
using CreditsModel.ModelDto;
using CreditsRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditsRepository.Repository
{
    public class CreditsPagosRepository : ICreditsPagosRepository
    {
        private CreditsCn xObjCn = new CreditsCn();
        public void ActualizaMesAnioImpago(CreditsPagosDto pObj)
        {
            xObjCn.Connection();
            List<SqlParameter> lParameter = new List<SqlParameter>()
                {
                new SqlParameter("@strMes", pObj.Mes),
                new SqlParameter("@strAnio", pObj.Anio),
                new SqlParameter("@strUnidDscto", pObj.CreditsOperationsDto.UnidDscto),
                   };
            xObjCn.AssignParameters(lParameter);
            xObjCn.CommandStoreProcedure("isp_ActualizaMesAnioImpago");
            xObjCn.ExecuteNotResult();
            xObjCn.Disconnect();
        }

        public List<CreditsPagosDto> RastreaDeudasImpagas(CreditsPagosDto creditsPagosDto)
        {
            List<CreditsPagosDto> rastredeudasimpagas = new List<CreditsPagosDto>();
            List<SqlParameter> lParameter = new List<SqlParameter>()
                {
                new SqlParameter("@strInteres", creditsPagosDto.Interes),
                new SqlParameter("@strIgv", creditsPagosDto.Igv),
                new SqlParameter("@strPeriodo", creditsPagosDto.Periodo),
                new SqlParameter("@strUnidDscto", creditsPagosDto.CreditsOperationsDto.UnidDscto),
                };
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_RastreaDeudasImpagas");
            xObjCn.AssignParameters(lParameter);
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                rastredeudasimpagas.Add(new CreditsPagosDto()
                {
                    IdOperacion = (decimal)xIdr[0],
                    Ant_Amortizacion = (decimal)xIdr[1],
                    Ant_Interes = (decimal)xIdr[2],
                    Ant_Seguro = (decimal)xIdr[3],
                    Ant_Gastos = (decimal)xIdr[4],
                    Ant_Igv = (decimal)xIdr[5],
                    Ant_Comision1 = (decimal)xIdr[6],
                    Ant_Comision2 = (decimal)xIdr[7],
                    Interes = (decimal)xIdr[8],
                    MasIgv = (decimal)xIdr[9],
                    Queda = (decimal)xIdr[10],
                });
            }
            xObjCn.Disconnect();
            return rastredeudasimpagas;
        }

        public void ProcesoReprogramaPagosMesAnioImpago(CreditsPagosDto pObj)
        {
            xObjCn.Connection();
            List<SqlParameter> lParameter = new List<SqlParameter>()
                {
                new SqlParameter("@strMes", pObj.Mes),
                new SqlParameter("@strAnio", pObj.Anio),
                new SqlParameter("@strIdOperacion", pObj.IdOperacion),
                new SqlParameter("@strAmortizacion", pObj.Ant_Amortizacion),
                new SqlParameter("@strInteres", pObj.Ant_Interes),
                new SqlParameter("@strSeguro", pObj.Ant_Seguro),
                new SqlParameter("@strGastos", pObj.Ant_Gastos),
                new SqlParameter("@strIgv", pObj.Ant_Igv),
                new SqlParameter("@strComision1", pObj.Interes),
                new SqlParameter("@strComision2", pObj.MasIgv),
                   };
            xObjCn.AssignParameters(lParameter);
            xObjCn.CommandStoreProcedure("isp_ProcesoReprogramaPagosMesAnioImpago");
            xObjCn.ExecuteNotResult();
            xObjCn.Disconnect();
        }
    }
}
