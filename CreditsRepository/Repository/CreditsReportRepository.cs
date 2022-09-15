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
        public List<dynamic> ListarTipoCreditoPorAnio(int anio, int codCentroCosto)
        {
            List<SqlParameter> lParameter = new List<SqlParameter>()
                {
                new SqlParameter("@strAnio", anio),
                new SqlParameter("@strCodCentroCosto", codCentroCosto),
                };

            List<dynamic> tipoCreditos = new List<dynamic>();
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_ListarTipoCreditoPorAnio");
            xObjCn.AssignParameters(lParameter);
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                tipoCreditos.Add(new
                {
                    Id_Mes = (int)xIdr[0],
                    Des_Mes = (string)xIdr[1],
                    CreditosAprobados = (int)xIdr[2],
                    MontosAprobados = (decimal)xIdr[3]
                });
            }
            xObjCn.Disconnect();
            return tipoCreditos;
        }

        public List<dynamic> ListarSaldoFavorSolicitantes(string desde, string hasta)
        {
            List<SqlParameter> lParameter = new List<SqlParameter>()
                {
                new SqlParameter("@strFechaIni", desde),
                new SqlParameter("@strFechaFin", hasta),
                };

            List<dynamic> saldoFavor = new List<dynamic>();
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_SaldoFavorSolicitantes");
            xObjCn.AssignParameters(lParameter);
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                saldoFavor.Add(new
                {
                    Id_Operacion = (decimal)xIdr[0],
                    Dni_Solicitante = (string)xIdr[1],
                    Ser = (string)xIdr[2],
                    Numero = (string)xIdr[3],
                    Apellidos_Nombres = (string)xIdr[4],
                    Fijo = (string)xIdr[5],
                    Movil = (string)xIdr[6],
                    Mail = (string)xIdr[7],
                    Domicilio = (string)xIdr[8],
                    Fecha = (DateTime)xIdr[9],
                    NameProducto = (string)xIdr[10],
                    Corta_TpOperac = (string)xIdr[11],
                    Des_TpOperac = (string)xIdr[12],
                    Aprobado = (decimal)xIdr[13],
                    Plazo = (int)xIdr[14],
                    NumCta = (string)xIdr[15],
                    CCI = (string)xIdr[16],
                    CREDITO = (decimal)xIdr[17],
                    PAGOS = (decimal)xIdr[18],
                    SALDO = (decimal)xIdr[19],
                });
            }
            xObjCn.Disconnect();
            return saldoFavor;
        }

        public List<dynamic> ListarTipoCreditoGeneradoDesembolsado(string desde, string hasta)
        {
            List<SqlParameter> lParameter = new List<SqlParameter>()
                {
                new SqlParameter("@strFechaIni", desde),
                new SqlParameter("@strFechaFin", hasta),
                };

            List<dynamic> generadoDesembolsado = new List<dynamic>();
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_TipoCreditoGeneradoDesembolsado");
            xObjCn.AssignParameters(lParameter);
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                generadoDesembolsado.Add(new
                {
                    Id_Operacion = (decimal)xIdr[0],
                    Dni_Solicitante = (string)xIdr[1],
                    Ser = (string)xIdr[2],
                    Numero = (string)xIdr[3],
                    Apellidos_Nombres = (string)xIdr[4],
                    Fijo = (string)xIdr[5],
                    Movil = (string)xIdr[6],
                    Mail = (string)xIdr[7],
                    Domicilio = (string)xIdr[8],
                    Fecha = (DateTime)xIdr[9],
                    NameProducto = (string)xIdr[10],
                    Corta_TpOperac = (string)xIdr[11],
                    Des_TpOperac = (string)xIdr[12],
                    Aprobado = (decimal)xIdr[13],
                    Plazo = (int)xIdr[14],
                    NumCta = (string)xIdr[15],
                    CCI = (string)xIdr[16],
                    Dpto = (int)xIdr[17],
                    DesDpto = (string)xIdr[18],
                    Prov = (int)xIdr[19],
                    DesProv = (string)xIdr[20],
                    Dist = (int)xIdr[21],
                    DesDist = (string)xIdr[22],
                });
            }
            xObjCn.Disconnect();
            return generadoDesembolsado;
        }

        public List<dynamic> ListarTipoCreditoEnProceso(string desde, string hasta)
        {
            List<SqlParameter> lParameter = new List<SqlParameter>()
                {
                new SqlParameter("@strFechaIni", desde),
                new SqlParameter("@strFechaFin", hasta),
                };

            List<dynamic> creditoEnProceso = new List<dynamic>();
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_TipoCreditoEnProceso");
            xObjCn.AssignParameters(lParameter);
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                creditoEnProceso.Add(new
                {
                    Id_Operacion = (decimal)xIdr[0],
                    Dni_Solicitante = (string)xIdr[1],
                    Ser = (string)xIdr[2],
                    Numero = (string)xIdr[3],
                    Apellidos_Nombres = (string)xIdr[4],
                    Fijo = (string)xIdr[5],
                    Movil = (string)xIdr[6],
                    Mail = (string)xIdr[7],
                    Domicilio = (string)xIdr[8],
                    Fecha = (DateTime)xIdr[9],
                    NameProducto = (string)xIdr[10],
                    Corta_TpOperac = (string)xIdr[11],
                    Des_TpOperac = (string)xIdr[12],
                    Aprobado = (decimal)xIdr[13],
                    Plazo = (int)xIdr[14],
                    NumCta = (string)xIdr[15],
                    CCI = (string)xIdr[16],
                    Dpto = (int)xIdr[17],
                    DesDpto = (string)xIdr[18],
                    Prov = (int)xIdr[19],
                    DesProv = (string)xIdr[20],
                    Dist = (int)xIdr[21],
                    DesDist = (string)xIdr[22],
                });
            }
            xObjCn.Disconnect();
            return creditoEnProceso;
        }
    }
}
