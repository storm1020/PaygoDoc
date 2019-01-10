using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaygoDoc
{
    public class Exibicao : MetodosMODEL
    {
        public string Nome { get; set; }
        public string Entrada { get; set; }
        public string Retorno { get; set; }
        public string Exemplo { get; set; }
        public string Descricao { get; set; }

        public Exibicao() { }

        public Exibicao(string nm, string etd, string rtn, string ex, string ds)
        {
            this.Nome = nm;
            this.Entrada = etd;
            this.Retorno = rtn;
            this.Exemplo = ex;
            this.Descricao = ds;
        }

        public string GetAll()
        {
            return "Nome: " + Nome + "\n" +
                   "Entrada: " + Entrada + "\n" +
                   "Retorno: " + Retorno + "\n" +
                   "Exemplo: " + Exemplo + "\n" +
                   "Descricao: " + Descricao;
        }

        public void SetAll(string nm, string etd, string rtn, string ex, string ds)
        {
            this.Nome = nm;
            this.Entrada = etd;
            this.Retorno = rtn;
            this.Exemplo = ex;
            this.Descricao = ds;
        }



        public string ExibeMetodo (string param)
        {
            string retorno = string.Empty;
            Exibicao ex;
            try
            {
                switch (param)
                {
                    case "PW_iInit":
                        ex = new Exibicao("PW_iInit",
                                          "string pszWorkingDir (Diretório de trabalho, caminho completo, com final nulo para uso exclusivo do PayGo Web)",
                                          "Impletentar: short / Utilizar: int16 ou int32",
                                          "int ret = Interop.PW_iInit(Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + \\PGWebLib\\)",
                                          "Esta função é utilizada para inicializar a biblioteca, e retorna imediatamente. Deve ser garantido que uma chamada dela retorne PWRET_OK antes de chamar qualquer outra função."
                                          );
                        retorno = ex.GetAll();
                        break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro ao exibir o item: {0}", e);
            }
            return retorno;
        }
    }
}
