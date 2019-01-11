using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaygoDoc
{
    public class MetodoMAIN : MetodosMODEL
    {
        public static List<string> GetMetodos()
        {
            List<string> retorno = new List<string>();
            foreach (var item in Enum.GetNames(typeof(Metodos)))
            {
                if (!item.Equals("Todos")) retorno.Add(item);
            }
            return retorno;
        }

        public static List<string> GetAllMetodos()
        {
            List<string> retorno = new List<string>();
            foreach (var item in Enum.GetNames(typeof(Metodos)))
            {
                retorno.Add(item);
            }
            return retorno;
        }
    }
}
