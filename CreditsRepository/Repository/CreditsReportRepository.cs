using CreditsConnection.Connection;
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
    public class CreditsReportRepository : ICreditsReportRepository
    {
        private CreditsCn xObjCn = new CreditsCn();
        private dynamic xObj;
        private List<dynamic> xLista = new List<dynamic>();
        public List<dynamic> ListarCreditosOtorgados(int anio)
        {
            List<SqlParameter> lParameter = new List<SqlParameter>()
                {
                new SqlParameter("@strAnio", anio)
                };

            List<dynamic> creditoOtorgados = new List<dynamic>();
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_ListarCreditosOtorgados");
            xObjCn.AssignParameters(lParameter);
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                creditoOtorgados.Add(new
                {
                    Id_Mes = (int)xIdr[0],
                    Des_Mes = (string)xIdr[1],
                    CreditosAprobados = (int)xIdr[2],
                    MontosAprobados = (decimal)xIdr[3]
                });
            }
            xObjCn.Disconnect();
            return creditoOtorgados;
        }
        public List<dynamic> ListarTipoCreditos(int anio)
        {
            List<SqlParameter> lParameter = new List<SqlParameter>()
                {
                new SqlParameter("@strAnio", anio)
                };

            List<dynamic> tipoCreditos = new List<dynamic>();
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_ListarTipoCreditos");
            xObjCn.AssignParameters(lParameter);
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                tipoCreditos.Add(new
                {
                    Productos = (string)xIdr[0],
                    CreditosAprobados = (int)xIdr[1],
                    MontosAprobados = (decimal)xIdr[2]
                });
            }
            xObjCn.Disconnect();
            return tipoCreditos;
        }
    }
}
