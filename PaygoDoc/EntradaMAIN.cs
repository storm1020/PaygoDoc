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
        /// Lista de parametros que não são operações.
        /// </summary>
        public List<string> ParamentrosDefault { get; set; }
        /// <summary>
        /// Lista de parametros que são operações.
        /// </summary>
        public List<string> ParametrosOper { get; set; }

        /// <summary>
        /// Metodo responsável por varrer e preencher uma lista contendo os parametros que compõe uma função da DLL.
        /// </summary>
        /// <returns>ParamentrosDefault, lista de parametros que não representão funções para DLL.</returns>
        public List<string> GetParametrosDefault()
        {
            foreach (var item in Enum.GetNames(typeof(Default)))
            {
                ParamentrosDefault.Add(item);
            }
            return ParamentrosDefault;
        }
        /// <summary>
        /// Metodo responsável por varrer e preencher uma lista contendo os parametros que são funções para DLL.
        /// </summary>
        /// <returns>ParametrosOper, lista contendo as operações que podem ser utilizadas na DLL.</returns>
        public List<string> GetParametrosOper()
        {
            foreach (var item in Enum.GetNames(typeof(PWOPER)))
            {
                ParametrosOper.Add(item);
            }

            return ParametrosOper;
        }
    }
}
