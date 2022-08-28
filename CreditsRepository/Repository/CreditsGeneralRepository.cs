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
        private CreditsMesesDto xObjMeses = new CreditsMesesDto();
        private List<CreditsMesesDto> xListaMeses = new List<CreditsMesesDto>();
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
    }
}
