using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaygoDoc
{
    public class RetornoMODEL
    {
        public struct Retorno
        {
            public string PWRET_OK { get; set; }
            public string PWRET_FROMHOSTPENDTRN { get; set; }
            public string PWRET_FROMHOSTPOSAUTHERR { get; set; }
            public string PWRET_FROMHOSTUSRAUTHERR { get; set; }
            public string PWRET_FROMHOST { get; set; }
            public string PWRET_TLVERR { get; set; }
            public string PWRET_SRVINVPARAM { get; set; }
            public string PWRET_REQPARAM { get; set; }
            public string PWRET_HOSTCONNUNK { get; set; }
            public string PWRET_INTERNALERR { get; set; }
            public string PWRET_BLOCKED { get; set; }
            public string PWRET_FROMHOSTTRNNFOUND { get; set; }
            public string PWRET_PARAMSFILEERR { get; set; }
            public string PWRET_NOCARDENTMODE { get; set; }
            public string PWRET_INVALIDVIRTMERCH { get; set; }
            public string PWRET_HOSTTIMEOUT { get; set; }
            public string PWRET_CONFIGREQUIRED { get; set; }
            public string PWRET_HOSTCONNERR { get; set; }
            public string PWRET_HOSTCONNLOST { get; set; }
            public string PWRET_FILEERR { get; set; }
            public string PWRET_PINPADERR { get; set; }
            public string PWRET_MAGSTRIPEERR { get; set; }
            public string PWRET_PPCRYPTERR { get; set; }
            public string PWRET_SSLCERTERR { get; set; }
            public string PWRET_SSLNCONN { get; set; }
            public string PWRET_GPRSATTACHFAILED { get; set; }
            public string PWRET_INVPARAM { get; set; }
            public string PWRET_NOTINST { get; set; }
            public string PWRET_MOREDATA { get; set; }
            public string PWRET_NODATA { get; set; }
            public string PWRET_DISPLAY { get; set; }
            public string PWRET_INVCALL { get; set; }
            public string PWRET_NOTHING { get; set; }
            public string PWRET_BUFOVFLW { get; set; }
            public string PWRET_CANCEL { get; set; }
            public string PWRET_TIMEOUT { get; set; }
            public string PWRET_PPNOTFOUND { get; set; }
            public string PWRET_TRNNOTINIT { get; set; }
            public string PWRET_DLLNOTINIT { get; set; }
            public string PWRET_FALLBACK { get; set; }
            public string PWRET_WRITERR { get; set; }
            public string PWRET_PPCOMERR { get; set; }
            public string PWRET_NOMANDATORY { get; set; }
            public string PWRET_INVALIDTRN { get; set; }
            public string PWRET_PPS_XXX { get; set; }
        }

        public enum PWRET
        {
            /// <summary>
            /// Sucesso!
            /// </summary>
            PWRET_OK = 0,

            /// <summary>
            /// Transação Pendente
            /// </summary>
            PWRET_FROMHOSTPENDTRN = -2599,

            /// <summary>
            /// Falha de autenticação de ponto de captura
            /// </summary>
            PWRET_FROMHOSTPOSAUTHERR = -2598,

            /// <summary>
            /// Falha de autenticação do usuário
            /// </summary>
            PWRET_FROMHOSTUSRAUTHERR = -2597,

            /// <summary>
            /// Erro interno da infraestrutura Paygo
            /// </summary>
            PWRET_FROMHOST = -2596,

            /// <summary>
            /// Codificação da mensagem = Falha de comunicação com a infraestrutura Paygo
            /// </summary>
            PWRET_TLVERR = -2595,

            /// <summary>
            /// Parâmetro inválido : Falha de comunicação com ifraestrutura Paygo
            /// </summary>
            PWRET_SRVINVPARAM = -2594,

            /// <summary>
            /// Falta de parâmetro obrigatório : Falha de comunicação com infraestrutura Paygo
            /// </summary>
            PWRET_REQPARAM = -2593,

            /// <summary>
            /// Conexão ao host : Erro interno da biblioteca
            /// </summary>
            PWRET_HOSTCONNUNK = -2592,

            /// <summary>
            /// Erro interno da biblioteca
            /// </summary>
            PWRET_INTERNALERR = -2591,

            /// <summary>
            /// Ponto de Captura bloqueado para uso
            /// </summary>
            PWRET_BLOCKED = -2590,

            /// <summary>
            /// Transação referenciada não encontrada. Cancelamento, confirmação, etc..
            /// </summary>
            PWRET_FROMHOSTTRNNFOUND = -2589,

            /// <summary>
            /// Inconsistência dos parâmetros recebidos.
            /// </summary>
            PWRET_PARAMSFILEERR = -2588,

            /// <summary>
            /// Ponto de captura não cacpacitado de efetuar captura do cartão através dos parâmetros de entrada.
            /// </summary>
            PWRET_NOCARDENTMODE = -2587,

            /// <summary>
            /// Código de Afiliação Inválida
            /// </summary>
            PWRET_INVALIDVIRTMERCH = -2586,

            /// <summary>
            /// Tempo de resposta esgotado
            /// </summary>
            PWRET_HOSTTIMEOUT = -2585,

            /// <summary>
            /// Erro de configuração (acionar a função de config)
            /// </summary>
            PWRET_CONFIGREQUIRED = -2584,

            /// <summary>
            /// Falha de conexão
            /// </summary>
            PWRET_HOSTCONNERR = -2583,

            /// <summary>
            /// Conexão interrompida
            /// </summary>
            PWRET_HOSTCONNLOST = -2582,

            /// <summary>
            /// Falho no acesso da biblioteca de integração.
            /// </summary>
            PWRET_FILEERR = -2581,

            /// <summary>
            /// Falha de comunicação com o PIN-pad (aplicação)
            /// </summary>
            PWRET_PINPADERR = -2580,

            /// <summary>
            /// Formato de Tarja magnética não reconhecido
            /// </summary>
            PWRET_MAGSTRIPEERR = -2579,

            /// <summary>
            /// Falha de comunicação com o PIN-pad, comunicação não segura.
            /// </summary>
            PWRET_PPCRYPTERR = -2578,

            /// <summary>
            /// Falha no certificado SSL.
            /// </summary>
            PWRET_SSLCERTERR = -2577,

            /// <summary>
            /// Falha ao tentar estabelecer conexão SSL.
            /// </summary>
            PWRET_SSLNCONN = -2576,

            /// <summary>
            /// Falha no registroo GPRS.
            /// </summary>
            PWRET_GPRSATTACHFAILED = -2575,

            /// <summary>
            /// Parâmetro inválido passado à função.
            /// </summary>
            PWRET_INVPARAM = -2499,

            /// <summary>
            /// Ponto de captura não instalado, acionar função para
            /// </summary>
            PWRET_NOTINST = -2498,

            /// <summary>
            /// Falta de dados para transação ser realizada
            /// </summary>
            PWRET_MOREDATA = -2497,

            /// <summary>
            /// Informação solicitada indisponível
            /// </summary>
            PWRET_NODATA = -2496,

            /// <summary>
            /// A automação deve apresentar uma mensagem para o usuário.
            /// </summary>
            PWRET_DISPLAY = -2495,

            /// <summary>
            /// Função chamada no momento incorreto
            /// </summary>
            PWRET_INVCALL = -2494,

            /// <summary>
            /// Nada a fazer, continuar procedimento
            /// </summary>
            PWRET_NOTHING = -2493,

            /// <summary>
            /// Tamanho da área de memória informado é insuficiente
            /// </summary>
            PWRET_BUFOVFLW = -2492,

            /// <summary>
            /// Operação cancelada pelo operador.
            /// </summary>
            PWRET_CANCEL = -2491,

            /// <summary>
            /// Tempo limite excedido para ação do operador
            /// </summary>
            PWRET_TIMEOUT = -2490,

            /// <summary>
            /// PIN-pad não encontrado na busca efetuada.
            /// </summary>
            PWRET_PPNOTFOUND = -2489,

            /// <summary>
            /// Função PW_iNewTransac não foi chamada
            /// </summary>
            PWRET_TRNNOTINIT = -2488,

            /// <summary>
            /// PW_iInit não foi chamada
            /// </summary>
            PWRET_DLLNOTINIT = -2487,

            /// <summary>
            /// Erro no cartão magnético, passar a aceitar o cartão ditiado caso já não esteja sendo aceito.
            /// </summary>
            PWRET_FALLBACK = -2486,

            /// <summary>
            /// Falha de gravação no diretório de trabalho.
            /// </summary>
            PWRET_WRITERR = -2485,

            /// <summary>
            /// Falha de comunicação com o PIN-pad (protocolo).
            /// </summary>
            PWRET_PPCOMERR = -2484,

            /// <summary>
            /// Alguns dos parâmetros obrigatórios não foram adicionados.
            /// </summary>
            PWRET_NOMANDATORY = -2483,

            /// <summary>
            /// Confirmação inexistente ou já confirmada.
            /// </summary>
            PWRET_INVALIDTRN = -2482,

            /// <summary>
            /// Erros do PIN-pad
            /// </summary>
            PWRET_PPS_XXX = -2200
        }
    }
}
