using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditsUtil.Util
{
    public class UtilFechas
    {
        public List<string> Mes()
        {
            List<string> list = new List<string>();
            string[,] arrayMes = {
                {"01", "Enero" },
                {"02", "Febrero" },
                {"03","Marzo" },
                {"04","Abril"},
                {"05","Mayo"},
                {"06","Junio"},
                {"07","Julio"},
                {"08","Agosto"},
                {"09","Septiembre"},
                {"10","Octubre"},
                {"11","Noviembre"},
                {"12","Diciembre"}
            };
            foreach (string mes in arrayMes)
            {
                list.Add(mes);
            }
            return list;
        }
    }
}
