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

        public static string GetMetodoPorNome (string param)
        {
            List<string> mtds = new List<string>();
            string metodoCorreto = string.Empty;

            foreach (var name in Enum.GetNames(typeof(Metodos)))
            {
                if (name.Contains(param))
                {
                    metodoCorreto = name;
                }
            }

            return metodoCorreto;
        }

        public string MontarMetodo(string param)
        {
            string retorno = string.Empty;
            List<string> EntradaDefault = new List<string>();

            switch (param)
            {
                case "Pw_iInit":
                    EntradaDefault = EntradaMAIN.GetEntradaPorMetodo(param);
                    retorno = string.Format("{0}", param);
                    break;
            }


            return retorno;
        }
    }
}
