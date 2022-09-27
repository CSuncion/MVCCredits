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

        public List<dynamic> ListarCreditoEnProceso(string desde, string hasta)
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
        public List<dynamic> ListarCreditoMorosos(string hasta)
        {
            List<SqlParameter> lParameter = new List<SqlParameter>()
                {
                new SqlParameter("@strFechaFin", hasta),
                };

            List<dynamic> creditoMorosos = new List<dynamic>();
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_CreditoMorosos");
            xObjCn.AssignParameters(lParameter);
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                creditoMorosos.Add(new
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
                    CREDITO = (decimal)xIdr[15],
                    PAGOS = (decimal)xIdr[16],
                    Ret_Fecha = (DateTime)xIdr[17],
                    Cuota = (int)xIdr[18],
                    Pendiente = (decimal)xIdr[19],
                });
            }
            xObjCn.Disconnect();
            return creditoMorosos;
        }
        public List<dynamic> ListarOperacionesRefinanciamientoAmpliacion(CreditsOperationsDto oCreOpe)
        {
            List<SqlParameter> lParameter = new List<SqlParameter>()
                {
                new SqlParameter("@strDniSolicitante", oCreOpe.Dni_Solicitante.Trim()),
                new SqlParameter("@strIdOperacion", oCreOpe.Id_Operacion),
                };

            List<dynamic> creditoRefAmp = new List<dynamic>();
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_ListarOperacionesRefinanciamientoAmpliacion");
            xObjCn.AssignParameters(lParameter);
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                creditoRefAmp.Add(new
                {
                    Operacion = (string)xIdr[0],
                    NameProducto = (string)xIdr[1],
                    Fecha = (DateTime)xIdr[2],
                    Aprobado = (decimal)xIdr[3],
                    Importe = (decimal)xIdr[4],
                    Amortizacion = (decimal)xIdr[5],
                    Interes = (decimal)xIdr[6],
                    Seguro = (decimal)xIdr[7],
                    Gastos = (decimal)xIdr[8],
                    Igv = (decimal)xIdr[9],
                    Comision1 = (decimal)xIdr[10],
                    Comision2 = (decimal)xIdr[11],
                    Total = (decimal)xIdr[12],
                    Ret_Fecha = (DateTime)xIdr[13],
                    DesSubEstado = (string)xIdr[14],
                    Operacion2 = (string)xIdr[15],
                });
            }
            xObjCn.Disconnect();
            return creditoRefAmp;
        }

        public List<dynamic> ListarComparativoCreditoOtorgados()
        {
            List<dynamic> comparativoCreditosOtorgados = new List<dynamic>();
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_ComparativoCreditoOtorgados");
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                comparativoCreditosOtorgados.Add(new
                {
                    ANIOCinco = (int)xIdr[0],
                    MESCinco = (int)xIdr[1],
                    DESMESCinco = (string)xIdr[2],
                    CANTIDCinco = (int)xIdr[3],
                    MONTOCinco = (decimal)xIdr[4],
                    ANIOCuatro = (int)xIdr[5],
                    MESCuatro = (int)xIdr[6],
                    DESMESCuatro = (string)xIdr[7],
                    CANTIDCuatro = (int)xIdr[8],
                    MONTOCuatro = (decimal)xIdr[9],
                    ANIOTres = (int)xIdr[10],
                    MESTres = (int)xIdr[11],
                    DESMESTres = (string)xIdr[12],
                    CANTIDTres = (int)xIdr[13],
                    MONTOTres = (decimal)xIdr[14],
                    ANIODos = (int)xIdr[15],
                    MESDos = (int)xIdr[16],
                    DESMESDos = (string)xIdr[17],
                    CANTIDDos = (int)xIdr[18],
                    MONTODos = (decimal)xIdr[19],
                    ANIOUno = (int)xIdr[20],
                    MESUno = (int)xIdr[21],
                    DESMESUno = (string)xIdr[22],
                    CANTIDUno = (int)xIdr[23],
                    MONTOUno = (decimal)xIdr[24]
                });
            }
            xObjCn.Disconnect();
            return comparativoCreditosOtorgados;
        }
        public decimal ListarConsultaNoAdeudo(string dni)
        {
            List<SqlParameter> lParameter = new List<SqlParameter>()
                {
                new SqlParameter("@strDniSolicitante", dni),
                };

            decimal saldo = 0;
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_ConsultaNoAdeudo");
            xObjCn.AssignParameters(lParameter);
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                saldo = (decimal)xIdr[0];
            }
            xObjCn.Disconnect();
            return saldo;
        }

        public string GenerarCorrelativoConstanciaNoAdeudo(string periodo)
        {
            List<SqlParameter> lParameter = new List<SqlParameter>()
                {
                new SqlParameter("@strPeriodo", periodo),
                };

            string Correlativo = "";
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_GenerarCorrelativoConstanciaNoAdeudo");
            xObjCn.AssignParameters(lParameter);
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                Correlativo = (string)xIdr[0];
            }
            xObjCn.Disconnect();
            return Correlativo;
        }

        public int ValidaImpresionCorrelativoConstanciaNoAdeudo(string dni)
        {
            List<SqlParameter> lParameter = new List<SqlParameter>()
                {
                new SqlParameter("@strDniSolicitante", dni),
                };

            int Result = 0;
            xObjCn.Connection();
            xObjCn.CommandStoreProcedure("isp_ValidaImpresionCorrelativoConstanciaNoAdeudo");
            xObjCn.AssignParameters(lParameter);
            IDataReader xIdr = xObjCn.GetIdr();
            while (xIdr.Read())
            {
                Result = (int)xIdr[0];
            }
            xObjCn.Disconnect();
            return Result;
        }
    }
}
