using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaygoDoc
{
    public class RetornoMAIN : RetornoMODEL
    {
        /// <summary>
        /// Metodo responsável por preencher uma lista de string com os retornos que são operações para DLL.
        /// </summary>
        /// <returns>Retornos, lista de string contendo todos os parametros que são operações para DLL</returns>
        public static List<string> GetRetornos()
        {
            List<string> retorno = new List<string>();
            foreach (var item in Enum.GetNames(typeof(PWRET)))
            {
                retorno.Add(item);
            }

            return retorno;
        }

        /// <summary>
        /// Metodo responsável por preencher e retornar um dictionary contendo os indices e valores de um enum de operações da DLL.
        /// </summary>
        /// <returns>RetornoComValor, dictonary contendo valor e nome dos dados do enum PWRET.</returns>
        public static Dictionary<int, string> GetRetornosComValores()
        {
            Dictionary<int, string> retorno = new Dictionary<int, string>();
            foreach (var value in Enum.GetValues(typeof(PWRET)))
            {
                foreach (var name in Enum.GetNames(typeof(PWRET)))
                {
                    retorno.Add((int)value, name);
                }
            }

            return retorno;
        }
    }
}
