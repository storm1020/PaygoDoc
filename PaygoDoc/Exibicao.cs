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
        public List<string> NomeMetodo { get; set; }
        public List<string> EntradaMetodo { get; set; }
        public string DescricaoMetodo { get; set; }
        public List<string> ExemploMetodo { get; set; }

        public Exibicao() { }

        public Exibicao(List<string> nmmtd, List<string> etdmtd, string ds, List<string> exmtd)
        {
            this.NomeMetodo = nmmtd;
            this.EntradaMetodo = etdmtd;
            this.DescricaoMetodo = ds;
            this.ExemploMetodo = exmtd;
        }

        public string GetAll ()
        {
            return NomeMetodo + "," + EntradaMetodo + "," +  DescricaoMetodo + "," + ExemploMetodo;
        }

        public string GetNomeMetodo()
        {
            return NomeMetodo.ToString();
        }

        public List<string> GetEntradaMetodo()
        {
            return EntradaMetodo;
        }

        public string GetDescricaoMetodo()
        {
            return DescricaoMetodo;
        }

        public List<string> GetExemploMetodo()
        {
            return ExemploMetodo;
        }

        public void SetAll(List<string> nm, List<string> etd, string ds, List<string> ex)
        {
            this.NomeMetodo = nm;
            this.EntradaMetodo = etd;
            this.DescricaoMetodo = ds;
            this.ExemploMetodo = ex;
        }

        public void SetNomeMetodo(List<string> nmmtd)
        {
            this.NomeMetodo = nmmtd;
        }

        public void SetEntradaMetodo(List<string> etdMetodo)
        {
            this.EntradaMetodo = etdMetodo;
        }

        public void SetDescricaoMetodo(string dsc)
        {
            this.DescricaoMetodo = dsc;
        }

        public void SetExemploMetodo(List<string> exmtd)
        {
            this.EntradaMetodo = exmtd;
        }

        public Exibicao MontarExibicao(Exibicao objExibicao)
        {
            Exibicao obj = objExibicao;

            foreach (var nome in obj.GetNomeMetodo())
            {
                string nm = nome.ToString();
                switch (nm)
                {
                    case "PW_iInit":

                        break;
                }
            }



            return objExibicao;
        }
    }
}
