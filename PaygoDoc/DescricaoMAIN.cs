﻿using System;
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
        public static string GetDescricaoEnum(List<string> nomeDeEntradas)
        {
            foreach (var item in nomeDeEntradas)
            {
                if (!string.IsNullOrWhiteSpace(item.ToString()))
                {
                    
                }
            }

            var val = PWINFO.PWINFO_AUTCAP;
            var desc = "None";

            var field = val.GetType()
                        .GetField(val.ToString());

            var attr = field.GetCustomAttributes(
                typeof(DescriptionAttribute),
                false
                );

            if (attr.Length > 0)
            {
                var da =
                    attr[0] as DescriptionAttribute;

                desc = da.Description;
            }

            return desc;
        }

        public static List<string> GetAllDescricoesEnum()
        {
            var desc = "None";
            List<string> retorno = new List<string>();

            foreach (var val in Enum.GetValues(typeof(PWINFO)))
            {
                var campo = val.GetType()
                            .GetField(val.ToString());

                var attr = campo.GetCustomAttributes(
                    typeof(DescriptionAttribute),
                    false
                    );

                if (attr.Length > 0)
                {
                    var da =
                        attr[0] as DescriptionAttribute;

                    desc = da.Description;
                }

                retorno.Add(desc);
            }

            return retorno;
        }
    }
}
