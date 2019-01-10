using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaygoDoc
{
    public class RetornoMAIN : RetornoMODEL
    {
        public List<string> Retornos { get; set; }
        public Dictionary<int, string> RetornoComValor { get; set; }

        /// <summary>
        /// Metodo responsável por preencher uma lista de string com os retornos que são operações para DLL.
        /// </summary>
        /// <returns>Retornos, lista de string contendo todos os parametros que são operações para DLL</returns>
        public List<string> GetRetornos()
        {
            foreach (var item in Enum.GetNames(typeof(PWRET)))
            {
                this.Retornos.Add(item);
            }

            return Retornos;
        }

        /// <summary>
        /// Metodo responsável por preencher e retornar um dictionary contendo os indices e valores de um enum de operações da DLL.
        /// </summary>
        /// <returns>RetornoComValor, dictonary contendo valor e nome dos dados do enum PWRET.</returns>
        public Dictionary<int, string> GetRetornosComValores()
        {
            foreach (var value in Enum.GetValues(typeof(PWRET)))
            {
                foreach (var name in Enum.GetNames(typeof(PWRET)))
                {
                    this.RetornoComValor.Add((int)value, name);
                }
            }

            return RetornoComValor;
        }
    }
}
