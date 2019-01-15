using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static PaygoDoc.EntradaMODEL;

namespace PaygoDoc
{
    public class DescricaoMAIN
    {
        public static List<string> GetAllPwinfo()
        {
            List<string> retorno = new List<string>();
            foreach (var item in DescriptionAttribute.GetCustomAttributes(typeof(PWINFO)))
            {
                retorno.Add(item.ToString());
            }
            return retorno;
        }

        public static List<string> GetAllPwOper()
        {
            List<string> retorno = new List<string>();
            foreach (var item in DescriptionAttribute.GetCustomAttributes(typeof(PWOPER)))
            {
                retorno.Add(item.ToString());
            }
            return retorno;
        }

        public static List<string> GetAllDefault()
        {
            List<string> retorno = new List<string>();
            foreach (var item in DescriptionAttribute.GetCustomAttributes(typeof(Default)))
            {
                retorno.Add(item.ToString());
            }
            return retorno;
        }
    }
}
