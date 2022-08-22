using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditsModel.ModelDto
{
    public class CreditsAccessDto
    {
        private Additional _Additionals = new Additional();
        //campos nombres
        public const string IdAcc = "Id_Acceso";
        public const string NamAcc = "Name_Acceso";
        public const string DniAcc = "Dni_Acceso";
        public const string PassAcc = "Pass_Acceso";
        public const string PatAcc = "Paterno_Acceso";
        public const string MatAcc = "Materno_Acceso";
        public const string NamsAcc = "Names_Acceso";
        public const string MailAcc = "Mail_Acceso";
        public const string DomAcc = "Domicilio_Acceso";
        public const string DptoAcc = "Dpto_Acceso";
        public const string ProvAcc = "Prov_Acceso";
        public const string DistAcc = "Dist_Acceso";
        public const string FijAcc = "Fijo_Acceso";
        public const string MovAcc = "Movil_Acceso";
        public const string LevAcc = "Level_Acceso";
        public const string SitAcc = "Sit_Acceso";
        public const string FecAcc = "Fecha_Acceso";
        public const string Who = "Who_";
        public const string Of1 = "Ofc1";
        public const string Of2 = "Ofc2";
        public const string Of3 = "Ofc3";
        public const string Of4 = "Ofc4";
        public const string CipAcc = "Cip_Acceso";
        public const string CodfinAcc = "Codofin_Acceso";
        public const string GradAcc = "Grado_Acceso";
        public const string xPnp = "Pnp";
        public const string CargAcc = "Cargo_Acceso";

        public int Id_Acceso { get; set; }
        public string Name_Acceso { get; set; }
        public string Dni_Acceso { get; set; }
        public string Pass_Acceso { get; set; }
        public string Paterno_Acceso { get; set; }
        public string Materno_Acceso { get; set; }
        public string Names_Acceso { get; set; }
        public string Mail_Acceso { get; set; }
        public string Domicilio_Acceso { get; set; }
        public Nullable<int> Dpto_Acceso { get; set; }
        public Nullable<int> Prov_Acceso { get; set; }
        public Nullable<int> Dist_Acceso { get; set; }
        public string Fijo_Acceso { get; set; }
        public string Movil_Acceso { get; set; }
        public Nullable<int> Level_Acceso { get; set; }
        public Nullable<int> Sit_Acceso { get; set; }
        public Nullable<System.DateTime> Fecha_Acceso { get; set; }
        public Nullable<int> Who_ { get; set; }
        public Nullable<int> Ofc1 { get; set; }
        public Nullable<int> Ofc2 { get; set; }
        public Nullable<int> Ofc3 { get; set; }
        public Nullable<int> Ofc4 { get; set; }
        public string Cip_Acceso { get; set; }
        public string Codofin_Acceso { get; set; }
        public Nullable<decimal> Grado_Acceso { get; set; }
        public Nullable<int> Pnp { get; set; }
        public string Cargo_Acceso { get; set; }

        public Additional Additionals
        {
            get { return this._Additionals; }
            set { this._Additionals = value; }
        }
    }
}
