using Comun;
using CreditsModel.ModelDto;
using CreditsRepository.IRepository;
using CreditsRepository.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditsController.Controller
{
    public class CreditsAccessController
    {
        private readonly ICreditsAccessRepository _iCreditAccessRepository;

        public CreditsAccessController()
        {
            this._iCreditAccessRepository = new CreditsAccessRepository();
        }
        public CreditsAccessDto EsUsuarioValido(CreditsAccessDto pObj)
        {
            CreditsAccessDto iUsuEN = new CreditsAccessDto();

            //si no hay codigousuario entonces es true
            if (pObj.Dni_Acceso == string.Empty)
            {
                iUsuEN.Additionals.EsVerdad = true;
                iUsuEN.Additionals.Mensaje = "";
                return iUsuEN;
            }

            //aqui CodigoUsuario no esta vacio
            iUsuEN = this._iCreditAccessRepository.BuscarUsuarioXCodigo(pObj);
            if (iUsuEN.Dni_Acceso == string.Empty)
            {
                iUsuEN.Additionals.EsVerdad = false;
                iUsuEN.Additionals.Mensaje = "No existe usuario con este codigo : " + Cadena.Espacios(1) + pObj.Dni_Acceso;
                return iUsuEN;
            }
            else
            {
                if (iUsuEN.Sit_Acceso == 0) //desactivado
                {
                    iUsuEN = CreditsAccessController.EnBlanco();
                    iUsuEN.Additionals.EsVerdad = false;
                    iUsuEN.Additionals.Mensaje = "El usuario" + Cadena.Espacios(1) + pObj.Dni_Acceso + Cadena.Espacios(1) + "esta desactivado";
                    return iUsuEN;
                }
            }
            iUsuEN.Additionals.EsVerdad = true;
            return iUsuEN;
        }
        public CreditsAccessDto EsContrasenaDeUsuario(CreditsAccessDto pObj)
        {
            CreditsAccessDto iUsuEN = new CreditsAccessDto();

            //si no se digito contraseña entonces es true
            if (pObj.Pass_Acceso == string.Empty)
            {
                iUsuEN.Additionals.EsVerdad = true;
                iUsuEN.Additionals.Mensaje = string.Empty;
                return iUsuEN;
            }

            //si CodigoUsuario no esta vacio y clave tampoco
            string xClave = pObj.Pass_Acceso;
            iUsuEN = this._iCreditAccessRepository.BuscarUsuarioXCodigo(pObj);
            if (iUsuEN.Pass_Acceso.Trim() == xClave)
            {
                iUsuEN.Additionals.EsVerdad = true;
                iUsuEN.Additionals.Mensaje = string.Empty;
                return iUsuEN;
            }
            else
            {
                iUsuEN.Additionals.EsVerdad = false;
                iUsuEN.Additionals.Mensaje = "La clave es Incorrecta";
                return iUsuEN;
            }

        }
        public static CreditsAccessDto EnBlanco()
        {
            CreditsAccessDto iUsuEN = new CreditsAccessDto();
            return iUsuEN;
        }
    }
}
