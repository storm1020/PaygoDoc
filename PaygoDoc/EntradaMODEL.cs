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
            [Description("Valor: 01h, Registra o Ponto de Captura perante a infraestrutura do PayGo Web, para que seja autorizado a realizar transações.")]
            PWOPER_INSTALL = 1,

            /// <summary>
            /// Obtém da infraestrutura do Paygo Web os parâmetros de operação atualizados do Ponto de captura.
            /// </summary>
            [Description("Valor: 02h, Obtém da infraestrutura do Pay&Go Web os parâmetros de operação atualizados do Ponto de Captura.")]
            PWOPER_PARAMUPD = 2,

            /// <summary>
            /// Obtém o último comprovante gerado por uma transação.
            /// </summary>
            [Description("Valor: 10h, Obtém o último comprovante gerado por uma transação.")]
            PWOPER_REPRINT = 16,

            /// <summary>
            /// Obtém um relatório sintético das transações realizadas desde a última obtenção deste relatório.
            /// </summary>
            [Description("Valor: 11h, Obtém um relatório sintético das transações realizadas desde a última obtenção deste relatório.")]
            PWOPER_RPTTRUNC = 17,

            /// <summary>
            /// Relatório detalhado das transações realizadas na data informada, ou data atual.
            /// </summary>
            [Description("Valor: 12h, Relatório detalhado das transações realizadas na data informada, ou data atual.")]
            PWOPER_RPTDETAIL = 18,

            /// <summary>
            /// Acessa qualquer transação que não seja disponibilizada pelo Comando PWOPER_SALE. É apresentado um menu para o operador selecionar a transação desejada.
            /// </summary>
            [Description("Valor: 20h, Acessa qualquer transação que não seja disponibilizada pelo comando PWOPER_SALE. Um menu é apresentado para o operador selecionar a transação desejada.")]
            PWOPER_ADMIN = 32,

            /// <summary>
            /// (VENDA) Realiza o pagamento de mercadorias e/ou serviços vendidos pelo Estabelecimento ao Cliente. (débito/crédito), transferindo fundos entre as respectivas contas.
            /// </summary>
            [Description("Valor: 21h, (Venda) Realiza o pagamento de mercadorias e/ou serviços vendidos pelo Estabelecimento ao Cliente (tipicamente, com cartão de crédito/débito), transferindo fundos entre as respectivas contas.")]
            PWOPER_SALE = 33,

            /// <summary>
            /// Cancelamento de venda.
            /// </summary>
            [Description("Valor: 22h, (Cancelamento de venda) Cancela uma transação PWOPER_SALE, realizando a transferência de fundos inversa.")]
            PWOPER_SALEVOID = 34,

            /// <summary>
            /// Realiza aquisição de créditos pré-pagos(ex: recarga de celular).
            /// </summary>
            [Description("Valor: 23h, Realiza a aquisição de créditos pré-pagos (por exemplo, recarga de celular).")]
            PWOPER_PREPAID = 35,

            /// <summary>
            /// Consulta a validade de um cheque papel.
            /// </summary>
            [Description("Valor: 24h, Consulta a validade de um cheque papel.")]
            PWOPER_CHECKINQ = 36,

            /// <summary>
            /// Consulta saldo/limite do Estabelecimento(limite de crédito).
            /// </summary>
            [Description("Valor: 25h, Consulta o saldo/limite do Estabelecimento (tipicamente, limite de crédito para venda de créditos pré-pagos).")]
            PWOPER_RETBALINQ = 37,

            /// <summary>
            /// Consulta o saldo do cartão do Cliente
            /// </summary>
            [Description("Valor: 26h, Consulta o saldo do cartão do Cliente.")]
            PWOPER_CRDBALINQ = 38,

            /// <summary>
            /// Inicializa a operação junto ao provedor, e, ou obtém e atualiza os parâmetros de operação mantidos por este.
            /// </summary>
            [Description("Valor: 27h, (Inicialização/abertura) Inicializa a operação junto ao Provedor e/ou obtém/atualiza os parâmetros de operação mantidos por este.")]
            PWOPER_INITIALIZ = 39,

            /// <summary>
            /// Finaliza operação junto ao Provedor.
            /// </summary>
            [Description("Valor: 28h, (Fechamento/finalização) Finaliza a operação junto ao Provedor.")]
            PWOPER_SETTLEMNT = 40,

            /// <summary>
            /// Reserva uma venda no limite do cartão do cliente, porém sem efetivar a venda.
            /// </summary>
            [Description("Valor: 29h, (Pré-autorização) Reserva o valor correspondente a uma venda no limite do cartão de crédito de um Cliente, porém sem efetivar a transferência de fundos.")]
            PWOPER_PREAUTH = 41,

            /// <summary>
            /// Cancelamento de pré-autorização
            /// </summary>
            [Description("Valor: 2Ah, (Cancelamento de pré-autorização) Cancela uma transação PWOPER_PREAUTH, liberando o valor reservado no limite do cartão de crédito.")]
            PWOPER_PREAUTVOID = 42,

            /// <summary>
            /// (Saque) Registra a retirada de um valor em espeécie pelo Cliente no estabelecimento para transferência de fundo nas respectivas contas.
            /// </summary>
            [Description("Valor: 2Bh, (Saque) Registra a retirada de um valor em espécie pelo Cliente no Estabelecimento, para transferência de fundos nas respectivas contas.")]
            PWOPER_CASHWDRWL = 43,

            /// <summary>
            /// (Baixa técnica) Registra uma intervenção técnica no estabelecimento perante o Provedor.
            /// </summary>
            [Description("Valor: 2Ch, (Baixa técnica) Registra uma intervenção técnica no estabelecimento perante o Provedor.")]
            PWOPER_LOCALMAINT = 44,

            /// <summary>
            /// Consulta taxas de financimento referentes a uma possível venda parcelada, sem efetivar a transferência de fundos ou impactar o limite de crédito do Cliente.
            /// </summary>
            [Description("Valor: 2Dh, Consulta as taxas de financiamento referentes a uma possível venda parcelada, sem efetivar a transferência de fundos ou impactar o limite de crédito do Cliente.")]
            PWOPER_FINANCINQ = 45,

            /// <summary>
            /// Verifica o endereço do Cliente (Utiliza o Provedor para tal).
            /// </summary>
            [Description("Valor: 2Eh, Verifica junto ao Provedor o endereço do Cliente.")]
            PWOPER_ADDRVERIF = 46,

            /// <summary>
            /// Efetiva pré-autorização, previamente realizada, efetuando uma transferência de fundos entre as contas do Estabelecimento e do Cliente.
            /// </summary>
            [Description("Valor: 2Fh, Efetiva uma pré-autorização (PWOPER_PREAUTH), previamente realizada, realizando a transferência de fundos entre as contas do Estabelecimento e do Cliente.")]
            PWOPER_SALEPRE = 47,

            /// <summary>
            /// Registra o acúmulo de pontos pelo Cliente, a partir de um programa de fidelidade.
            /// </summary>
            [Description("Valor: 30h, Registra o acúmulo de pontos pelo Cliente, a partir de um programa de fidelidade.")]
            PWOPER_LOYCREDIT = 48,

            /// <summary>
            /// Cancela uma transação PWOPER_LOYDEBIT.
            /// </summary>
            [Description("Valor: 31h, Cancela uma transação PWOPER_LOYCREDIT.")]
            PWOPER_LOYCREDVOID = 49,

            /// <summary>
            /// Registra pontos do Cliente (programa de fidelidade).
            /// </summary>
            [Description("Valor: 32h, Registra o resgate de pontos/prêmio pelo Cliente, a partir de um programa de fidelidade.")]
            PWOPER_LOYDEBIT = 50,

            /// <summary>
            /// Cancela uma transação LOYDEBIT
            /// </summary>
            [Description("Valor: 33h, Cancela uma transação PWOPER_LOYDEBIT.")]
            PWOPER_LOYDEBVOID = 51,

            /// <summary>
            /// Exibe um menu com os cancelamentos disponíveis, caso só exista um tipo, este é seleiconado automaticamente.
            /// </summary>
            [Description("Valor: 39h, Exibe um menu com os cancelamentos disponíveis, caso só exista um tipo, este é selecionado automaticamente.")]
            PWOPER_VOID = 39,

            /// <summary>
            /// Permite consultar a versão da biblioteca atualmente em uso.
            /// </summary>
            [Description("Valor: FCh, (Versão) Permite consultar a versão da biblioteca atualmente em uso.")]
            PWOPER_VERSION = 252,

            /// <summary>
            /// (configuração), Visualiza e altera os parâmetros de operação locais da biblioteca.
            /// </summary>
            [Description("Valor: FDh, (Configuração) Visualiza e altera os parâmetros de operação locais da biblioteca.")]
            PWOPER_CONFIG = 253,

            /// <summary>
            /// Manutenção, apaga todas as configurações do Ponto de captura, devendo ser novamente realizada uma transação de instalaçao.
            /// </summary>
            [Description("Valor: FEh, (Manutenção) Apaga todas as configurações do Ponto de Captura, devendo ser novamente realizada uma transação de Instalação.")]
            PWOPER_MAINTENANCE = 254
        }

        public enum PWINFO : int
        {
            /// <summary>
            /// Preenche (PWOPER_xxx), Consultar os valores possíveis na descrição da função (PW_iNewTransac).
            /// </summary>
            [Description("Valor: 02h, Tamanho: 2. Tipo de transação (PWOPER_xxx). Consultar os valores possíveis na descrição da função PW_iNewTransac (página 13).")]
            PWINFO_OPERATION = 2,

            /// <summary>
            /// Identificador do Ponto de Captura.
            /// </summary>
            [Description("Valor: 11h, Tamanho: até 11. Identificador do Ponto de Captura.")]
            PWINFO_POSID = 17,

            /// <summary>
            /// Nome do aplicativo da Automação Comercial.
            /// </summary>
            [Description("Valor: 15h, Tamanho: até 128. Nome do aplicativo de Automação.")]
            PWINFO_AUTNAME = 21,

            /// <summary>
            /// Versão do aplicativo de Automaçao.
            /// </summary>
            [Description("Valor: 16h, Tamanho: até 128. Versão do aplicativo de Automação.")]
            PWINFO_AUTVER = 22,

            /// <summary>
            /// Empresa desenvolvedor do aplicativo de automação.
            /// </summary>
            [Description("Valor: 17h, Tamanho: até 50. Empresa desenvolvedora do aplicativo de Automação.")]
            PWINFO_AUTDEV = 23,

            /// <summary>
            /// Endereço TCP/IP para comunicação com a infraestrutura PayGo Web, no formato endereço IP:porta TCP ou nome do servidor:porta TCP
            /// </summary>
            [Description("Valor: 1Bh, Tamanho: até 50. Endereço TCP/IP para comunicação com a infraestrutura Pay&Go Web, no formato <endereço IP>:<porta TCP> ou <nome do servidor>:<porta TCP>.")]
            PWINFO_DESTTCPIP = 27,

            /// <summary>
            ///  CNPJ/CPF do estabelecimento, sem formatação. Se utilizadas mais de um estabecilemento de afiliação campo é usado para selecionar o estabelcimento a ser utilizado para determinada transação. Caso não, um menu para escolha manual com váris estabelecimentos deve ser exibido.
            /// </summary>
            [Description("Valor: 1Ch, Tamanho: até 14. CNPJ (ou CPF) do Estabelecimento, sem formatação. No caso de estarem sendo utilizadas afiliações de mais de um estabelecimento, este dado pode ser adicionado pela automação para selecionar previamente o estabelecimento a ser utilizado para determinada transação. Caso este dado não seja informado, será solicitada a exibição de um menu para a escolha dentre os vários estabelecimentos disponíveis.")]
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
            [Description("Valor: 24h, Tamanho: até 8. Capacidades da Automação (soma dos valores abaixo): 1: funcionalidade de troco/saque; 2: funcionalidade de desconto; 4: valor fixo, sempre incluir; 8: impressão das vias diferenciadas do comprovante para Cliente/Estabelecimento; 16: impressão do cupom reduzido. 32: utilização de saldo total do voucher para abatimento do valor da compra.")]
            PWINFO_AUTCAP = 36,

            /// <summary>
            /// Valor total da operação.
            /// </summary>
            [Description("Valor: 25h, Tamanho: 12. Valor total da operação, considerando PWINFO_CURREXP (em centavos se igual a 2), incluindo desconto, saque, gorjeta, taxa de embarque, etc.")]
            PWINFO_TOTAMNT = 37,

            /// <summary>
            /// Moeda (padrão ISO4217, 986 parao real).
            /// </summary>
            [Description("Valor: 26h, Tamanho: até 4. Moeda (padrão ISO4217, 986 para o Real)")]
            PWINFO_CURRENCY = 38,

            /// <summary>
            /// Expoente da moeda (2 para centavos).
            /// </summary>
            [Description("Valor: 27h, Tamanho: até 2. Expoente da moeda (2 para centavos).")]
            PWINFO_CURREXP = 39,

            /// <summary>
            /// Identificador do documento fiscal.
            /// </summary>
            [Description("Valor: 28h, Tamanho: até 12. Identificador do documento fiscal.")]
            PWINFO_FISCALREF = 40,

            /// <summary>
            /// Tipo de cartão utilizado 
            /// 1: crédito;
            /// 2: débito;
            /// 4: voucher/PAT;
            /// 8: outros
            /// </summary>
            [Description("Valor: 29h, Tamanho: até 2. Tipo de cartão utilizado (PW_iGetResult), ou tipos de cartão aceitos (soma dos valores abaixo, PW_iAddParam): 1: crédito 2: débito 4: voucher/PAT 8: outros.")]
            PWINFO_CARDTYPE = 41,

            /// <summary>
            /// Nome/Tipo do prorduto utilizado, na nomenclatura do provedor.
            /// </summary>
            [Description("Valor: 2Ah, Tamanho: até 20. Nome/tipo do produto utilizado, na nomenclatura do Provedor.")]
            PWINFO_PRODUCTNAME = 42,

            /// <summary>
            /// Data e hora local da transação. Formato = AAAAMMDDhhmmss
            /// </summary>
            [Description("Valor: 31h, Tamanho: 14. Data e hora local da transação, no formato “AAAAMMDDhhmmss”.")]
            PWINFO_DATETIME = 49,

            /// <summary>
            /// Referência local da transação
            /// </summary>
            [Description("Valor: 32h, Tamanho: até 10. Referência local da transação.")]
            PWINFO_REQNUM = 50,

            /// <summary>
            /// Nome do Provedor: "ELAVON"; "FILLIP"; "LIBERCARD"; "RV"; etc..
            /// </summary>
            [Description("Valor: 35h, Tamanho: até 20. Nome do Provedor: “ELAVON”; “FILLIP”; “LIBERCARD”; “RV”; etc.")]
            PWINFO_AUTHSYST = 53,

            /// <summary>
            /// identificador do Estabelecimento.
            /// </summary>
            [Description("Valor: 36h, Tamanho: até 9. Identificador do Estabelecimento.")]
            PWINFO_VIRTMERCH = 54,

            /// <summary>
            /// Identificador do estabelecimento para o Provedor.
            /// </summary>
            [Description("Valor: 38h, Tamanho: até 50. Identificador do estabelecimento para o Provedor (código de afiliação).")]
            PWINFO_AUTMERCHID = 56,

            /// <summary>
            /// Número do telefone, com DDD (10 ou 11 dígitos).
            /// </summary>
            [Description("Valor: 3Ah, Tamanhp: até 11. Número do telefone, com o DDD (10 ou 11 dígitos).")]
            PWINFO_PHONEFULLNO = 58,

            /// <summary>
            /// Modalidade de financiamento da transação:
            /// 1:à vista;
            /// 2: parcelado pelo emissor,
            /// 4: parcelado pelo estabelcimento;
            /// 8: pré-datado.
            /// </summary>
            [Description("Valor: 3Bh, Tamanho: até 2. Modalidade de financiamento da transação: 1: à vista 2: parcelado pelo emissor 4: parcelado pelo estabelecimento 8: pré-datado")]
            PWINFO_FINTYPE = 59,

            /// <summary>
            /// Quantidade de parcelas.
            /// </summary>
            [Description("Valor: 3Ch, Tamanho: até 2 Quantidade de parcelas.")]
            PWINFO_INSTALLMENTS = 60,

            /// <summary>
            /// Data de vencimento do pré-datado, ou da primeira parcela Formato "DDMMAA".
            /// </summary>
            [Description("Valor: 3Dh, Tamanho: 6 Data de vencimento do pré-datado, ou da primeira parcela. Formato “DDMMAA”.")]
            PWINFO_INSTALLMDATE = 61,

            /// <summary>
            /// Identificação do produto utilizado, de acordo com a nomenclatura do Provedor.
            /// </summary>
            [Description("Valor: 3Eh, Tamanho: até 8. Identificação do produto utilizado, de acordo com a nomenclatura do Provedor.")]
            PWINFO_PRODUCTID = 62,

            /// <summary>
            /// Msg descrevendo o resultado final da transação. (independe do sucesso). Interface com o usuário..
            /// </summary>
            [Description("Valor: 42h, Tamanho: até 80. Mensagem descrevendo o resultado final da transação, seja esta bem ou mal sucedida (conforme “4.3.Interface com o usuário”, página 8).")]
            PWINFO_RESULTMSG = 66,

            /// <summary>
            /// Necessidade de confirmação:
            /// 0: não requer confirmação;
            /// 1: requer confirmação.
            /// </summary>
            [Description("Valor: 43h, Tamanho: 1. Necessidade de confirmação: 0: não requer confirmação; 1: requer confirmação.")]
            PWINFO_CNFREQ = 67,

            /// <summary>
            /// Referência da transação para a infraestrutura Paygo.
            /// </summary>
            [Description("Valor: 44h, Tamanho: até 50. Referência da transação para a infraestrutura Pay&Go Web.")]
            PWINFO_AUTLOCREF = 68,

            /// <summary>
            /// Referê cia da transação para o Provedor.
            /// </summary>
            [Description("Valor: 45h, Tamanho: até 50. Referência da transação para o Provedor (NSU host).")]
            PWINFO_AUTEXTREF = 69,

            /// <summary>
            /// Código de autorização.
            /// </summary>
            [Description("Valor: 46h, Tamanho: 6. Código de autorização.")]
            PWINFO_AUTHCODE = 70,

            /// <summary>
            /// Cd de resposta da transação.
            /// </summary>
            [Description("Valor: 47h, Tamanho: até 10. Código de resposta da transação (campo ISO8583:39)")]
            PWINFO_AUTRESPCODE = 71,

            /// <summary>
            /// Data/hora da transação para o Provedor, formato “AAAAMMDDhhmmss”. 
            /// </summary>
            [Description("Valor: 48h, Tamanho: 14 Data/hora da transação para o Provedor, formato “AAAAMMDDhhmmss”.")]
            PWINFO_AUTDATETIME = 48,

            /// <summary>
            /// Valor do desconto concedido pelo Provedor, considerando PWINFO_CURREXP já reduzido em PWINFO_TOTAMNT.
            /// </summary>
            [Description("Valor: 49h, Tamanho: até 12. Valor do desconto concedido pelo Provedor, considerando PWINFO_CURREXP, já deduzido em PWINFO_TOTAMNT.")]
            PWINFO_DISCOUNTAMT = 73,

            /// <summary>
            /// Valor do saque/troco.
            /// </summary>
            [Description("Valor: 4Ah, Tamanho: 12. Valor do saque/troco, considerando PWINFO_CURREXP, já incluído em PWINFO_TOTAMNT.")]
            PWINFO_CASHBACKAMT = 74,

            /// <summary>
            /// Nome do cartção ou do emissor do cartão.
            /// </summary>
            [Description("Valor: 4Bh, Tamanho: até 12 Nome do cartão ou do emissor do cartão.")]
            PWINFO_CARDNAME = 75,

            /// <summary>
            /// Modalidade da transação. 1: Online; 2: off-line.
            /// </summary>
            [Description("Valor: 4Ch, Tamanho: 1. Modalidade da transação: 1: online 2: off-line")]
            PWINFO_ONOFF = 76,

            /// <summary>
            /// Valor da taxa de embarque, pconsidera valores já inclsusos em outras funções.
            /// </summary>
            [Description("Valor: 4Dh, Tamanho: 12. Valor da taxa de embarque, considerando PWINFO_CURREXP, já incluído em PWINFO_TOTAMNT.")]
            PWINFO_BOARDINGTAX = 77,

            /// <summary>
            /// Valor da taxa de serviço (gorjeta), considera outros valores já inclusos.
            /// </summary>
            [Description("Valor: 4Eh, Tamanho: 12. Valor da taxa de serviço (gorjeta), considerando PWINFO_CURREXP, já incluído em PWINFO_TOTAMNT.")]
            PWINFO_TIPAMOUNT = 78,

            /// <summary>
            /// Valor da entrada para um pagamento parcelado, considera outros valores já inclusos.
            /// </summary>
            [Description("Valor: 4Fh, Tamanho: 12. Valor da entrada para um pagamento parcelado, considerando PWINFO_CURREXP, já incluído em PWINFO_TOTAMNT.")]
            PWINFO_INSTALLM1AMT = 79,

            /// <summary>
            /// Valor da parcela, considerando PWINFO_CURREXP, já incluído em PWINFO_TOTAMNT.
            /// </summary>
            [Description("Valor: 50h, Tamanho: 12. Valor da parcela, considerando PWINFO_CURREXP, já incluído em PWINFO_TOTAMNT.")]
            PWINFO_INSTALLMAMNT = 80,

            /// <summary>
            /// Comprovante para impressão - Via completa. Até 40 colunas, quebras de linha identificadas pelo Caractere 0Dh
            /// </summary>
            [Description("Valor: 52h, Comprovante para impressão – Via completa. Tamanho: Até 40 colunas, quebras de linha identificadas pelo caractere 0Dh.")]
            PWINFO_RCPTFULL = 82,

            /// <summary>
            /// Comprovante para impressão - Via diferenciada para o Estabelecimento.
            /// </summary>
            [Description("Valor: 53h Comprovante para impressão – Via diferenciada para o Estabelecimento. Tamanho: Até 40 colunas, quebras de linha identificadas pelo caractere 0Dh.")]
            PWINFO_RCPTMERCH = 83,

            /// <summary>
            /// Via diferenciada para o Cliente.
            /// </summary>
            [Description("Valor: 54h Comprovante para impressão – Via diferenciada para o Cliente. Tamanho: Até 40 colunas, quebras de linha identificadas pelo caractere 0Dh.")]
            PWINFO_RCPTCHOLDER = 84,

            /// <summary>
            /// Cupom reduzido (para o cliente).
            /// </summary>
            [Description("Valor: 55h Comprovante para impressão – Cupom reduzido (para o Cliente). Tamanho: Até 40 colunas, quebras de linha identificadas pelo caractere 0Dh.")]
            PWINFO_RCPTCHSHORT = 85,

            /// <summary>
            /// Data de transação original. (no caso de um cancelamento ou pré-autorização).
            /// </summary>
            [Description("Valor: 57h, Tamanho: 6. Data da transação original, no caso de um cancelamento ou uma confirmação de pré-autorização (formato “DDMMAA”).")]
            PWINFO_TRNORIGDATE = 87,

            /// <summary>
            /// NSU da transação original, no caso de um cancelamento ou uma confi de pré-autorização.
            /// </summary>
            [Description("Valor: 58h, Tamanho: até 50. NSU da transação original, no caso de um cancelamento ou uma confirmação de pré-autorização.")]
            PWINFO_TRNORIGNSU = 88,

            /// <summary>
            /// Valor da transação original, no caso de um cancelamento ou uma confirmaçao de pré-autorização.
            /// </summary>
            [Description("Valor: 60h, Tamanho: 12. Valor da transação original, no caso de um cancelamento ou uma confirmação de pré-autorização.")]
            PWINFO_TRNORIGAMNT = 96,

            /// <summary>
            /// Idioma a ser utilizado para a interface com o cliente:
            /// 0: Português;
            /// 1: Inglês;
            /// 2: Espanhol.
            /// </summary>
            [Description("Valor: 6Ch, Tamanho: 1. Idioma a ser utilizado para a interface com o cliente: 0: Português 1: Inglês 2: Espanhol")]
            PWINFO_LANGUAGE = 108,

            /// <summary>
            /// Código de autorização da transação original (caso cancel ou pré-auto).
            /// </summary>
            [Description("Valor: 62h, Tamanho: até 6. Código de autorização da transação original, no caso de um cancelamento ou uma confirmação de pré-autorização.")]
            PWINFO_TRNORIGAUTH = 98,

            /// <summary>
            /// Valor: 6Fh, Tamanho: Até 84. Mensagem a ser exibida para o cliente durante o processamento da transação.
            /// </summary>
            [Description("Valor: 6Fh, Tamanho: Até 84. Mensagem a ser exibida para o cliente durante o processamento da transação.")]
            PWINFO_PROCESSMSG = 111,

            /// <summary>
            /// Número da solicitção da transação original, no casol de um cancelm ou pré-autor..
            /// </summary>
            [Description("Valor: 72h, Tamanho: até 10. Número da solicitação da transação original, no caso de um cancelamento ou uma confirmação de pré-autorização.")]
            PWINFO_TRNORIGREQNUM = 114,

            /// <summary>
            /// Hora da transação original, no caso de um canc, ou transac pré.. (HHMMSS).
            /// </summary>
            [Description("Valor: 73h, Tamanho: 6. Hora da transação original, no caso de um cancelamento ou uma confirmação de pré-autorização (formato “HHMMSS”).")]
            PWINFO_TRNORIGTIME = 115,

            /// <summary>
            /// Msg a ser exibida para o operador no terminal no caso da transação ser abortada (cancel ou timeout).
            /// </summary>
            [Description("Valor: 74h, Tamanho: até 84. Mensagem a ser exibida para o operador no terminal no caso da transação ser abortada (cancelamento ou timeout).")]
            PWINFO_CNCDSPMSG = 116,

            /// <summary>
            /// Mensagem a ser exibida para o portador no PIN-pad no caso da transação ser abortada (cancelamento ou timeout).s
            /// </summary>
            [Description("Valor: 75h, Tamanho: 32. Mensagem a ser exibida para o portador no PIN-pad no caso da transação ser abortada (cancelamento ou timeout).")]
            PWINFO_CNCPPMSG = 117,

            /// <summary>
            /// Msg a ser exibida caso a operação seja abortada. Modos de entrada do cartão: 1: digitado; 2: tj magnética; 4: chip com contato; 16: fallback de  chip p/tarja; 32: chip sem contato simulando tarja(cliente informa tipo efetivamente utilizado); 64: chip sem contato EMV (cli informa); 256: fallback de tj para digitado.
            /// </summary>
            [Description("Valor: C0h, Tamanho: 3. Modo(s) de entrada do cartão: 1: digitado 2: tarja magnética 4: chip com contato 16: fallback de chip para tarja 32: chip sem contato simulando tarja (cliente informa tipo efetivamente utilizado) 64: chip sem contato EMV (cliente informa tipo efetivamente utilizado) 256: fallback de tarja para digitado.")]
            PWINFO_CARDENTMODE = 192,

            /// <summary>
            /// número de cartão completo para transação digitada.
            /// </summary>
            [Description("Valor: C1h, Tamanho: até 19. Número do cartão completo, para transação digitada. Este dado não pode ser recuperado pela função PW_iGetResult.")]
            PWINFO_CARDFULLPAN = 193,

            /// <summary>
            /// Dt Vencimento do cartão MMAA
            /// </summary>
            [Description("Valor: C2h, Tamanho: 4 Data de vencimento do cartão (formato “MMAA”).")]
            PWINFO_CARDEXPDATE = 194,

            /// <summary>
            /// Valor: C4h, Tamanho: Até 50. Descrição do produto bandeira padrão relacionado ao BIN.
            /// </summary>
            [Description("Valor: C4h, Tamanho: Até 50. Descrição do produto bandeira padrão relacionado ao BIN.")]
            PWINFO_CARDNAMESTD = 196,

            /// <summary>
            /// Número do cartão truncado ou mascarado.
            /// </summary>
            [Description("Valor: C8h, Tamanho: até 19. Número do cartão, truncado ou mascarado.")]
            PWINFO_CARDPARCPAN = 200,

            /// <summary>
            /// Verificação do portador, soma dos seguintes valores:
            /// 1: assinatura do portador em papel;
            /// 2: Senha verificada off-line;
            /// 4: Senha off-line bloqueada no decorrer desta transação;
            /// 8: Senha verificada online.
            /// </summary>
            [Description("Valor: CFh, Tamanho: 1. Verificação do portador, soma dos seguintes valores: “1”: Assinatura do portador em papel. “2”: Senha verificada off-line. “4”: Senha off-line bloqueada no decorrer desta transação. “8”: Senha verificada online.")]
            PWINFO_CHOLDVERIF = 207,

            /// <summary>
            /// Mod de entrada do código de barras:
            /// 1: digitado;
            /// 2: lido através de dispositivo eletrônico.
            /// </summary>
            [Description("Valor: E9h, Tamanho: 1. Modo(s) de entrada do código de barras: 1:  digitado; 2:  lido através de dispositivo eletrônico.")]
            PWINFO_BARCODENTMODE = 233,

            /// <summary>
            /// Cd de barras completo lido ou digitado.
            /// </summary>
            [Description("Valor: EAh, Tamanho: até 48. Código de barras completo, lido ou digitado.")]
            PWINFO_BARCODE = 234,

            /// <summary>
            /// Dados adicionais relevantes para automação (#1).
            /// </summary>
            [Description("Valor: F0h, Tamanho: até 127. Dados adicionais relevantes para a Automação (#1)")]
            PWINFO_MERCHADDDATA1 = 240,

            /// <summary>
            /// Dados adicionais relevantes para automação (#2).
            /// </summary>
            [Description("Valor: F1h, Tamanho: até 127. Dados adicionais relevantes para a Automação (#2)")]
            PWINFO_MERCHADDDATA2 = 241,

            /// <summary>
            /// Dados adicionais relevantes para automação (#3).
            /// </summary>
            [Description("Valor: F2h, Tamanhp: até 127. Dados adicionais relevantes para a Automação (#3)")]
            PWINFO_MERCHADDDATA3 = 242,

            /// <summary>
            /// Dados adicionais relevantes para automação (#4).
            /// </summary>
            [Description("Valor: F3h, Tamanho: até 127. Dados adicionais relevantes para a Automação (#4)")]
            PWINFO_MERCHADDDATA4 = 243,

            /// <summary>
            /// Indica quais vias de comprovante devem ser impressas:
            /// 0: não há comprovante;
            /// 1: imprimir somente a via do Cliente;
            /// 2: imprimir somente a via do Estabelecimento;
            /// 3: imprimir mabas as vias doCliente e do Estabelecimento.
            /// </summary>
            [Description("Valor: F4h, Tamanho: 1. Indica quais vias de comprovante devem ser impressas: 0: não há comprovante 1: imprimir somente a via do Cliente 2: imprimir somente a via do Estabelecimento 3: imprimir ambas as vias do Cliente e do Estabelecimento")]
            PWINFO_RCPTPRN = 244,

            /// <summary>
            /// Identificador do usuário autenticado com a senha do lojista
            /// </summary>
            [Description("Valor: F5h, Tamanho: até 50. Identificador do usuário autenticado com a senha do lojista.")]
            PWINFO_AUTHMNGTUSER = 245,

            /// <summary>
            /// Identificador do usuário autenticado com a senha técnica.
            /// </summary>
            [Description("Valor: F6h, Tamanho: até 50. Identificador do usuário autenticado com a senha técnica.")]
            PWINFO_AUTHTECHUSER = 246,

            /// <summary>
            /// Modalidade de pagamento:
            /// 1: cartão;
            /// 2: dinheiro;
            /// 3: cheque.
            /// </summary>
            [Description("Valor: 1F21h, Tamanho: até 2. Modalidade de pagamento: 1: cartão 2: dinheiro 3: cheque")]
            PWINFO_PAYMNTTYPE = 7969,

            /// <summary>
            /// Indica se o ponto de captura faz ou nao o uso de PIN-pad.
            /// </summary>
            [Description("Valor: 7F01h, Tamanho: 1. Indica se o ponto de captura faz ou não o uso de PIN-pad: 0: Não utiliza PIN-pad; 1: Utiliza PIN-pad.")]
            PWINFO_USINGPINPAD = 32513,

            /// <summary>
            /// Número da porta serial à qual o PIN-pad está conectado. O Valor 0 indica uma busca automática desta porta.
            /// </summary>
            [Description("Valor: 7F02h, Tamanho: 2. Número da porta serial à qual o PIN-pad está conectado. O valor 0 (zero) indica uma busca automática desta porta.")]
            PWINFO_PPCOMMPORT = 32514,

            /// <summary>
            /// Próxima data e horário que pw_iIdleProc deve ser chamada pela Automação. AAMMDDHHMMSS
            /// </summary>
            [Description("Valor: 7F04h, Tamanho: 12. Próxima data e horário em que a função PW_iIdleProc deve ser chamada pela Automação. Formato “AAMMDDHHMMSS”.")]
            PWINFO_IDLEPROCTIME = 32516,

            /// <summary>
            /// Nome do provedor para o qual existe uma transação pendente.
            /// </summary>
            [Description("Valor: 7F05h, Tamanho: até 20. Nome do provedor para o qual existe uma transação pendente.")]
            PWINFO_PNDAUTHSYST = 32517,

            /// <summary>
            /// Identificador do estabelecimento para o qual existe uma transação pendente.
            /// </summary>
            [Description("Valor: 7F06h, Tamanho: até 9. Identificador do Estabelecimento para o qual existe uma transação pendente.")]
            PWINFO_PNDVIRTMERCH = 32518,

            /// <summary>
            /// Referência da transação que está pendente.
            /// </summary>
            [Description("Valor: 7F07h, Tamanho: até 10. Referência local da transação que está pendente.")]
            PWINFO_PNDREQNUM = 32519,

            /// <summary>
            /// Referência para infraestrutura Paygo da transação pendente.
            /// </summary>
            [Description("Valor: 7F08h, Tamanho: até 50. Referência para a infraestrutura Pay&Go Web da transação que está pendente.")]
            PWINFO_PNDAUTLOCREF = 32520,

            /// <summary>
            /// Referência para o Provedor da transaçsão que está pendente.
            /// </summary>
            [Description("Valor: 7F09h, Tamanho: até 50. Referência para o Provedor da transação que está pendente.")]
            PWINFO_PNDAUTEXTREF = 32521,

            /// <summary>
            /// Texto exibido para um item de menu selecionado pelo usuário.
            /// </summary>
            [Description("Valor: 7F0Ah, Tamanho: até 40. Texto exibido para um item de menu selecionado pelo usuário.")]
            PWINFO_LOCALINFO1 = 32522,

            /// <summary>
            /// Indica se oponto de captura possui alguma pendência a ser resolvida com o Paygo. 1: Possui
            /// </summary>
            [Description("Valor: 7F0Bh, Tamanho: 1. Indica se o ponto de captura possui alguma pendência a ser resolvida com o Pay&Go Web: 0: não possui pendência; 1: possui pendência.")]
            PWINFO_SERVERPND = 32523,

            /// <summary>
            /// 
            /// </summary>
            [Description("Valor: 7F15h, Tamanho: 100. Informações do PIN-pad conectado, seguindo o padrão posição/informação abaixo: 001-020 / Nome do fabricante do PIN-pad. 021-039 / Modelo/versão do hardware. 040 / Se o PIN-pad suporta cartão com chip sem contato, este campo deve conter a letra “C”, caso contrário um espaço em branco. 041-060 / Versão do software básico/firmware. 061-064 / Versão da especificação, no formato “V.VV”. 065-080 / Versão da aplicação básica, no formato “VVV.VV AAMMDD” (com 3 espaços à direita). 081-100 / Número de série do PIN-pad (com espaços à direita).")]
            PWINFO_PPINFO = 0x7F15,

            /// <summary>
            /// Valor devido pelo usuário considerando PWINFO_TOTAMNT e PWINFO_CURREXP.
            /// </summary>
            [Description("Valor: BF06h3, Tamanho: Até 12. Valor devido pelo usuário, considerando PWINFO_CURREXP, já deduzido em PWINFO_TOTAMNT.")]
            PWINFO_DUEAMNT = 0xBF06,

            /// <summary>
            /// Valor total da transação reajustado, este campo será utilizado caso o autorizador, por alguma regra de negócio específica dele, resolva alterar o valor total que foi solictado para atransação.
            /// </summary>
            [Description("Valor: BF09h, Tamanho: Até 12. Valor total da transação reajustado, este campo será utilizado caso o autorizador, por alguma regra de negócio específica dele, resolva alterar o valor total que foi solicitado para a transação.")]
            PWINFO_READJUSTEDAMNT = 0xBF09
        }
    }
}
