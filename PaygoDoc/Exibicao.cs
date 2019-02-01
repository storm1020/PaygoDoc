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
        public List<string> RetornoMetodo { get; set; }
        public List<string> DescricaoMetodo { get; set; }
        public List<string> ExemploMetodo { get; set; }

        public Exibicao() { }

        public Exibicao(List<string> nmmtd, List<string> etdmtd, List<string> ds, List<string> exmtd)
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

        public List<string> GetRetornoMetodo()
        {
            return RetornoMetodo;
        }

        public string GetNomeMetodo()
        {
            return NomeMetodo.ToString();
        }

        public List<string> GetEntradaMetodo()
        {
            return EntradaMetodo;
        }

        public List<string> GetDescricaoMetodo()
        {
            return DescricaoMetodo;
        }

        public List<string> GetExemploMetodo()
        {
            return ExemploMetodo;
        }

        public void SetAll(List<string> nm, List<string> etd, List<string> rtnmtd, List<string> ds, List<string> ex)
        {
            this.NomeMetodo = nm;
            this.EntradaMetodo = etd;
            this.RetornoMetodo = rtnmtd;
            this.DescricaoMetodo = ds;
            this.ExemploMetodo = ex;
        }

        public void SetRetornoMetodo(List<string> rtnmtd)
        {
            this.RetornoMetodo = rtnmtd;
        }

        public void SetNomeMetodo(List<string> nmmtd)
        {
            this.NomeMetodo = nmmtd;
        }

        public void SetEntradaMetodo(List<string> etdMetodo)
        {
            this.EntradaMetodo = etdMetodo;
        }

        public void SetDescricaoMetodo(List<string> descricao)
        {
            this.DescricaoMetodo = descricao;
        }

        public void SetExemploMetodo(List<string> exmtd)
        {
            this.EntradaMetodo = exmtd;
        }

        public Exibicao MontarExibicao(Exibicao objExibicao)
        {
            Exibicao obj = objExibicao;

            foreach (var nome in obj.NomeMetodo)
            {
                string nm = nome.ToString();
                switch (nm)
                {
                    case "PW_iInit":

                        obj.GetNomeMetodo();
                        obj.SetEntradaMetodo(GetEntradaPorMetodo(nm));
                        obj.SetDescricaoMetodo(
                        GetDescricaoEnumPorNomeEntrada(
                                                        GetEntradaMetodo()
                                                        )
                                                        );

                        break;
                }
            }

            return objExibicao;
        }
    }
}
