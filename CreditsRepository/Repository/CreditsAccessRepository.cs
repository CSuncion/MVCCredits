using CreditsConnection.Connection;
using CreditsModel.ModelDto;
using CreditsRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CreditsRepository.Repository
{
    public class CreditsAccessRepository : ICreditsAccessRepository
    {
        private CreditsCn xObjCn = new CreditsCn();
        private CreditsAccessDto xObj = new CreditsAccessDto();
        private CreditsAccessDto Objeto(IDataReader iDr)
        {
            CreditsAccessDto xObjEnc = new CreditsAccessDto();
            xObjEnc.Id_Acceso = Convert.ToInt32(iDr[CreditsAccessDto.IdAcc]);
            xObjEnc.Name_Acceso = iDr[CreditsAccessDto.NamAcc].ToString();
            xObjEnc.Dni_Acceso = iDr[CreditsAccessDto.DniAcc].ToString();
            xObjEnc.Pass_Acceso = iDr[CreditsAccessDto.PassAcc].ToString();
            xObjEnc.Paterno_Acceso = iDr[CreditsAccessDto.PatAcc].ToString();
            xObjEnc.Materno_Acceso = iDr[CreditsAccessDto.MatAcc].ToString();
            xObjEnc.Names_Acceso = iDr[CreditsAccessDto.NamsAcc].ToString();
            xObjEnc.Mail_Acceso = iDr[CreditsAccessDto.MailAcc].ToString();
            xObjEnc.Domicilio_Acceso = iDr[CreditsAccessDto.DomAcc].ToString();
            xObjEnc.Dpto_Acceso = Convert.ToInt32(iDr[CreditsAccessDto.DptoAcc]);
            xObjEnc.Prov_Acceso = Convert.ToInt32(iDr[CreditsAccessDto.ProvAcc]);
            xObjEnc.Dist_Acceso = Convert.ToInt32(iDr[CreditsAccessDto.DistAcc]);
            xObjEnc.Fijo_Acceso = iDr[CreditsAccessDto.FijAcc].ToString();
            xObjEnc.Movil_Acceso = iDr[CreditsAccessDto.MovAcc].ToString();
            xObjEnc.Level_Acceso = Convert.ToInt32(iDr[CreditsAccessDto.LevAcc]);
            xObjEnc.Sit_Acceso = Convert.ToInt32(iDr[CreditsAccessDto.SitAcc]);
            xObjEnc.Fecha_Acceso = Convert.ToDateTime(iDr[CreditsAccessDto.FecAcc]);
            xObjEnc.Who_ = Convert.ToInt32(iDr[CreditsAccessDto.Who]);
            xObjEnc.Ofc1 = Convert.ToInt32(iDr[CreditsAccessDto.Of1]);
            xObjEnc.Ofc2 = Convert.ToInt32(iDr[CreditsAccessDto.Of2]);
            xObjEnc.Ofc3 = Convert.ToInt32(iDr[CreditsAccessDto.Of3]);
            xObjEnc.Ofc4 = Convert.ToInt32(iDr[CreditsAccessDto.Of4]);
            xObjEnc.Cip_Acceso = iDr[CreditsAccessDto.CipAcc].ToString();
            xObjEnc.Codofin_Acceso = iDr[CreditsAccessDto.CodfinAcc].ToString();
            xObjEnc.Grado_Acceso = Convert.ToDecimal(iDr[CreditsAccessDto.GradAcc]);
            xObjEnc.Pnp = Convert.ToInt32(iDr[CreditsAccessDto.xPnp]);
            xObjEnc.Cargo_Acceso = iDr[CreditsAccessDto.CargAcc].ToString();
            return xObjEnc;
        }
        private CreditsAccessDto BuscarObjeto(string pScript, List<SqlParameter> lParameter)
        {
            xObjCn.Connection();
            xObjCn.AssignParameters(lParameter);
            xObjCn.CommandStoreProcedure(pScript);
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                //adicionando cada objeto a la lista
                this.xObj = this.Objeto(xIdr);
            }
            xObjCn.Disconnect();
            return xObj;
        }
        public CreditsAccessDto BuscarUsuarioXCodigo(CreditsAccessDto pObj)
        {
            List<SqlParameter> lParameter = new List<SqlParameter>()
                {
                new SqlParameter("@strDniAccess", pObj.Dni_Acceso)
                };

            return this.BuscarObjeto("isp_BuscarUsuarioXCodigo", lParameter);
        }
        public List<int> ListarSubPrivilegiosAcceso(int idAcceso)
        {
            List<SqlParameter> lParameter = new List<SqlParameter>()
                {
                new SqlParameter("@strIdAcceso", idAcceso)
                };

            List<int> menu = new List<int>();
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_ListarSubPrivilegiosAcceso");
            xObjCn.AssignParameters(lParameter);
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                menu.Add((int)xIdr[0]);
            }
            xObjCn.Disconnect();
            return menu;
        }

    }
}
