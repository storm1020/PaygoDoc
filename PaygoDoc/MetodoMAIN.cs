using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PaygoDoc.EntradaMAIN;

namespace PaygoDoc
{
    public class MetodoMAIN : MetodosMODEL
    {
        /// <summary>
        /// GetAll para popular o menu windowsform.
        /// </summary>
        /// <returns></returns>
        public static List<string> GetAllMetodos()
        {
            List<string> retorno = new List<string>();
            foreach (var item in Enum.GetNames(typeof(Metodos)))
            {
                retorno.Add(item);
            }
            return retorno;
        }

        public static string GetMetodoPorEscolha(string escolha)
        {
            string ret = string.Empty;

            foreach (var item in Enum.GetValues(typeof(Metodos)))
            {
                if (escolha.Contains(item.ToString()))
                {
                    ret = item.ToString();
                }
            }
            return ret;
        }
    }
}
