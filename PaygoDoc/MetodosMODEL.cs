using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaygoDoc
{
    public class MetodosMODEL : EntradaMODEL
    {
        public string Nome {get;set;}
        public EntradaMODEL Entrada { get; set; }
        public RetornoMODEL Retorno { get; set; }

        public MetodosMODEL() { }

        public MetodosMODEL(string nm, EntradaMODEL etd, RetornoMODEL rt)
        {
            this.Nome = nm;
            this.Entrada = etd;
            this.Retorno = rt;
        }

        public enum Metodos : int
        {
            Todos = 0,
            PW_iInit = 1,
            PW_iNewTransac = 2,
            PW_iAddParam = 3,
            PW_iExecTransac = 4,
            PW_iGetResult = 5,
            PW_iConfirmation = 6,
            PW_iIdleProc = 7,
            PW_iGetOperations = 8,
            PW_iPPEventLoop = 9,
            PW_iPPAbort = 10,
            PW_iPPGetCard = 11,
            PW_iPPGetPIN = 12,
            PW_iPPGetData = 13,
            PW_iPPGoOnChip = 14,
            PW_iPPFinishChip = 15,
            PW_iPPConfirmData = 16,
            PW_iPPGenericCMD = 17,
            PW_iPPDataConfirmation = 18,
            PW_iPPDisplay = 19,
            PW_iPPWaitEvent = 20,
            PW_iPPRemoveCard = 21,
            PW_iTransactionInquiry = 22
        }
    }
}
