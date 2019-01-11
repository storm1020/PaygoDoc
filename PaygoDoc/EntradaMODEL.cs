using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PaygoDoc
{
    public class EntradaMODEL
    {
        public enum Default : int
        {
            [Description("Diretório de trabalho (caminho completo, com final nulo) para uso exclusivo do Pay&Go Web.")]
            pszWorkingDir = 0
        }

        public enum PWOPER : int
        {
            /// <summary>
            /// Testa comunicação com a infraestrutura do PayGo Web.
            /// </summary>
            [Description("Valor: 00h, Testa comunicação com a infraestrutura do Pay&Go Web.")]
            PWOPER_NULL = 0,

            /// <summary>
            /// Registra o Ponto de captura perante a infraestrutura do PayGo Web, para que seja autorizado realizar a trnasação.
            /// </summary>
            [Description("Valor: 01h, Registra o Ponto de Captura perante a infraestrutura do Pay&Go Web, para que seja autorizado a realizar transações.")]
            PWOPER_INSTALL = 1,

            /// <summary>
            /// Obtém da infraestrutura do Paygo Web os parâmetros de operação atualizados do Ponto de captura.
            /// </summary>
            [Description()]
            PWOPER_PARAMUPD = 2,

            /// <summary>
            /// Obtém o último comprovante gerado por uma transação.
            /// </summary>
            [Description()]
            PWOPER_REPRINT = 16,

            /// <summary>
            /// Obtém um relatório sintético das transações realizadas desde a última obtenção deste relatório.
            /// </summary>
            [Description()]
            PWOPER_RPTTRUNC = 17,

            /// <summary>
            /// Relatório detalhado das transações realizadas na data informada, ou data atual.
            /// </summary>
            [Description()]
            PWOPER_RPTDETAIL = 18,

            /// <summary>
            /// Acessa qualquer transação que não seja disponibilizada pelo Comando PWOPER_SALE. É apresentado um menu para o operador selecionar a transação desejada.
            /// </summary>
            [Description()]
            PWOPER_ADMIN = 32,

            /// <summary>
            /// (VENDA) Realiza o pagamento de mercadorias e/ou serviços vendidos pelo Estabelecimento ao Cliente. (débito/crédito), transferindo fundos entre as respectivas contas.
            /// </summary>
            [Description()]
            PWOPER_SALE = 33,

            /// <summary>
            /// Cancelamento de venda.
            /// </summary>
            [Description()]
            PWOPER_SALEVOID = 34,

            /// <summary>
            /// Realiza aquisição de créditos pré-pagos(ex: recarga de celular).
            /// </summary>
            [Description()]
            PWOPER_PREPAID = 35,

            /// <summary>
            /// Consulta a validade de um cheque papel.
            /// </summary>
            [Description()]
            PWOPER_CHECKINQ = 36,

            /// <summary>
            /// Consulta saldo/limite do Estabelecimento(limite de crédito).
            /// </summary>
            [Description()]
            PWOPER_RETBALINQ = 37,

            /// <summary>
            /// Consulta o saldo do cartão do Cliente
            /// </summary>
            [Description()]
            PWOPER_CRDBALINQ = 38,

            /// <summary>
            /// Inicializa a operação junto ao provedor, e, ou obtém e atualiza os parâmetros de operação mantidos por este.
            /// </summary>
            [Description()]
            PWOPER_INITIALIZ = 39,

            /// <summary>
            /// Finaliza operação junto ao Provedor.
            /// </summary>
            [Description()]
            PWOPER_SETTLEMNT = 40,

            /// <summary>
            /// Reserva uma venda no limite do cartão do cliente, porém sem efetivar a venda.
            /// </summary>
            [Description()]
            PWOPER_PREAUTH = 41,

            /// <summary>
            /// Cancelamento de pré-autorização
            /// </summary>
            [Description()]
            PWOPER_PREAUTVOID = 42,

            /// <summary>
            /// (Saque) Registra a retirada de um valor em espeécie pelo Cliente no estabelecimento para transferência de fundo nas respectivas contas.
            /// </summary>
            [Description()]
            PWOPER_CASHWDRWL = 43,

            /// <summary>
            /// (Baixa técnica) Registra uma intervenção técnica no estabelecimento perante o Provedor.
            /// </summary>
            [Description()]
            PWOPER_LOCALMAINT = 44,

            /// <summary>
            /// Consulta taxas de financimento referentes a uma possível venda parcelada, sem efetivar a transferência de fundos ou impactar o limite de crédito do Cliente.
            /// </summary>
            [Description()]
            PWOPER_FINANCINQ = 45,

            /// <summary>
            /// Verifica o endereço do Cliente (Utiliza o Provedor para tal).
            /// </summary>
            [Description()]
            PWOPER_ADDRVERIF = 46,

            /// <summary>
            /// Efetiva pré-autorização, previamente realizada, efetuando uma transferência de fundos entre as contas do Estabelecimento e do Cliente.
            /// </summary>
            [Description()]
            PWOPER_SALEPRE = 47,

            /// <summary>
            /// Registra o acúmulo de pontos pelo Cliente, a partir de um programa de fidelidade.
            /// </summary>
            [Description()]
            PWOPER_LOYCREDIT = 48,

            /// <summary>
            /// Cancela uma transação PWOPER_LOYDEBIT.
            /// </summary>
            [Description()]
            PWOPER_LOYCREDVOID = 49,

            /// <summary>
            /// Registra pontos do Cliente (programa de fidelidade).
            /// </summary>
            [Description()]
            PWOPER_LOYDEBIT = 50,

            /// <summary>
            /// Cancela uma transação LOYDEBIT
            /// </summary>
            [Description()]
            PWOPER_LOYDEBVOID = 51,

            /// <summary>
            /// Exibe um menu com os cancelamentos disponíveis, caso só exista um tipo, este é seleiconado automaticamente.
            /// </summary>
            [Description()]
            PWOPER_VOID = 39,

            /// <summary>
            /// Permite consultar a versão da biblioteca atualmente em uso.
            /// </summary>
            [Description()]
            PWOPER_VERSION = 252,

            /// <summary>
            /// (configuração), Visualiza e altera os parâmetros de operação locais da biblioteca.
            /// </summary>
            [Description()]
            PWOPER_CONFIG = 253,

            /// <summary>
            /// Manutenção, apaga todas as configurações do Ponto de captura, devendo ser novamente realizada uma transação de instalaçao.
            /// </summary>
            [Description()]
            PWOPER_MAINTENANCE = 254
        }

        public enum PWINFO : int
        {
            /// <summary>
            /// Preenche (PWOPER_xxx), Consultar os valores possíveis na descrição da função (PW_iNewTransac).
            /// </summary>
            [Description()]
            PWINFO_OPERATION = 2,

            /// <summary>
            /// Identificador do Ponto de Captura.
            /// </summary>
            [Description()]
            PWINFO_POSID = 17,

            /// <summary>
            /// Nome do aplicativo da Automação Comercial.
            /// </summary>
            [Description()]
            PWINFO_AUTNAME = 21,

            /// <summary>
            /// Versão do aplicativo de Automaçao.
            /// </summary>
            [Description()]
            PWINFO_AUTVER = 22,

            /// <summary>
            /// Empresa desenvolvedor do aplicativo de automação.
            /// </summary>
            [Description()]
            PWINFO_AUTDEV = 23,

            /// <summary>
            /// Endereço TCP/IP para comunicação com a infraestrutura PayGo Web, no formato endereço IP:porta TCP ou nome do servidor:porta TCP
            /// </summary>
            [Description()]
            PWINFO_DESTTCPIP = 27,

            /// <summary>
            ///  CNPJ/CPF do estabelecimento, sem formatação. Se utilizadas mais de um estabecilemento de afiliação campo é usado para selecionar o estabelcimento a ser utilizado para determinada transação. Caso não, um menu para escolha manual com váris estabelecimentos deve ser exibido.
            /// </summary>
            [Description()]
            PWINFO_MERCHCNPJCPF = 28,

            /// <summary>
            /// Capacidade da Automação (SOMA DOS VALORES)
            /// 1: Funcionalidade de troco/saque;
            /// 2: Funcionalidade de desconto;
            /// 4: Valor fixo, sempre incluir;
            /// 8: impressão das vias diferenciadas do comprovante para Cliente/Estabelecimento;
            /// 16:Impressão do cupom reduzido;
            /// 32: Utiliação de saldo total do voucher para abatimento do valor da compra.
            /// </summary>
            [Description()]
            PWINFO_AUTCAP = 36,

            /// <summary>
            /// Valor total da operação.
            /// </summary>
            [Description()]
            PWINFO_TOTAMNT = 37,

            /// <summary>
            /// Moeda (padrão ISO4217, 986 parao real).
            /// </summary>
            [Description()]
            PWINFO_CURRENCY = 38,

            /// <summary>
            /// Expoente da moeda (2 para centavos).
            /// </summary>
            [Description()]
            PWINFO_CURREXP = 39,

            /// <summary>
            /// Identificador do documento fiscal.
            /// </summary>
            [Description()]
            PWINFO_FISCALREF = 40,

            /// <summary>
            /// Tipo de cartão utilizado 
            /// 1: crédito;
            /// 2: débito;
            /// 4: voucher/PAT;
            /// 8: outros
            /// </summary>
            [Description()]
            PWINFO_CARDTYPE = 41,

            /// <summary>
            /// Nome/Tipo do prorduto utilizado, na nomenclatura do provedor.
            /// </summary>
            [Description()]
            PWINFO_PRODUCTNAME = 42,

            /// <summary>
            /// Data e hora local da transação. Formato = AAAAMMDDhhmmss
            /// </summary>
            [Description()]
            PWINFO_DATETIME = 49,

            /// <summary>
            /// Referência local da transação
            /// </summary>
            [Description()]
            PWINFO_REQNUM = 50,

            /// <summary>
            /// Nome do Provedor: "ELAVON"; "FILLIP"; "LIBERCARD"; "RV"; etc..
            /// </summary>
            [Description()]
            PWINFO_AUTHSYST = 53,

            /// <summary>
            /// identificador do Estabelecimento.
            /// </summary>
            [Description()]
            PWINFO_VIRTMERCH = 54,

            /// <summary>
            /// Identificador do estabelecimento para o Provedor.
            /// </summary>
            [Description()]
            PWINFO_AUTMERCHID = 56,

            /// <summary>
            /// Número do telefone, com DDD (10 ou 11 dígitos).
            /// </summary>
            [Description()]
            PWINFO_PHONEFULLNO = 58,

            /// <summary>
            /// Modalidade de financiamento da transação:
            /// 1:à vista;
            /// 2: parcelado pelo emissor,
            /// 4: parcelado pelo estabelcimento;
            /// 8: pré-datado.
            /// </summary>
            [Description()]
            PWINFO_FINTYPE = 59,

            /// <summary>
            /// Quantidade de parcelas.
            /// </summary>
            [Description()]
            PWINFO_INSTALLMENTS = 60,

            /// <summary>
            /// Data de vencimento do pré-datado, ou da primeira parcela Formato "DDMMAA".
            /// </summary>
            [Description()]
            PWINFO_INSTALLMDATE = 61,

            /// <summary>
            /// Identificação do produto utilizado, de acordo com a nomenclatura do Provedor.
            /// </summary>
            [Description()]
            PWINFO_PRODUCTID = 62,

            /// <summary>
            /// Msg descrevendo o resultado final da transação. (independe do sucesso). Interface com o usuário..
            /// </summary>
            [Description()]
            PWINFO_RESULTMSG = 66,

            /// <summary>
            /// Necessidade de confirmação:
            /// 0: não requer confirmação;
            /// 1: requer confirmação.
            /// </summary>
            [Description()]
            PWINFO_CNFREQ = 67,

            /// <summary>
            /// Referência da transação para a infraestrutura Paygo.
            /// </summary>
            [Description()]
            PWINFO_AUTLOCREF = 68,

            /// <summary>
            /// Referê cia da transação para o Provedor.
            /// </summary>
            [Description()]
            PWINFO_AUTEXTREF = 69,

            /// <summary>
            /// Código de autorização.
            /// </summary>
            [Description()]
            PWINFO_AUTHCODE = 70,

            /// <summary>
            /// Cd de resposta da transação.
            /// </summary>
            [Description()]
            PWINFO_AUTRESPCODE = 71,

            /// <summary>
            /// Valor do desconto concedido pelo Provedor, considerando PWINFO_CURREXP já reduzido em PWINFO_TOTAMNT.
            /// </summary>
            [Description()]
            PWINFO_DISCOUNTAMT = 73,

            /// <summary>
            /// Valor do saque/troco.
            /// </summary>
            [Description()]
            PWINFO_CASHBACKAMT = 74,

            /// <summary>
            /// Nome do cartção ou do emissor do cartão.
            /// </summary>
            [Description()]
            PWINFO_CARDNAME = 75,

            /// <summary>
            /// Modalidade da transação. 1: Online; 2: off-line.
            /// </summary>
            [Description()]
            PWINFO_ONOFF = 76,

            /// <summary>
            /// Valor da taxa de embarque, pconsidera valores já inclsusos em outras funções.
            /// </summary>
            [Description()]
            PWINFO_BOARDINGTAX = 77,

            /// <summary>
            /// Valor da taxa de serviço (gorjeta), considera outros valores já inclusos.
            /// </summary>
            [Description()]
            PWINFO_TIPAMOUNT = 78,

            /// <summary>
            /// Valor da entrada para um pagamento parcelado, considera outros valores já inclusos.
            /// </summary>
            [Description()]
            PWINFO_INSTALLM1AMT = 79,

            /// <summary>
            /// Valor da parcela, considerando PWINFO_CURREXP, já incluído em PWINFO_TOTAMNT.
            /// </summary>
            [Description()]
            PWINFO_INSTALLMAMNT = 80,

            /// <summary>
            /// Comprovante para impressão - Via completa. Até 40 colunas, quebras de linha identificadas pelo Caractere 0Dh
            /// </summary>
            [Description()]
            PWINFO_RCPTFULL = 82,

            /// <summary>
            /// Comprovante para impressão - Via diferenciada para o Estabelecimento.
            /// </summary>
            [Description()]
            PWINFO_RCPTMERCH = 83,

            /// <summary>
            /// Via diferenciada para o Cliente.
            /// </summary>
            [Description()]
            PWINFO_RCPTCHOLDER = 84,

            /// <summary>
            /// Cupom reduzido (para o cliente).
            /// </summary>
            [Description()]
            PWINFO_RCPTCHSHORT = 85,

            /// <summary>
            /// Data de transação original. (no caso de um cancelamento ou pré-autorização).
            /// </summary>
            [Description()]
            PWINFO_TRNORIGDATE = 87,

            /// <summary>
            /// NSU da transação original, no caso de um cancelamento ou uma confi de pré-autorização.
            /// </summary>
            [Description()]
            PWINFO_TRNORIGNSU = 88,

            /// <summary>
            /// Valor da transação original, no caso de um cancelamento ou uma confirmaçao de pré-autorização.
            /// </summary>
            [Description()]
            PWINFO_TRNORIGAMNT = 96,

            /// <summary>
            /// Idioma a ser utilizado para a interface com o cliente:
            /// 0: Português;
            /// 1: Inglês;
            /// 2: Espanhol.
            /// </summary>
            [Description()]
            PWINFO_LANGUAGE = 108,

            /// <summary>
            /// Código de autorização da transação original (caso cancel ou pré-auto).
            /// </summary>
            [Description()]
            PWINFO_TRNORIGAUTH = 98,

            /// <summary>
            /// Número da solicitção da transação original, no casol de um cancelm ou pré-autor..
            /// </summary>
            [Description()]
            PWINFO_TRNORIGREQNUM = 114,

            /// <summary>
            /// Hora da transação original, no caso de um canc, ou transac pré.. (HHMMSS).
            /// </summary>
            [Description()]
            PWINFO_TRNORIGTIME = 115,

            /// <summary>
            /// Msg a ser exibida para o operador no terminal no caso da transação ser abortada (cancel ou timeout).
            /// </summary>
            [Description()]
            PWINFO_CNCDSPMSG = 116,

            /// <summary>
            /// Mensagem a ser exibida para o portador no PIN-pad no caso da transação ser abortada (cancelamento ou timeout).s
            /// </summary>
            [Description()]
            PWINFO_CNCPPMSG = 117,

            /// <summary>
            /// Msg a ser exibida caso a operação seja abortada. Modos de entrada do cartão: 1: digitado; 2: tj magnética; 4: chip com contato; 16: fallback de  chip p/tarja; 32: chip sem contato simulando tarja(cliente informa tipo efetivamente utilizado); 64: chip sem contato EMV (cli informa); 256: fallback de tj para digitado.
            /// </summary>
            [Description()]
            PWINFO_CARDENTMODE = 192,

            /// <summary>
            /// número de cartão completo para transação digitada.
            /// </summary>
            [Description()]
            PWINFO_CARDFULLPAN = 193,

            /// <summary>
            /// Dt Vencimento do cartão MMAA
            /// </summary>
            [Description()]
            PWINFO_CARDEXPDATE = 194,

            /// <summary>
            /// Número do cartão truncado ou mascarado.
            /// </summary>
            [Description()]
            PWINFO_CARDPARCPAN = 200,

            /// <summary>
            /// Verificação do portador, soma dos seguintes valores:
            /// 1: assinatura do portador em papel;
            /// 2: Senha verificada off-line;
            /// 4: Senha off-line bloqueada no decorrer desta transação;
            /// 8: Senha verificada online.
            /// </summary>
            [Description()]
            PWINFO_CHOLDVERIF = 207,

            /// <summary>
            /// Mod de entrada do código de barras:
            /// 1: digitado;
            /// 2: lido através de dispositivo eletrônico.
            /// </summary>
            [Description()]
            PWINFO_BARCODENTMODE = 233,

            /// <summary>
            /// Cd de barras completo lido ou digitado.
            /// </summary>
            [Description()]
            PWINFO_BARCODE = 234,

            /// <summary>
            /// Dados adicionais relevantes para automação (#1).
            /// </summary>
            [Description()]
            PWINFO_MERCHADDDATA1 = 240,

            /// <summary>
            /// Dados adicionais relevantes para automação (#2).
            /// </summary>
            [Description()]
            PWINFO_MERCHADDDATA2 = 241,

            /// <summary>
            /// Dados adicionais relevantes para automação (#3).
            /// </summary>
            [Description()]
            PWINFO_MERCHADDDATA3 = 242,

            /// <summary>
            /// Dados adicionais relevantes para automação (#4).
            /// </summary>
            [Description()]
            PWINFO_MERCHADDDATA4 = 243,

            /// <summary>
            /// Indica quais vias de comprovante devem ser impressas:
            /// 0: não há comprovante;
            /// 1: imprimir somente a via do Cliente;
            /// 2: imprimir somente a via do Estabelecimento;
            /// 3: imprimir mabas as vias doCliente e do Estabelecimento.
            /// </summary>
            [Description()]
            PWINFO_RCPTPRN = 244,

            /// <summary>
            /// Identificador do usuário autenticado com a senha do lojista
            /// </summary>
            [Description()]
            PWINFO_AUTHMNGTUSER = 245,

            /// <summary>
            /// Identificador do usuário autenticado com a senha técnica.
            /// </summary>
            [Description()]
            PWINFO_AUTHTECHUSER = 246,

            /// <summary>
            /// Modalidade de pagamento:
            /// 1: cartão;
            /// 2: dinheiro;
            /// 3: cheque.
            /// </summary>
            [Description()]
            PWINFO_PAYMNTTYPE = 7969,

            /// <summary>
            /// Indica se o ponto de captura faz ou nao o uso de PIN-pad.
            /// </summary>
            [Description()]
            PWINFO_USINGPINPAD = 32513,

            /// <summary>
            /// Número da porta serial à qual o PIN-pad está conectado. O Valor 0 indica uma busca automática desta porta.
            /// </summary>
            [Description()]
            PWINFO_PPCOMMPORT = 32514,

            /// <summary>
            /// Próxima data e horário que pw_iIdleProc deve ser chamada pela Automação. AAMMDDHHMMSS
            /// </summary>
            [Description()]
            PWINFO_IDLEPROCTIME = 32516,

            /// <summary>
            /// Nome do provedor para o qual existe uma transação pendente.
            /// </summary>
            [Description()]
            PWINFO_PNDAUTHSYST = 32517,

            /// <summary>
            /// Identificador do estabelecimento para o qual existe uma transação pendente.
            /// </summary>
            [Description()]
            PWINFO_PNDVIRTMERCH = 32518,

            /// <summary>
            /// Referência da transação que está pendente.
            /// </summary>
            [Description()]
            PWINFO_PNDREQNUM = 32519,

            /// <summary>
            /// Referência para infraestrutura Paygo da transação pendente.
            /// </summary>
            [Description()]
            PWINFO_PNDAUTLOCREF = 32520,

            /// <summary>
            /// Referência para o Provedor da transaçsão que está pendente.
            /// </summary>
            [Description()]
            PWINFO_PNDAUTEXTREF = 32521,

            /// <summary>
            /// Texto exibido para um item de menu selecionado pelo usuário.
            /// </summary>
            [Description()]
            PWINFO_LOCALINFO1 = 32522,

            /// <summary>
            /// Indica se oponto de captura possui alguma pendência a ser resolvida com o Paygo. 1: Possui
            /// </summary>
            [Description()]
            PWINFO_SERVERPND = 32523,

            /// <summary>
            /// 
            /// </summary>
            [Description()]
            PWINFO_PPINFO = 0x7F15,

            /// <summary>
            /// Valor devido pelo usuário considerando PWINFO_TOTAMNT e PWINFO_CURREXP.
            /// </summary>
            [Description()]
            PWINFO_DUEAMNT = 0xBF06,

            /// <summary>
            /// Valor total da transação reajustado, este campo será utilizado caso o autorizador, por alguma regra de negócio específica dele, resolva alterar o valor total que foi solictado para atransação.
            /// </summary>
            [Description()]
            PWINFO_READJUSTEDAMNT = 0xBF09
        }
    }
}
