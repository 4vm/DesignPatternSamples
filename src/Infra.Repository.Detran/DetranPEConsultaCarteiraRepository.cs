using DesignPatternSamples.Application.DTO;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace DesignPatternSamples.Infra.Repository.Detran
{
    public class DetranPEConsultaCarteiraRepository : DetranConsultarCarteiraRepositoryCrawlerBase
    {
        private readonly ILogger _Logger;

        public DetranPEConsultaCarteiraRepository(ILogger<DetranPEConsultaCarteiraRepository> logger)
        {
            _Logger = logger;
        }

        protected override Task<Carteira> PadronizarResultado(string html)
        {
            _Logger.LogDebug($"Padronizando o Resultado {html}.");
            return Task.FromResult(new Carteira { Nome = "João", Numero = "999", Ponto = 20 });
        }

        protected override Task<string> RealizarAcesso(string numero)
        {
            Task.Delay(5000).Wait(); //Deixando o serviço mais lento para evidenciar o uso do CACHE.
            _Logger.LogDebug($"Consultando carteira {numero} para o estado de PE.");
            return Task.FromResult("CONTEUDO DO SITE DO DETRAN/PE");
        }

    }
}
