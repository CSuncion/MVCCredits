using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditsModel.ModelDto
{
    public class CreditsPagosDto
    {
        public decimal Id_Pago { get; set; }
        public decimal IdOperacion { get; set; }
        public int Mes { get; set; }
        public int Anio { get; set; }
        public int Cuota { get; set; }
        public decimal Amortizacion { get; set; }
        public decimal Interes { get; set; }
        public decimal Seguro { get; set; }
        public decimal Gastos { get; set; }
        public decimal Igv { get; set; }
        public decimal Comision1 { get; set; }
        public decimal Comision2 { get; set; }
        public decimal Porcentaje { get; set; }
        public DateTime Env_Fecha { get; set; }
        public DateTime Ret_Fecha { get; set; }
        public decimal Ret_Amortizacion { get; set; }
        public decimal Ret_Interes { get; set; }
        public decimal Ret_Seguro { get; set; }
        public decimal Ret_Gastos { get; set; }
        public decimal Ret_Igv { get; set; }
        public decimal Ret_Comision1 { get; set; }
        public decimal Ret_Comision2 { get; set; }
        public int Fg { get; set; }
        public decimal IdAccesoEnvia { get; set; }
        public decimal IdAccesoCobra { get; set; }
        public decimal Ant_Amortizacion { get; set; }
        public decimal Ant_Interes { get; set; }
        public decimal Ant_Seguro { get; set; }
        public decimal Ant_Gastos { get; set; }
        public decimal Ant_Igv { get; set; }
        public decimal Ant_Comision1 { get; set; }
        public decimal Ant_Comision2 { get; set; }
        public decimal Id_ProcesoPagos { get; set; }
        public CreditsOperationsDto CreditsOperationsDto { get; set; }
    }
}
