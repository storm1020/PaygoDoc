using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PaygoDoc.DescricaoMAIN;
using static PaygoDoc.EntradaMAIN;
using static PaygoDoc.RetornoMAIN;
using static PaygoDoc.MetodoMAIN;

namespace PaygoDoc
{
    public class Exibicao
    {
        public string NomeMetodo { get; set; }
        public string[] EntradaMetodo { get; set; }
        public string DescricaoMetodo { get; set; }
        public string[] ExemploMetodo { get; set; }

        public string GetAll ()
        {
            string formato = string.Format("{0}, {1}, {2}, {3}", "Nome:" + NomeMetodo,  "Entrada(s):" + EntradaMetodo, "Descrição:" + DescricaoMetodo, "Exemplo(s): " + ExemploMetodo);
            formato = string.Join(",", formato);

            return formato;
        }

        public void SetAll(string nm, string[] etd, string ds, string ex)
        {
            this.NomeMetodo = nm;
            this.EntradaMetodo = etd;
            this.DescricaoMetodo = ds;
            this.ExemploMetodo[] = ex;
        }
    }
}
