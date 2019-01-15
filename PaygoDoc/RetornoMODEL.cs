using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaygoDoc
{
    public class RetornoMODEL
    {
        public enum PWRET : int
        {
            /// <summary>
            /// Sucesso!
            /// </summary>
            [Description("Código: 0. Operação bem sucedida.")]
            PWRET_OK = 0,

            /// <summary>
            /// Transação Pendente
            /// </summary>
            [Description("Código: -2599. Existe uma transação pendente, é necessário confirmar ou desfazer essa transação através de PW_iConfirmation.")]
            PWRET_FROMHOSTPENDTRN = -2599,

            /// <summary>
            /// Falha de autenticação de ponto de captura
            /// </summary>
            [Description("Código: -2598. Falha de autenticação do ponto de captura com a infraestrutura do Pay&Go Web.")]
            PWRET_FROMHOSTPOSAUTHERR = -2598,

            /// <summary>
            /// Falha de autenticação do usuário
            /// </summary>
            [Description("Código: -2597. Falha de autenticação do usuário.")]
            PWRET_FROMHOSTUSRAUTHERR = -2597,

            /// <summary>
            /// Erro interno da infraestrutura Paygo
            /// </summary>
            [Description("Código: -2596. Erro retornado pela infraestrutura do Pay&Go Web. Verificar a mensagem (PWINFO_RESULTMSG) para mais informações.")]
            PWRET_FROMHOST = -2596,

            /// <summary>
            /// Codificação da mensagem = Falha de comunicação com a infraestrutura Paygo
            /// </summary>
            [Description("Código: -2595. Falha de comunicação com a infraestrutura do Pay&Go Web (codificação da mensagem).")]
            PWRET_TLVERR = -2595,

            /// <summary>
            /// Parâmetro inválido : Falha de comunicação com ifraestrutura Paygo
            /// </summary>
            [Description("Código: -2594. Falha de comunicação com a infraestrutura do Pay&Go Web (parâmetro inválido).")]
            PWRET_SRVINVPARAM = -2594,

            /// <summary>
            /// Falta de parâmetro obrigatório : Falha de comunicação com infraestrutura Paygo
            /// </summary>
            [Description("Código: -2593. Falha de comunicação com a infraestrutura do Pay&Go Web (falta parâmetro obrigatório).")]
            PWRET_REQPARAM = -2593,

            /// <summary>
            /// Conexão ao host : Erro interno da biblioteca
            /// </summary>
            [Description("Código: -2592. Erro interno da biblioteca (conexão ao host).")]
            PWRET_HOSTCONNUNK = -2592,

            /// <summary>
            /// Erro interno da biblioteca
            /// </summary>
            [Description("Código: -2591. Erro interno da biblioteca.")]
            PWRET_INTERNALERR = -2591,

            /// <summary>
            /// Ponto de Captura bloqueado para uso
            /// </summary>
            [Description("Código: -2590. O ponto de captura foi bloqueado para uso.")]
            PWRET_BLOCKED = -2590,

            /// <summary>
            /// Transação referenciada não encontrada. Cancelamento, confirmação, etc..
            /// </summary>
            [Description("Código: -2589. A transação referenciada (cancelamento, confirmação, etc.) não foi encontrada.")]
            PWRET_FROMHOSTTRNNFOUND = -2589,

            /// <summary>
            /// Inconsistência dos parâmetros recebidos.
            /// </summary>
            [Description("Código: -2588. Inconsistência dos parâmetros de operação recebidos da infraestrutura do Pay&Go Web.")]
            PWRET_PARAMSFILEERR = -2588,

            /// <summary>
            /// Ponto de captura não cacpacitado de efetuar captura do cartão através dos parâmetros de entrada.
            /// </summary>
            [Description("Código: -2587. O Ponto de Captura não tem a capacidade de efetuar a captura do cartão através dos tipos de entrada especificados pelo Pay&Go Web.")]
            PWRET_NOCARDENTMODE = -2587,

            /// <summary>
            /// Código de Afiliação Inválida
            /// </summary>
            [Description("Código: -2586. Falha de comunicação com a infraestrutura do Pay&Go Web (código de afiliação inválido).")]
            PWRET_INVALIDVIRTMERCH = -2586,

            /// <summary>
            /// Tempo de resposta esgotado
            /// </summary>
            [Description("Código: -2585. Falha de comunicação com a infraestrutura do Pay&Go Web (tempo de resposta esgotado).")]
            PWRET_HOSTTIMEOUT = -2585,

            /// <summary>
            /// Erro de configuração (acionar a função de config)
            /// </summary>
            [Description("Código: -2584. Erro de configuração. É necessário acionar a função de configuração.")]
            PWRET_CONFIGREQUIRED = -2584,

            /// <summary>
            /// Falha de conexão
            /// </summary>
            [Description("Código: -2583. Falha de conexão à infraestrutura do Pay&Go Web.")]
            PWRET_HOSTCONNERR = -2583,

            /// <summary>
            /// Conexão interrompida
            /// </summary>
            [Description("Código: -2582. A conexão com a infraestrutura do Pay&Go Web foi interrompida.")]
            PWRET_HOSTCONNLOST = -2582,

            /// <summary>
            /// Falho no acesso da biblioteca de integração.
            /// </summary>
            [Description("Código: -2581. Falha no acesso aos arquivos da biblioteca de integração.")]
            PWRET_FILEERR = -2581,

            /// <summary>
            /// Falha de comunicação com o PIN-pad (aplicação)
            /// </summary>
            [Description("Código: -2580. Falha de comunicação com o PIN-pad (aplicação).")]
            PWRET_PINPADERR = -2580,

            /// <summary>
            /// Formato de Tarja magnética não reconhecido
            /// </summary>
            [Description("Código: -2579. Formato de tarja magnética não reconhecido.")]
            PWRET_MAGSTRIPEERR = -2579,

            /// <summary>
            /// Falha de comunicação com o PIN-pad, comunicação não segura.
            /// </summary>
            [Description("Código: -2578. Falha de comunicação com o PIN-pad (comunicação segura).")]
            PWRET_PPCRYPTERR = -2578,

            /// <summary>
            /// Falha no certificado SSL.
            /// </summary>
            [Description("Código: -2577. Falha no certificado SSL.")]
            PWRET_SSLCERTERR = -2577,

            /// <summary>
            /// Falha ao tentar estabelecer conexão SSL.
            /// </summary>
            [Description("Código: -2576. Falha ao tentar estabelecer conexão SSL.")]
            PWRET_SSLNCONN = -2576,

            /// <summary>
            /// Falha no registroo GPRS.
            /// </summary>
            [Description("Código: -2575. Falha no registro GPRS.")]
            PWRET_GPRSATTACHFAILED = -2575,

            /// <summary>
            /// Parâmetro inválido passado à função.
            /// </summary>
            [Description("Código: -2499. Parâmetro inválido passado à função.")]
            PWRET_INVPARAM = -2499,

            /// <summary>
            /// Ponto de captura não instalado, acionar função para
            /// </summary>
            [Description("Código: -2498. Ponto de Captura não instalado. É necessário acionar a função de Instalação.")]
            PWRET_NOTINST = -2498,

            /// <summary>
            /// Falta de dados para transação ser realizada
            /// </summary>
            [Description("Código: -2497. Ainda existem dados que precisam ser capturados para a transação poder ser realizada.")]
            PWRET_MOREDATA = -2497,

            /// <summary>
            /// Informação solicitada indisponível
            /// </summary>
            [Description("Código: -2496. A informação solicitada não está disponível.")]
            PWRET_NODATA = -2496,

            /// <summary>
            /// A automação deve apresentar uma mensagem para o usuário.
            /// </summary>
            [Description("Código: -2495. A Automação deve apresentar uma mensagem para o operador.")]
            PWRET_DISPLAY = -2495,

            /// <summary>
            /// Função chamada no momento incorreto
            /// </summary>
            [Description("Código: -2494. Função chamada no momento incorreto.")]
            PWRET_INVCALL = -2494,

            /// <summary>
            /// Nada a fazer, continuar procedimento
            /// </summary>
            [Description("Código: -2493. Nada a fazer, continuar o processamento.")]
            PWRET_NOTHING = -2493,

            /// <summary>
            /// Tamanho da área de memória informado é insuficiente
            /// </summary>
            [Description("Código: -2492. O tamanho da área de memória informado é insuficiente.")]
            PWRET_BUFOVFLW = -2492,

            /// <summary>
            /// Operação cancelada pelo operador.
            /// </summary>
            [Description("Código: -2491. Operação cancelada pelo operador.")]
            PWRET_CANCEL = -2491,

            /// <summary>
            /// Tempo limite excedido para ação do operador
            /// </summary>
            [Description("Código: -2490. Tempo limite excedido para ação do operador.")]
            PWRET_TIMEOUT = -2490,

            /// <summary>
            /// PIN-pad não encontrado na busca efetuada.
            /// </summary>
            [Description("Código: -2489. PIN-pad não encontrado na busca efetuada.")]
            PWRET_PPNOTFOUND = -2489,

            /// <summary>
            /// Função PW_iNewTransac não foi chamada
            /// </summary>
            [Description("Código: -2488. Não foi chamada a função PW_iNewTransac.")]
            PWRET_TRNNOTINIT = -2488,

            /// <summary>
            /// PW_iInit não foi chamada
            /// </summary>
            [Description("Código: -2487. Não foi chamada a função PW_iInit.")]
            PWRET_DLLNOTINIT = -2487,

            /// <summary>
            /// Erro no cartão magnético, passar a aceitar o cartão ditiado caso já não esteja sendo aceito.
            /// </summary>
            [Description("Código: -2486. Ocorreu um erro no cartão magnético, passar a aceitar o cartão digitado, caso já não esteja sendo aceito.")]
            PWRET_FALLBACK = -2486,

            /// <summary>
            /// Falha de gravação no diretório de trabalho.
            /// </summary>
            [Description("Código: -2485. Falha de gravação no diretório de trabalho.")]
            PWRET_WRITERR = -2485,

            /// <summary>
            /// Falha de comunicação com o PIN-pad (protocolo).
            /// </summary>
            [Description("Código: -2484. Falha na comunicação com o PIN-pad (protocolo).")]
            PWRET_PPCOMERR = -2484,

            /// <summary>
            /// Alguns dos parâmetros obrigatórios não foram adicionados.
            /// </summary>
            [Description("Código: -2483. Algum dos parâmetros obrigatórios não foi adicionado.")]
            PWRET_NOMANDATORY = -2483,

            /// <summary>
            /// Confirmação inexistente ou já confirmada.
            /// </summary>
            [Description("Código: -2482. A transação informada para confirmação não existe ou já foi confirmada anteriormente.")]
            PWRET_INVALIDTRN = -2482,

            /// <summary>
            /// Erros do PIN-pad
            /// </summary>
            [Description("Código: -2200. até -2100 Erros retornados pelo PIN-")]
            PWRET_PPS_XXX = -2200
        }
    }
}