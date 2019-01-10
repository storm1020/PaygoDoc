using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaygoDoc
{
    public class EntradaMAIN : EntradaMODEL
    {
        /// <summary>
        /// Metodo responsável por varrer e preencher uma lista contendo os parametros que compõe uma função da DLL.
        /// </summary>
        /// <returns>ParamentrosDefault, lista de parametros que não representão funções para DLL.</returns>
        public List<string> GetParametrosDefault()
        {
            List<string> retorno = new List<string>();
            foreach (var item in Enum.GetNames(typeof(Default)))
            {
                retorno.Add(item);
            }
            return retorno;
        }

        /// <summary>
        /// Metodo responsável por varrer e preencher uma lista contendo os parametros que são funções para DLL.
        /// </summary>
        /// <returns>ParametrosOper, lista contendo as operações que podem ser utilizadas na DLL.</returns>
        public List<string> GetParametrosOper()
        {
            List<string> retorno = new List<string>();
            foreach (var item in Enum.GetNames(typeof(PWOPER)))
            {
                retorno.Add(item.ToString());
            }
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> GetParametrosComValores()
        {
            List<string> retorno = new List<string>();
            foreach (PWOPER pwoper in Enum.GetValues(typeof(PWOPER)))
            {
                retorno.Add(string.Format("{0} {1}", Convert.ToString((int)pwoper), pwoper.ToString()));
            }
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> GetParametroInfo()
        {
            List<string> retorno = new List<string>();
            foreach (var item in Enum.GetNames(typeof(PWINFO)))
            {
                retorno.Add(item);
            }
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public List<string> GetParametrosComValoresInfo()
        {
            List<string> retorno = new List<string>();
            foreach (PWINFO pwinfo in Enum.GetValues(typeof(PWINFO)))
            {
                retorno.Add(string.Format("{0} {1}", Convert.ToString((int)pwinfo), pwinfo.ToString()));
            }
            return retorno;
        }
        
    }
}
