using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaygoDoc
{
    public class MetodosMODEL
    {
        public string PW_iInit { get; set; }
        public string PW_iNewTransac { get; set; }
        public string PW_iAddParam { get; set; }
        public string PW_iExecTransac { get; set; }
        public string PW_iGetResult { get; set; }
        public string PW_iConfirmation { get; set; }
        public string PW_iIdleProc { get; set; }
        public string PW_iGetOperations { get; set; }
        public string PW_iPPEventLoop { get; set; }
        public string PW_iPPAbort { get; set; }
        public string PW_iPPGetCard { get; set; }
        public string PW_iPPGetPIN { get; set; }
        public string PW_iPPGetData { get; set; }
        public string PW_iPPGoOnChip { get; set; }
        public string PW_iPPFinishChip { get; set; }
        public string PW_iPPConfirmData { get; set; }
        public string PW_iPPGenericCMD { get; set; }
        public string PW_iPPDataConfirmation { get; set; }
        public string PW_iPPDisplay { get; set; }
        public string PW_iPPWaitEvent { get; set; }
        public string PW_iPPRemoveCard { get; set; }
        public string PW_iTransactionInquiry { get; set; }

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

        public static string RetornaNomeDoMetodo(int indice)
        {
            string retorno = string.Empty;

            retorno = Convert.ToString(Enum.GetName(typeof(Metodos), indice));

            //foreach (var item in Enum.GetValues(typeof(Metodos)))
            //{
                
            //}

            return retorno;
        }
    }
}
