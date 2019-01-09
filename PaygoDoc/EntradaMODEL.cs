using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaygoDoc
{
    public class EntradaMODEL
    {
        public struct Operacao
        {
            public string PWOPER_NULL { get; set; }
            public string PWOPER_INSTALL { get; set; }
            public string PWOPER_PARAMUPD { get; set; }
            public string PWOPER_REPRINT { get; set; }
            public string PWOPER_RPTTRUNC { get; set; }
            public string PWOPER_RPTDETAIL { get; set; }
            public string PWOPER_ADMIN { get; set; }
            public string PWOPER_SALE { get; set; }
            public string PWOPER_SALEVOID { get; set; }
            public string PWOPER_PREPAID { get; set; }
            public string PWOPER_CHECKINQ { get; set; }
            public string PWOPER_RETBALINQ { get; set; }
            public string PWOPER_CRDBALINQ { get; set; }
            public string PWOPER_INITIALIZ { get; set; }
            public string PWOPER_SETTLEMNT { get; set; }
            public string PWOPER_PREAUTH { get; set; }
            public string PWOPER_PREAUTVOID { get; set; }
            public string PWOPER_CASHWDRWL { get; set; }
            public string PWOPER_LOCALMAINT { get; set; }
            public string PWOPER_FINANCINQ { get; set; }
            public string PWOPER_ADDRVERIF { get; set; }
            public string PWOPER_SALEPRE { get; set; }
            public string PWOPER_LOYCREDIT { get; set; }
            public string PWOPER_LOYCREDVOID { get; set; }
            public string PWOPER_LOYDEBIT { get; set; }
            public string PWOPER_LOYDEBVOID { get; set; }
            public string PWOPER_VOID { get; set; }
            public string PWOPER_VERSION { get; set; }
            public string PWOPER_CONFIG { get; set; }
            public string PWOPER_MAINTENANCE { get; set; }
        }

        public struct EntradaDefault
        {
            public string pszWorkingDir { get; set; }
        }

        /// <summary>
        /// Operações que podem ser passadas para a DLL dentro de um método.
        /// </summary>
        public enum PWOPER : int
        {
            /// <summary>
            /// Testa comunicação com a infraestrutura do PayGo Web.
            /// </summary>
            PWOPER_NULL = 0,

            /// <summary>
            /// Registra o Ponto de captura perante a infraestrutura do PayGo Web, para que seja autorizado realizar a trnasação.
            /// </summary>
            PWOPER_INSTALL = 1,

            /// <summary>
            /// Obtém da infraestrutura do Paygo Web os parâmetros de operação atualizados do Ponto de captura.
            /// </summary>
            PWOPER_PARAMUPD = 2,

            /// <summary>
            /// Obtém o último comprovante gerado por uma transação.
            /// </summary>
            PWOPER_REPRINT = 16,

            /// <summary>
            /// Obtém um relatório sintético das transações realizadas desde a última obtenção deste relatório.
            /// </summary>
            PWOPER_RPTTRUNC = 17,

            /// <summary>
            /// Relatório detalhado das transações realizadas na data informada, ou data atual.
            /// </summary>
            PWOPER_RPTDETAIL = 18,

            /// <summary>
            /// Acessa qualquer transação que não seja disponibilizada pelo Comando PWOPER_SALE. É apresentado um menu para o operador selecionar a transação desejada.
            /// </summary>
            PWOPER_ADMIN = 32,

            /// <summary>
            /// (VENDA) Realiza o pagamento de mercadorias e/ou serviços vendidos pelo Estabelecimento ao Cliente. (débito/crédito), transferindo fundos entre as respectivas contas.
            /// </summary>
            PWOPER_SALE = 33,

            /// <summary>
            /// Cancelamento de venda.
            /// </summary>
            PWOPER_SALEVOID = 34,

            /// <summary>
            /// Realiza aquisição de créditos pré-pagos(ex: recarga de celular).
            /// </summary>
            PWOPER_PREPAID = 35,

            /// <summary>
            /// Consulta a validade de um cheque papel.
            /// </summary>
            PWOPER_CHECKINQ = 36,

            /// <summary>
            /// Consulta saldo/limite do Estabelecimento(limite de crédito).
            /// </summary>
            PWOPER_RETBALINQ = 37,

            /// <summary>
            /// Consulta o saldo do cartão do Cliente
            /// </summary>
            PWOPER_CRDBALINQ = 38,

            /// <summary>
            /// Inicializa a operação junto ao provedor, e, ou obtém e atualiza os parâmetros de operação mantidos por este.
            /// </summary>
            PWOPER_INITIALIZ = 39,

            /// <summary>
            /// Finaliza operação junto ao Provedor.
            /// </summary>
            PWOPER_SETTLEMNT = 40,

            /// <summary>
            /// Reserva uma venda no limite do cartão do cliente, porém sem efetivar a venda.
            /// </summary>
            PWOPER_PREAUTH = 41,

            /// <summary>
            /// Cancelamento de pré-autorização
            /// </summary>
            PWOPER_PREAUTVOID = 42,

            /// <summary>
            /// (Saque) Registra a retirada de um valor em espeécie pelo Cliente no estabelecimento para transferência de fundo nas respectivas contas.
            /// </summary>
            PWOPER_CASHWDRWL = 43,

            /// <summary>
            /// (Baixa técnica) Registra uma intervenção técnica no estabelecimento perante o Provedor.
            /// </summary>
            PWOPER_LOCALMAINT = 44,

            /// <summary>
            /// Consulta taxas de financimento referentes a uma possível venda parcelada, sem efetivar a transferência de fundos ou impactar o limite de crédito do Cliente.
            /// </summary>
            PWOPER_FINANCINQ = 45,

            /// <summary>
            /// Verifica o endereço do Cliente (Utiliza o Provedor para tal).
            /// </summary>
            PWOPER_ADDRVERIF = 46,

            /// <summary>
            /// Efetiva pré-autorização, previamente realizada, efetuando uma transferência de fundos entre as contas do Estabelecimento e do Cliente.
            /// </summary>
            PWOPER_SALEPRE = 47,

            /// <summary>
            /// Registra o acúmulo de pontos pelo Cliente, a partir de um programa de fidelidade.
            /// </summary>
            PWOPER_LOYCREDIT = 48,

            /// <summary>
            /// Cancela uma transação PWOPER_LOYDEBIT.
            /// </summary>
            PWOPER_LOYCREDVOID = 49,

            /// <summary>
            /// Registra pontos do Cliente (programa de fidelidade).
            /// </summary>
            PWOPER_LOYDEBIT = 50,

            /// <summary>
            /// Cancela uma transação LOYDEBIT
            /// </summary>
            PWOPER_LOYDEBVOID = 51,

            /// <summary>
            /// Exibe um menu com os cancelamentos disponíveis, caso só exista um tipo, este é seleiconado automaticamente.
            /// </summary>
            PWOPER_VOID = 39,

            /// <summary>
            /// Permite consultar a versão da biblioteca atualmente em uso.
            /// </summary>
            PWOPER_VERSION = 252,

            /// <summary>
            /// (configuração), Visualiza e altera os parâmetros de operação locais da biblioteca.
            /// </summary>
            PWOPER_CONFIG = 253,

            /// <summary>
            /// Manutenção, apaga todas as configurações do Ponto de captura, devendo ser novamente realizada uma transação de instalaçao.
            /// </summary>
            PWOPER_MAINTENANCE = 254
        }

    }
}
