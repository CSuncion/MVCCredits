using CreditsConnection.Connection;
using CreditsModel.ModelDto;
using CreditsRepository.IRepository;
using System;
using System.Collections.Generic;
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
                new SqlParameter("@strstrMes", pObj.Mes),
                new SqlParameter("@strAnio", pObj.Anio),
                new SqlParameter("@strUnidDscto", pObj.CreditsOperationsDto.UnidDscto),
                   };
            xObjCn.AssignParameters(lParameter);
            xObjCn.CommandStoreProcedure("isp_ActualizaMesAnioImpago");
            xObjCn.ExecuteNotResult();
            xObjCn.Disconnect();
        }
    }
}
