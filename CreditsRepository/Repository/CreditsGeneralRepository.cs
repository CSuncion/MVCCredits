using CreditsConnection.Connection;
using CreditsModel.ModelDto;
using CreditsRepository.IRepository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
                    CodCosto_CodigoCosto = (string)xIdr[6],
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

        public List<CreditsUnDsctoDto> ListarPlanillaPago()
        {
            List<CreditsUnDsctoDto> unDscto = new List<CreditsUnDsctoDto>();
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_ListarPlanillaPago");
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                unDscto.Add(new CreditsUnDsctoDto()
                {
                    IdUnidDscto = (int)xIdr[0],
                    DesUnidDscto = (string)xIdr[1],
                    DesCortaUDscto = (string)xIdr[2]
                });
            }
            xObjCn.Disconnect();
            return unDscto;
        }
        public List<CreditsMonedaDto> ListarMoneda()
        {
            List<CreditsMonedaDto> moneda = new List<CreditsMonedaDto>();
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_ListarMoneda");
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                moneda.Add(new CreditsMonedaDto()
                {
                    Id_Moneda = (int)xIdr[0],
                    Des_Moneda = (string)xIdr[1],
                    Simbolo = (string)xIdr[2]
                });
            }
            xObjCn.Disconnect();
            return moneda;
        }
        public List<CreditsEntidadBancariaDto> ListaEntidadBancaria()
        {
            List<CreditsEntidadBancariaDto> entBca = new List<CreditsEntidadBancariaDto>();
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_ListaEntidadBancaria");
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                entBca.Add(new CreditsEntidadBancariaDto()
                {
                    Tp_Bca = (string)xIdr[0],
                    Id_Bca = (string)xIdr[1],
                    De_Bca = (string)xIdr[2]
                });
            }
            xObjCn.Disconnect();
            return entBca;
        }
        public List<CreditsProveedorDto> ListaProveedor()
        {
            List<CreditsProveedorDto> proveedor = new List<CreditsProveedorDto>();
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_ListaProveedor");
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                proveedor.Add(new CreditsProveedorDto()
                {
                    Id_Proveedor = (decimal)xIdr[0],
                    names = (string)xIdr[1],
                });
            }
            xObjCn.Disconnect();
            return proveedor;
        }

        public List<CreditsMoraDto> ListarMora()
        {
            List<CreditsMoraDto> mora = new List<CreditsMoraDto>();
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_ListarMora");
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                mora.Add(new CreditsMoraDto()
                {
                    IdIntMora = (int)xIdr[0],
                    FechaMora = (DateTime)xIdr[1],
                    PorcentMora = (decimal)xIdr[2],
                    FgMora = (int)xIdr[3],
                    UserMora = (int)xIdr[4],
                });
            }
            xObjCn.Disconnect();
            return mora;
        }

        public List<CreditsComisionDto> ListarComisionPorUndDscto(string IdUniDscto)
        {
            List<CreditsComisionDto> comision = new List<CreditsComisionDto>();
            List<SqlParameter> lParameter = new List<SqlParameter>()
                {
                new SqlParameter("@strIdUniDscto", IdUniDscto)
                };
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_ListarComisionPorUndDscto");
            xObjCn.AssignParameters(lParameter);
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                comision.Add(new CreditsComisionDto()
                {
                    id_Comision = (int)xIdr[0],
                    IdUniDscto = (int)xIdr[1],
                    FechaComision = (DateTime)xIdr[2],
                    ImporteComision = (decimal)xIdr[3],
                    TpComision = (int)xIdr[4],
                    FgComision = (int)xIdr[5],
                });
            }
            xObjCn.Disconnect();
            return comision;
        }

        public List<CreditsIgvDto> ListarIgv()
        {
            List<CreditsIgvDto> igv = new List<CreditsIgvDto>();
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_ListarIgv");
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                igv.Add(new CreditsIgvDto()
                {
                    Id_Igv = (int)xIdr[0],
                    De_Igv = (decimal)xIdr[1],
                    Fecha_Igv = (DateTime)xIdr[2],
                    FgIgv = (int)xIdr[3],
                });
            }
            xObjCn.Disconnect();
            return igv;
        }

        public List<CreditsCheqOperDto> ListarCheqOper()
        {
            List<CreditsCheqOperDto> cheqope = new List<CreditsCheqOperDto>();
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_ListCheqOper");
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                cheqope.Add(new CreditsCheqOperDto()
                {
                    Id_Cheque_Operac = (int)xIdr[0],
                    De_CheqOperac = (string)xIdr[1],
                });
            }
            xObjCn.Disconnect();
            return cheqope;
        }

        public List<CreditsFinanBancaDto> ListarFinanBanca()
        {
            List<CreditsFinanBancaDto> finban = new List<CreditsFinanBancaDto>();
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_ListFinanBanca");
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                finban.Add(new CreditsFinanBancaDto()
                {
                    Tp_Bca = (string)xIdr[0],
                    Id_Bca = (string)xIdr[1],
                    De_Bca = (string)xIdr[2],
                });
            }
            xObjCn.Disconnect();
            return finban;
        }
    }
}
