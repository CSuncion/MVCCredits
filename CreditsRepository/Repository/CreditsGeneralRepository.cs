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
    public class CreditsGeneralRepository : ICreditsGeneralRepository
    {
        private CreditsCn xObjCn = new CreditsCn();
        public List<CreditsMesesDto> ListarMeses()
        {
            List<CreditsMesesDto> meses = new List<CreditsMesesDto>();
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_ListarMeses");
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                meses.Add(new CreditsMesesDto()
                {
                    Id_Mes = (int)xIdr[0],
                    Des_Mes = (string)xIdr[1],
                    Corto_Mes = (string)xIdr[2]
                });
            }
            xObjCn.Disconnect();
            return meses;
        }
        public List<CreditsCentroCostosDto> ListarCentroCostos(string codCosto)
        {
            List<CreditsCentroCostosDto> centrocosto = new List<CreditsCentroCostosDto>();
            List<SqlParameter> lParameter = new List<SqlParameter>()
                {
                new SqlParameter("@strCodCosto", codCosto)
                };
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_ListarCentroCosto");
            xObjCn.AssignParameters(lParameter);
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                centrocosto.Add(new CreditsCentroCostosDto()
                {
                    Id_Costos = (int)xIdr[0],
                    Cod_Costo = (string)xIdr[1],
                    CodigoCosto = (string)xIdr[2],
                    Name_Costo = (string)xIdr[3],
                    CtaCont = (string)xIdr[4],
                    PlanCta = (string)xIdr[5],
                });
            }
            xObjCn.Disconnect();
            return centrocosto;
        }
        public void CrearBackupDbFbPol()
        {
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_CrearBackupDbFbPol");
            xObjCn.ExecuteNotResult();
            xObjCn.Disconnect();
        }
    }
}
